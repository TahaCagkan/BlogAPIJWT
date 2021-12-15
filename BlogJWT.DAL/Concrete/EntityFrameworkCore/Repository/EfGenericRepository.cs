using BlogJWT.Core.DAL;
using BlogJWT.Core.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository
{
    public class EfGenericRepository<TEntity, TContext> : IGenericDal<TEntity> 
        where TEntity : class, IBaseEntity, new()
        where TContext : DbContext
    {
        private readonly TContext context;

        public EfGenericRepository(TContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await context.FindAsync<TEntity>(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity,TKey>> keySelector)
        {
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
