using FluentValidation;
using Hff.Challenge.Dtos.Concrete.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.ValidationRules.ProductValidations
{
   public class ProductAddDtoValidator:AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori alanı boş geçilemez");
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(p => p.Trademark).NotEmpty().WithMessage("Marka alanı boş geçilemez");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
        }
    }
}
