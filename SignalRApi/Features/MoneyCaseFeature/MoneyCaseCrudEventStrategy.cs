using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.MoneyCaseFeature
{
    public class MoneyCaseCrudEventStrategy : ICrudEventStrategy
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCaseCrudEventStrategy(IHubContext<SignalRHub> hubContext, IMoneyCaseService moneyCaseService)
        {
            _hubContext = hubContext;
            _moneyCaseService = moneyCaseService;
        }

        public async void OnChanged()
        {
            var moneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await _hubContext.Clients.All.SendAsync("ReceiveMoneyCaseAmount", moneyCaseAmount);
        }
    }
}
