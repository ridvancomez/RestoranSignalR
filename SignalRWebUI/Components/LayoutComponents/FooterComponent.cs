using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DTOLayer.ContactUs;
namespace SignalRWebUI.Components.LayoutComponents
{
    public class FooterComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FooterComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/ContactUs");
            var content = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultContactUsDto>>(content);
            return View(values);
        }
    }
}
