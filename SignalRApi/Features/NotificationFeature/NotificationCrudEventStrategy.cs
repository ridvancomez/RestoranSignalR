using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.NotificationFeature
{
    public class NotificationCrudEventStrategy : ICrudEventStrategy
    {
        IHubContext<SignalRHub> _hubContext;
        INotificationService _notificationService;

        public NotificationCrudEventStrategy(INotificationService notificationService, IHubContext<SignalRHub> hubContext)
        {
            _notificationService = notificationService;
            _hubContext = hubContext;
        }

        public async void OnChanged()
        {
            var value = _notificationService.NotificationCountByStatusFalse();
            await _hubContext.Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);

            var notifications = _notificationService.GetListByStatusFalse();
            await _hubContext.Clients.All.SendAsync("ReceiveNotificationList", notifications);
        }
    }
}
