using FluentValidation;
using Hff.Challenge.Business.Abstract;
using Hff.Challenge.Business.Concrete;
using Hff.Challenge.Business.ValidationRules.AppUserValidations;
using Hff.Challenge.Business.ValidationRules.CategoryValidations;
using Hff.Challenge.Business.ValidationRules.ProductValidations;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.DataAccess.Concrete.Repositories;
using Hff.Challenge.Dtos.Concrete.AppUserDtos;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using Hff.Challenge.Dtos.Concrete.ProductDtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            //DataAccess
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IProductDal, EfProductRepository>();
            //Busines
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IAppUserService, AppUserManager>();

            //Generics
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            //Validations
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateDtoValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddDtoValidator>();
            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
        }
    }
}
