using FluentValidation;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.ValidationRules.CategoryValidations
{
   public class CategoryUpdateDtoValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Kategori Adı alanı boş geçilemez");
            RuleFor(p => p.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Kategori Id alanı boş geçilemez");
        }
    }
}
