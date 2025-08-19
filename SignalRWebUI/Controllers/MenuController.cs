using Microsoft.AspNetCore.Mvc;
using SignalR.DTOLayer.Product;
using Newtonsoft.Json;
using SignalR.DTOLayer.Category;
using SignalR.DTOLayer.Basket;

namespace SignalRWebUI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Page = "sub_page";
            var client = _httpClientFactory.CreateClient();
            var categoryResponse = await client.GetAsync("https://localhost:7272/api/Category");
            var categoryJsonData = await categoryResponse.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoryJsonData);

            ViewBag.Categories = categories;


            var productResponse = await client.GetAsync("https://localhost:7272/api/Product");
            var productJsonData = await productResponse.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(productJsonData);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket(int id)
        {
            var createBasketDto = new CreateBasketDto
            {
                ProductId = id
            };
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBasketDto);
            StringContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7272/api/Basket", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
                return Json(createBasketDto);
        }
    }
}
