using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.OrderFeature
{
    public class OrderCrudEventStrategy : ICrudEventStrategy
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly IOrderService _orderService;
        public OrderCrudEventStrategy(IHubContext<SignalRHub> hubContext, IOrderService orderService)
        {
            _hubContext = hubContext;
            _orderService = orderService;
        }
        public async void OnChanged()
        {
            var orderCount = _orderService.TTotalOrderCount();
            var activeOrderCount = _orderService.TActiveOrderCount();
            var lastOrderAmount = _orderService.TLastOrderPrice();

            await _hubContext.Clients.All.SendAsync("ReceiveOrderCount", orderCount);
            await _hubContext.Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);
            await _hubContext.Clients.All.SendAsync("ReceiveLastOrderAmount", lastOrderAmount);
        }
    }
}
