using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DTOLayer.Discount;

namespace SignalRWebUI.Components.IndexComponents
{
    public class DiscountComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DiscountComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/Discount");
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);

            return View(values);
        }
    }
}
