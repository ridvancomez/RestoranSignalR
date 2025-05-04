using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Booking;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseCrudControllerController<Booking, CreateBookingDto, UpdateBookingDto>
    {
        private readonly IGenericService<Booking> _genericService;
        private readonly IMapper _mapper;
        public BookingController(IGenericService<Booking> genericService, IMapper mapper) : base(genericService, mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
    }
}
