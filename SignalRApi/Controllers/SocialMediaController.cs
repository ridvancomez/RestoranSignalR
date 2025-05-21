using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.SocialMedia;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : BaseCrudControllerController<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(IGenericService<SocialMedia> genericService, IMapper mapper, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.SocialMedia)
        {
        }
    }
}
