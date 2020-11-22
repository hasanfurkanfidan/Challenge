using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hff.Challenge.Business.Abstract;
using Hff.Challenge.Dtos.Concrete.CategoryDtos;
using Microsoft.AspNetCore.Mvc;

namespace Hff.Challenge.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task< IActionResult> Index()
        {
            return View(_mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllAsync()));
        }
    }
}
