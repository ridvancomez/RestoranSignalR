using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.About;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : BaseCrudControllerController<About, CreateAboutDto, UpdateAboutDto>
    {
        private readonly IGenericService<About> _genericService;
        private readonly IMapper _mapper;
        public AboutController(IGenericService<About> genericService, IMapper mapper) : base(genericService, mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
    }
}
