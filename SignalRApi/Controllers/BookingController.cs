using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Booking;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseCrudControllerController<Booking, CreateBookingDto, UpdateBookingDto>
    {
        private readonly IGenericService<Booking> _genericService;
        private readonly IMapper _mapper;
        public BookingController(IGenericService<Booking> genericService, IMapper mapper, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.Booking)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
    }
}
