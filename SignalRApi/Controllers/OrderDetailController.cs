using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.OrderDetail;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : BaseCrudControllerController<OrderDetail, CreateOrderDetailDto, UpdateOrderDetailDto>
    {
        public OrderDetailController(IGenericService<OrderDetail> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
