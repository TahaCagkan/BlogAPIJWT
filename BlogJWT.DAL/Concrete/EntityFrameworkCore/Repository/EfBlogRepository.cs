using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository
{
    public class EfBlogRepository : EfGenericRepository<Blog, BlogJWTContext>, IBlogDal
    {
        private readonly BlogJWTContext context;
        public EfBlogRepository(BlogJWTContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {

            return await  context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId, (blog,categoryBlog)=>new
            { 
                blog = blog,
                categoryBlog = categoryBlog
            }).Where(x => x.categoryBlog.CategoryId == categoryId).Select(x => new Blog { 
                AppUser = x.blog.AppUser,
                AppUserId = x.blog.AppUserId,
                CategoryBlogs=x.blog.CategoryBlogs,
                Comments = x.blog.Comments,
                Description = x.blog.Description,
                Id = x.blog.Id,
                ImagePath = x.blog.ImagePath,
                PostedTime=x.blog.PostedTime,
                ShortDescription = x.blog.ShortDescription,
                Title = x.blog.Title
            }).ToListAsync();

        }
    }
}
