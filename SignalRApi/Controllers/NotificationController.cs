using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Notification;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.NotificationFeature;
using SignalRApi.Features.Shared;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : BaseCrudControllerController<Notification, CreateNotificationDto, UpdateNotificationDto>
    {
        private readonly INotificationService _notificationService;
        private readonly NotificationCrudEventStrategy _crudEventStrategy;
        public NotificationController(INotificationService notificationService, IGenericService<Notification> genericService, IMapper mapper, NotificationCrudEventStrategy crudEventStrategy) : base(genericService, mapper, crudEventStrategy)
        {
            _notificationService = notificationService;
            _crudEventStrategy = crudEventStrategy;
        }

        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            var count = _notificationService.NotificationCountByStatusFalse();
            return Ok(count);
        }
        [HttpGet("GetListByStatusFalse")]
        public IActionResult GetListByStatusFalse()
        {
            var notifications = _notificationService.GetListByStatusFalse();
            return Ok(notifications);
        }
        [HttpGet("ChangeStatusNotification/{id}")]
        public IActionResult ChangeStatusNotification(int id)
        {
            _notificationService.ChangeStatusNotification(id);
            _crudEventStrategy.OnChanged();
            return Ok("Bildirim durumu değiştirildi.");
        }
    }
}
