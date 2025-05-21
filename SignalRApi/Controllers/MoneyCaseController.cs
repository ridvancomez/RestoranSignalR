using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.MoneyCase;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : BaseCrudControllerController<MoneyCase, CreateMoneyCaseDto, UpdateMoneyCaseDto>
    {
        private readonly IMoneyCaseService _moneyCaseService;
        public MoneyCaseController(IGenericService<MoneyCase> genericService, IMapper mapper, IMoneyCaseService moneyCaseService, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.MoneyCase)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount()
        {
            var result = _moneyCaseService.TTotalMoneyCaseAmount();
            return Ok(result);
        }
    }
}
