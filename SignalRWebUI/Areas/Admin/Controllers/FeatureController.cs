using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.FeatureDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class FeatureController : AdminCrudBaseController<ResultFeatureDto, CreateFeatureDto, UpdateFeatureDto>
    {
        public FeatureController (IHttpClientFactory httpClientFactory) :base(httpClientFactory, "https://localhost:7272/api/Feature")
        {

        }
    }
}
