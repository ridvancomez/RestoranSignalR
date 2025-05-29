using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Testimonial;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : BaseCrudControllerController<Testimonial, CreateTestimonialDto, UpdateTestimonialDto>
    {
        
        public TestimonialController(IGenericService<Testimonial> genericService, IMapper mapper, DefaultCrudEventStrategy defaultCrudEventStrategy) : base(genericService, mapper, defaultCrudEventStrategy)
        {
            
        }
    }
}
