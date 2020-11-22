using FluentValidation;
using Hff.Challenge.Dtos.Concrete.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.ValidationRules.AppUserValidations
{
   public class AppUserLoginValidator:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Parola alanaı boş geçilemez");

        }
    }
}
