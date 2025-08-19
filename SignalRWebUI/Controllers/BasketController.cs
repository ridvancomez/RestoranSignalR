using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.BasketDtos;
using Newtonsoft.Json;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.EntityLayer.Entites;

namespace SignalRWebUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BasketController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Page = "sub_page";

            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7272/api/Basket/GetBasketByUsId/3");
            if (!response.IsSuccessStatusCode)
            {
                return View(new List<ResultBasketDto>());
            }
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);

            return View(values);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7272/api/Basket/{id}");
            if (!response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}