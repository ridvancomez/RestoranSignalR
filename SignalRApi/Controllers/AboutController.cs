using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.About;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : BaseCrudControllerController<About, CreateAboutDto, UpdateAboutDto>
    {
        private readonly IGenericService<About> _genericService;
        private readonly IMapper _mapper;
        public AboutController(IGenericService<About> genericService, IMapper mapper, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.About)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
    }
}
