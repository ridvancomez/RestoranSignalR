using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.SocialMediaDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class SocialMediaController : AdminCrudBaseController<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>
    {
        public SocialMediaController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/SocialMedia")
        {
        }
    }
}
