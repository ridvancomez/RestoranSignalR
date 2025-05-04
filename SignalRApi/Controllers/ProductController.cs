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
        public ProductController(IGenericService<Product> genericService, IMapper mapper) : base(genericService, mapper)
        {
        }
    }
}
