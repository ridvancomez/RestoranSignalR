using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.AboutDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AboutController : AdminCrudBaseController<ResultAboutDto, CreateAboutDto, UpdateAboutDto>
    {
        public AboutController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/About")
        {
        }
    }
}
