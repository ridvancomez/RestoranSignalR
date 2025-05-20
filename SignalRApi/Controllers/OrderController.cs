using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Order;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseCrudControllerController<Order, CreateOrderDto, UpdateOrderDto>
    {
        private readonly IOrderService _orderService;
        public OrderController(IGenericService<Order> genericService, IMapper mapper, IOrderService orderService) : base(genericService, mapper)
        {
            _orderService = orderService;
        }

        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {
            var totalCount = _orderService.TTotalOrderCount();
            return Ok(totalCount);
        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            var activeCount = _orderService.TActiveOrderCount();
            return Ok(activeCount);
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            var lastPrice = _orderService.TLastOrderPrice();
            return Ok(lastPrice);
        }
        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            var todayTotalPrice = _orderService.TTodayTotalPrice();
            return Ok(todayTotalPrice);
        }
    }
}
