using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.SocialMedia;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : BaseCrudControllerController<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(IGenericService<SocialMedia> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
