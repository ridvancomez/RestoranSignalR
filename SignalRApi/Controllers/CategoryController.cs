using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Category;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseCrudControllerController<Category, CreateCategoryDto, UpdateCategoryDto>
    {
        private readonly IGenericService<Category> _genericService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IGenericService<Category> genericService, IMapper mapper, ICategoryService categoryService) : base(genericService, mapper)
        {
            _categoryService = categoryService;
            _genericService = genericService;
            _mapper = mapper;
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var categoryCount = _categoryService.TCategoryCount();
            return Ok(categoryCount);
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            var activeCategoryCount = _categoryService.TActiveCategoryCount();
            return Ok(activeCategoryCount);
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            var passiveCategoryCount = _categoryService.TPassiveCategoryCount();
            return Ok(passiveCategoryCount);
        }

        
    }
}
