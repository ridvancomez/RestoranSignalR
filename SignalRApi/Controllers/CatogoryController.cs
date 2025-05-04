using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.Category;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatogoryController : BaseCrudControllerController<Category, CreateCategoryDto, UpdateCategoryDto>
    {
        private readonly IGenericService<Category> _genericService;
        private readonly IMapper _mapper;
        public CatogoryController(IGenericService<Category> genericService, IMapper mapper) : base(genericService, mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
    }
}
