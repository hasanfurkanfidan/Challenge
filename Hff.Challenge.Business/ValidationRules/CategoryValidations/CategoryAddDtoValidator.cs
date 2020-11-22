using FluentValidation;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.ValidationRules.CategoryValidations
{
   public class CategoryAddDtoValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Kategori adı alanı boş geçilemez");

        }
    }
}
