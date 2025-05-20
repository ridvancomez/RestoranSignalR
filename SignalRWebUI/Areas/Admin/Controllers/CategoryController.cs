using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDtos;
namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class CategoryController : AdminCrudBaseController<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Category")
        {
        }
    }
}
