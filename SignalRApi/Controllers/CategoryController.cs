using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Category;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseCrudControllerController<Category, CreateCategoryDto, UpdateCategoryDto>
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(IGenericService<Category> genericService, IMapper mapper, ICategoryService categoryService, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.Category)
        {
            _categoryService = categoryService;
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
