using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.MoneyCase;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : BaseCrudControllerController<MoneyCase, CreateMoneyCaseDto, UpdateMoneyCaseDto>
    {
        private readonly IMoneyCaseService _moneyCaseService;
        public MoneyCaseController(IGenericService<MoneyCase> genericService, IMapper mapper, IMoneyCaseService moneyCaseService, DefaultCrudEventStrategy defaultCrudEventStrategy) : base(genericService, mapper, defaultCrudEventStrategy)
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
