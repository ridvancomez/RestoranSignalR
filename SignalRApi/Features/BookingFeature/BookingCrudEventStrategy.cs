using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Features.BookingFeature
{
    public class BookingCrudEventStrategy : ICrudEventStrategy
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly IBookingService _bookingService;
        public BookingCrudEventStrategy(IHubContext<SignalRHub> hubContext, IBookingService bookingService)
        {
            _hubContext = hubContext;
            _bookingService = bookingService;
        }
        public async void OnChanged()
        {
            var bookingList = _bookingService.TGetList();
            await _hubContext.Clients.All.SendAsync("ReceiveBookingList", bookingList);

        }
    }
}
