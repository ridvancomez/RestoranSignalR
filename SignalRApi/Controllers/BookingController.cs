using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Booking;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.BookingFeature;
using SignalRApi.Features.CategoryFeature;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseCrudControllerController<Booking, CreateBookingDto, UpdateBookingDto>
    {
        public BookingController(IGenericService<Booking> genericService, IMapper mapper, ICategoryService bookingService, IHubContext<SignalRHub> hubContext, BookingCrudEventStrategy bookingCrudEventStrategy) : base(genericService, mapper, bookingCrudEventStrategy)
        {
        }
    }
}
