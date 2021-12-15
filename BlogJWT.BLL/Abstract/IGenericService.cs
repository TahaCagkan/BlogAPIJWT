using BlogJWT.Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Abstract
{
    public interface IGenericService<TEntity> where TEntity : class, IBaseEntity, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}