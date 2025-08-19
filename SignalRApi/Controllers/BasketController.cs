using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DTOLayer.Basket;
using SignalR.EntityLayer.Entites;
using SignalRApi.Features.Shared;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : BaseCrudControllerController<Basket, CreateBasketDto, UpdateBasketDto>
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;
        private readonly DefaultCrudEventStrategy _crudEventStrategy;
        private readonly Context _context;
        public BasketController(IGenericService<Basket> genericService, IMapper mapper, DefaultCrudEventStrategy defaultCrudEventStrategy, IBasketService basketService, Context context) : base(genericService, mapper, defaultCrudEventStrategy)
        {
            _crudEventStrategy = defaultCrudEventStrategy;
            _basketService = basketService;
            _mapper = mapper;
            _context = context;
        }
        [HttpGet("GetBasketByUsId/{menuTableId}")]
        public IActionResult GetListByMenuTableId(int menuTableId)
        {
            var baskets = _mapper.Map<List<ResultBasketDto>>(_basketService.GetListByMenuTableId(menuTableId));

            if (baskets.Any())
            {
                return Ok(baskets);
            }
            return NotFound("No baskets found for the specified user.");
        }

        [HttpPost]
        public override IActionResult Create([FromBody] CreateBasketDto createDto)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<Basket>(createDto);
                entity.ProductId = createDto.ProductId;
                entity.Quantity = 1;
                entity.MenuTableId = 3;
                entity.Price = _context.Products.Where(x => x.Id == createDto.ProductId)
                    .Select(x => x.Price)
                    .FirstOrDefault();
                _basketService.TAdd(entity);
                return Ok("Basket successfully added.");
            }
            return BadRequest("An error occurred while adding the basket.");
        }
    }
}