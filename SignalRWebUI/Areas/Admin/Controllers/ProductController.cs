using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDtos;
using SignalRWebUI.Dtos.ProductDtos;
using System.Net.Http;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]

    public class ProductController : AdminCrudBaseController<ResultProductDto, CreateProductDto, UpdateProductDto>
    {
        IHttpClientFactory _httpClientFactory;
        public ProductController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Product")
        {
            _httpClientFactory = httpClientFactory;
        }

        public override async Task<IActionResult> Index()
        {
            var response = await _httpClientFactory.CreateClient().GetAsync("https://localhost:7272/api/Product/GetProductsWithCategory");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public override IActionResult Create()
        {
            var client = _httpClientFactory.CreateClient();
            var response = client.GetAsync("https://localhost:7272/api/Category").Result;
            var jsonData = response.Content.ReadAsStringAsync().Result;
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            List<SelectListItem> selectListItems = (from x in values
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();

            ViewBag.CategoryList = selectListItems;
            return View();
        }

        [HttpGet]
        public override async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/Category");
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            List<SelectListItem> selectListItems = (from x in values
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.Id.ToString()
                                                    }).ToList();

            ViewBag.CategoryList = selectListItems;
            return await base.Update(id);
        }
    }
}
