using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Product;
using SignalR.EntityLayer.Entites;
using SignalRApi.Constants;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseCrudControllerController<Product, CreateProductDto, UpdateProductDto>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IGenericService<Product> genericService, IMapper mapper, IProductService productService, IHubContext<SignalRHub> hubContext) : base(genericService, mapper, hubContext, SignalREventNames.Product)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet("GetProductsWithCategory")]
        public IActionResult GetProductsWithCategory()
        {
            var value = _mapper.Map<List<ResultProductWithCategory>>(_productService.TGetProductsWithCategory());

            return Ok(value);
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var value = _productService.TProductCount();
            return Ok(value);
        }
        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            var productCountByHamburger = _productService.TGetProductCountByHamburger();
            return Ok(productCountByHamburger);
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            var productCountByHamburger = _productService.TGetProductCountByDrink();
            return Ok(productCountByHamburger);
        }

        [HttpGet("AveragePriceProduct")]
        public IActionResult AveragePriceProduct()
        {
            var averagePriceProduct = _productService.TGetAveragePriceProduct();
            return Ok(averagePriceProduct);
        }

        [HttpGet("MaxPriceProductName")]
        public IActionResult MaxPriceProduct()
        {
            var maxPriceProduct = _productService.TGetMaxPriceProductName();
            return Ok(maxPriceProduct);
        }

        [HttpGet("MinPriceProductName")]
        public IActionResult MinPriceProduct()
        {
            var minPriceProduct = _productService.TGetMinPriceProductName();
            return Ok(minPriceProduct);
        }

        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            var productAvgPriceByHamburger = _productService.TProductAvgPriceByHamburger();
            return Ok(productAvgPriceByHamburger);
        }
    }
}
