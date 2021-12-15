using BlogJWT.BLL.Abstract;
using BlogJWT.BLL.Concrete;
using BlogJWT.BLL.Tools.JWTTool;
using BlogJWT.BLL.ValidationRules.FluentValidation;
using BlogJWT.Core.DAL;
using BlogJWT.DAL.Abstract;
using BlogJWT.DAL.Concrete.EntityFrameworkCore.Repository;
using BlogJWT.DTO.DTOs.AppUserDtos;
using BlogJWT.DTO.DTOs.CategoryBlogDtos;
using BlogJWT.DTO.DTOs.CategoryDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogJWT.BLL.Containers.IoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<,>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
        }
    }
}
