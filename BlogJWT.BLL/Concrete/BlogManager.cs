using BlogJWT.BLL.Abstract;
using BlogJWT.Core.DAL;
using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.DTO.DTOs.CategoryBlogDtos;
using BlogJWT.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Concrete
{
    public class BlogManager:GenericManager<Blog>,IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        private readonly IGenericDal<CategoryBlog> _categoryBlogService;
        private readonly IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog> genericDal, IGenericDal<CategoryBlog> categoryBlogService, IBlogDal blogDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _categoryBlogService = categoryBlogService;
            _blogDal = blogDal;
        }

        public Task AddToCategory(int blogId, int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(x => x.PostedTime);
        }
        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var addedControl = await _categoryBlogService.GetAsync(x => x.CategoryId == categoryBlogDto.CategoryId && x.BlogId == categoryBlogDto.BlogId);

            if( addedControl == null)
            {
                await _categoryBlogService.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.BlogId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }       
        }

        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
           var deletedCategoryBlog = await _categoryBlogService.GetAsync(x => x.CategoryId == categoryBlogDto.CategoryId && x.BlogId == categoryBlogDto.BlogId);

            if(deletedCategoryBlog !=null)
            {
                await _categoryBlogService.RemoveAsync(deletedCategoryBlog);
            }
        }

        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _blogDal.GetAllByCategoryIdAsync(categoryId);
        }
    }
}
