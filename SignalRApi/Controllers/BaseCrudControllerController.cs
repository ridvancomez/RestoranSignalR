using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalRApi.Features.Shared;
using SignalRApi.Hubs;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCrudControllerController<T, TCreateDto, TUpdateDto> : ControllerBase where T : class where TCreateDto : class where TUpdateDto : class 
    {
        private readonly IGenericService<T> _genericService;
        private readonly IMapper _mapper;
        private readonly ICrudEventStrategy _crudEventStrategy;

        public BaseCrudControllerController(IGenericService<T> genericService, IMapper mapper, ICrudEventStrategy crudEventStrategy)
        {
            _genericService = genericService;
            _mapper = mapper;
            _crudEventStrategy = crudEventStrategy;
        }
        [HttpGet]
        public virtual IActionResult GetAll()
        {
            var entities = _genericService.TGetList();
            return Ok(entities);
        }

        [HttpPost]
        public virtual IActionResult Create([FromBody] TCreateDto createDto)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<T>(createDto);
                _genericService.TAdd(entity);

                _crudEventStrategy.OnChanged();

                return Ok("Entity Başarılı Bir Şekilde Eklendi");
            }
            return BadRequest("Entity Eklenirken Bir Hata Oluştu");
        }
        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            var entity = _genericService.TGetById(id);
            if (entity != null)
            {
                _genericService.TDelete(entity);

                _crudEventStrategy.OnChanged();

                return Ok("Entity Başarılı Bir Şekilde Silindi");
            }
            return NotFound("Entity Bulunamadı");
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] TUpdateDto updateDto)
        {
            if (ModelState.IsValid)
            {
                var entity = _mapper.Map<T>(updateDto);
                _genericService.TUpdate(entity);
                _crudEventStrategy.OnChanged();

                
                return Ok("Entity Başarılı Bir Şekilde Güncellendi");
            }
            return BadRequest("Entity Güncellenirken Bir Hata Oluştu");
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetEntity(int id)
        {
            var entity = _genericService.TGetById(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            return NotFound("Entity Bulunamadı");
        }
    }
}
