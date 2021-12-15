using BlogJWT.DAL.Concrete.EntityFrameworkCore.Context;
using BlogJWT.DTO.DTOs.CategoryBlogDtos;
using BlogJWT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogJWT.BLL.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<List<Blog>> GetAllSortedByPostedTimeAsync();
        Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId);

    }
}
