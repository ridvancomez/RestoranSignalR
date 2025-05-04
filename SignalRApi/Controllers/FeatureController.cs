using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Feature;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : BaseCrudControllerController<Feature, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController(IGenericService<Feature> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
