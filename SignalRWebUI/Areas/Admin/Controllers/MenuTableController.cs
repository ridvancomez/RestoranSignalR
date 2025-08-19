using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.MenuTableDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class MenuTableController : AdminCrudBaseController<ResultMenuTableDto, CreateMenuTableDto, UpdateMenuTableDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _endPoint;
        public MenuTableController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/MenuTable")
        {
            _httpClientFactory = httpClientFactory;
            _endPoint = "https://localhost:7272/api/MenuTable";
        }

        [HttpGet]
        public async Task<IActionResult> TableGetByStatus()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_endPoint);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMenuTableDto>>(jsonData);
                return View(values);
            }
            else
            {
                return View(new List<ResultMenuTableDto>());
            }
        }
    }
}
