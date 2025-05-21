using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.OrderDetail;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : BaseCrudControllerController<OrderDetail, CreateOrderDetailDto, UpdateOrderDetailDto>
    {
        public OrderDetailController(IGenericService<OrderDetail> genericService, IMapper mapper, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.OrderDetail)
        {
        }
    }
}
