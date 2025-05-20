using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.BookingDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class BookingController : AdminCrudBaseController<ResultBookingDto, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Booking")
        {
        }

    }
}
