using BlogJWT.DTO.DTOs.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.BLL.ValidationRules.FluentValidation
{
    public class CategoryAddValidator: AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}
