using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DTOLayer.About;
namespace SignalRWebUI.Components.IndexComponents
{
    public class AboutComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/About");
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);
        }
    }
}
