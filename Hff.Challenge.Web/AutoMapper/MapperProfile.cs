using AutoMapper;
using Hff.Challenge.Dtos.Concrete.AppUserDtos;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using Hff.Challenge.Dtos.Concrete.ProductDtos;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hff.Challenge.Web.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserListDto, AppUser>();

            CreateMap<Category, CategoryAddDto>();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<Product, ProductAddDto>();
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<ProductListDto, Product>();
            CreateMap<Product, ProductListDto>();





        }
    }
}
