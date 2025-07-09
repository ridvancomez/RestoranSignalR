using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Slider;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.Shared;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : BaseCrudControllerController<Slider, CreateSliderDto, UpdateSliderDto>
    {
        public SliderController(IGenericService<Slider> genericService, IMapper mapper, DefaultCrudEventStrategy crudEventStrategy) : base(genericService, mapper, crudEventStrategy)
        {
        }
    }
}
