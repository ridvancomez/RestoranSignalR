using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.TestimonialDtos;

namespace SignalRWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[Action]")]
    [Route("Admin/[controller]/[Action]/{id?}")]
    public class TestimonialController : AdminCrudBaseController<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(IHttpClientFactory httpClientFactory) : base(httpClientFactory, "https://localhost:7272/api/Testimonial")
        {
        }
    }
}
