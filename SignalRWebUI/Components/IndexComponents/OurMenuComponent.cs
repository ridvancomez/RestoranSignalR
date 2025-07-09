using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DTOLayer.Category;
using SignalR.DTOLayer.Product;

namespace SignalRWebUI.Components.IndexComponents
{
    public class OurMenuComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OurMenuComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Fetching categories from the API
            var client = _httpClientFactory.CreateClient();
            var categoryResponse = await client.GetAsync("https://localhost:7272/api/Category");
            var jsonData = await categoryResponse.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

            ViewBag.Categories = values;

            //Fetching proudct from the API
            var productResponse = await client.GetAsync("https://localhost:7272/api/Product/GetProductWithFeatured");
            var productJsonData = await productResponse.Content.ReadAsStringAsync();
            var productValues = JsonConvert.DeserializeObject<List<ResultProductDto>>(productJsonData);

            return View(productValues);
        }
    }
}
