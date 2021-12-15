using BlogJWT.DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogJWT.BLL.ValidationRules.FluentValidation
{
    public class AppUserLoginValidator:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");

        }
    }
}
