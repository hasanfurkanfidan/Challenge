using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hff.Challenge.Business.Abstract;
using Hff.Challenge.Dtos.Concrete.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace Hff.Challenge.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public HomeController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(_mapper.Map<List<ProductListDto>>(await _productService.GetAllWithCategories()));
        }
    }
}
