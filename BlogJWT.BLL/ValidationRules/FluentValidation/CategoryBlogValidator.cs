using BlogJWT.DTO.DTOs.CategoryBlogDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.BLL.ValidationRules.FluentValidation
{
    public class CategoryBlogValidator: AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(x => x.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("CategoryId boş geçilemez");
            RuleFor(x => x.BlogId).InclusiveBetween(0, int.MaxValue).WithMessage("BlogId boş geçilemez");
        }
    }
}
