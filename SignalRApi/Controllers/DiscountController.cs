using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Discount;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : BaseCrudControllerController<Discount, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IGenericService<Discount> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
