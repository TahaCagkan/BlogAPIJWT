using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository
{
    public class EfCategoryRepository : EfGenericRepository<Category, BlogJWTContext>, ICategoryDal
    {
        private readonly BlogJWTContext context;
        public EfCategoryRepository(BlogJWTContext context) : base(context)
        {
            this.context = context;
        }

        public Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return context.Category.OrderByDescending(x => x.Id).Include(x => x.CategoryBlogs).ToListAsync();
        }
    }
}