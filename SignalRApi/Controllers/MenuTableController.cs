using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.MenuTable;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.MenuTableFeature;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : BaseCrudControllerController<MenuTable, CreateMenuTableDto, UpdateMenuTableDto>
    {
        private readonly IMenuTableService _menuTableService;
        public MenuTableController(IGenericService<MenuTable> genericService, IMenuTableService menuTableService, IMapper mapper, MenuTableCrudEventStrategy menuTableCrudEventStrategy) : base(genericService, mapper, menuTableCrudEventStrategy)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet("Count")]
        public IActionResult GetMenuTableCount()
        {
            var count = _menuTableService.TMenuTableCount();
            return Ok(count);
        }
    }
}
