using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hff.Challenge.Business.Abstract;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using Hff.Challenge.Dtos.Concrete.ProductDtos;
using Hff.Challenge.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hff.Challenge.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        public HomeController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(mapper.Map<List<ProductListDto>>(await productService.GetAllWithCategories()));

        }
        public IActionResult AddProduct()
        {
            return View(new ProductAddDto());

        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddDto productAddDto)
        {
            if (ModelState.IsValid)
            {
                await productService.AddAsync(mapper.Map<Product>(productAddDto));
            }
            return View(productAddDto);

        }
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await productService.GetById(id);
            var dto = mapper.Map<ProductUpdateDto>(product);
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productUpdateDto)
        {

            if (ModelState.IsValid)
            {
                var product = await productService.GetById(productUpdateDto.Id);
                product.Price = productUpdateDto.Price;
                product.Name = productUpdateDto.Name;
                product.CategoryId = productUpdateDto.CategoryId;
                product.Stock = productUpdateDto.Stock;
                product.Trademark = productUpdateDto.Trademark;
                await productService.UpdateAsync(product);
                return RedirectToAction("Index");
            }

            return View(productUpdateDto);
        }
    }
}
