using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Feature;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : BaseCrudControllerController<Feature, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IGenericService<Feature> genericService, IMapper mapper, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.Feature)
        {
        }
    }
}
