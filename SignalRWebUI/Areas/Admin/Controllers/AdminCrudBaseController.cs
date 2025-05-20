using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCrudBaseController<TResultEntityDto, TCreateEntityDto, TUpdateEntityDto> : Controller where TResultEntityDto : class where TCreateEntityDto : class where TUpdateEntityDto : class

    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _baseEndPoint;


        public AdminCrudBaseController(IHttpClientFactory httpClientFactory, string baseEndPoint)
        {
            _httpClientFactory = httpClientFactory;
            _baseEndPoint = baseEndPoint;
        }

        public virtual async Task<IActionResult> Index()
        {
            var response = await _httpClientFactory.CreateClient().GetAsync(_baseEndPoint);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TResultEntityDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public virtual IActionResult Create()
        {
            return View();     
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create (TCreateEntityDto createEntityDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createEntityDto);
            StringContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_baseEndPoint, content);
           
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpGet]
        public virtual async Task<IActionResult> Update(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_baseEndPoint + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<TUpdateEntityDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public virtual async Task<IActionResult> Update(TUpdateEntityDto updateEntityDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateEntityDto);
            StringContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PutAsync(_baseEndPoint, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpGet]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync(_baseEndPoint + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
