using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.MoneyCase;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCaseController : BaseCrudControllerController<MoneyCase, CreateMoneyCaseDto, UpdateMoneyCaseDto>
    {
        private readonly IMoneyCaseService _moneyCaseService;
        public MoneyCaseController(IGenericService<MoneyCase> genericService, IMapper mapper, IMoneyCaseService moneyCaseService) : base(genericService, mapper)
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
