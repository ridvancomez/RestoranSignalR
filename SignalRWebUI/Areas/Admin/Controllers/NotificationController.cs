using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.NotifacitonDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class NotificationController : AdminCrudBaseController<ResultNotificationDto, CreateNotificationDto, UpdateNotificationDto>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _endPoint;
        public NotificationController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Notification")
        {
            _endPoint = "https://localhost:7272/api/Notification";
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{_endPoint}/ChangeStatusNotification/{id}");
            return RedirectToAction("Index");
        }
    }
}
