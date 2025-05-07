using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Product;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseCrudControllerController<Product, CreateProductDto, UpdateProductDto>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IGenericService<Product> genericService, IMapper mapper, IProductService productService) : base(genericService, mapper)
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
    }
}
