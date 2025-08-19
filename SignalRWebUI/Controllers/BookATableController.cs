using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.BookingDtos;
using Newtonsoft.Json;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class BookATableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookATableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Page = "sub_page";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            ViewBag.Page = "sub_page";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            var stringContent =  new StringContent(jsonData, Encoding.UTF8, "application/json"
                );
            var response = await client.PostAsync("https://localhost:7272/api/Booking", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<GetBookingDto>());
            }

            return View();
        }
    }
}
