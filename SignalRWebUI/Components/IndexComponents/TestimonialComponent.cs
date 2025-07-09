using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.DTOLayer.Testimonial;
namespace SignalRWebUI.Components.IndexComponents
{
    public class TestimonialComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/Testimonial");
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);
        }
    }
}
