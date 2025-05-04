using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Testimonial;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : BaseCrudControllerController<Testimonial, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(IGenericService<Testimonial> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
