using AutoMapper;
using BlogJWT.DTO.DTOs.BlogDtos;
using BlogJWT.DTO.DTOs.CategoryDtos;
using BlogJWT.Entities.Concrete;
using BlogJWT.WebApi.Models;

namespace BlogJWT.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto >();

            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
