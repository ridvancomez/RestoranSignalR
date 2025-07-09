using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.MenuTableFeature
{
    public class MenuTableCrudEventStrategy : ICrudEventStrategy
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly IMenuTableService _menuTableService;

        public MenuTableCrudEventStrategy(IHubContext<SignalRHub> hubContext ,IMenuTableService menuTableService)
        {
            _hubContext = hubContext;
            _menuTableService = menuTableService;
        }

        public async void OnChanged()
        {
            var menuTableCount = _menuTableService.TMenuTableCount();
            await _hubContext.Clients.All.SendAsync("ReceiveMenuTableCount", menuTableCount);
        }
    }
}
