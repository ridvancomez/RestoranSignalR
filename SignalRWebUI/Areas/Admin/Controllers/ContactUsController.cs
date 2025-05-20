using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.ContactUsDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ContactUsController : AdminCrudBaseController<ResultContactUsDto, CreateContactUsDto, UpdateContactUsDto>
    {
        public ContactUsController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/ContactUs")
        {
        }
    }
}
