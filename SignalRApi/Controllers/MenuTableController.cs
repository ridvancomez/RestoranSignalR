using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.MenuTable;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : BaseCrudControllerController<MenuTable, CreateMenuTableDto, UpdateMenuTableDto>
    {
        private readonly IMenuTableService _menuTableService;
        public MenuTableController(IGenericService<MenuTable> genericService, IMapper mapper, IMenuTableService menuTableService, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.MenuTable)
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
