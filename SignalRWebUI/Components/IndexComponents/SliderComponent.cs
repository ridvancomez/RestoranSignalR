using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SignalR.DTOLayer.Slider;

namespace SignalRWebUI.Components.IndexComponents
{
    public class SliderComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SliderComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.GetAsync("https://localhost:7272/api/Slider");
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
            return View(values);
        }
    }
}
