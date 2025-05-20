using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.DiscountDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Route("Admin/[controller]/[action]")]
    public class DiscountController : AdminCrudBaseController<ResultDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Discount")
        {
        }
    }
}
