using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ContactUs;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : BaseCrudControllerController<ContactUs, CreateContactUsDto, UpdateContactUsDto>
    {
        public ContactUsController(IGenericService<ContactUs> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
