using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IGenericService<About> _aboutService;
        private readonly IMapper _mapper;   
        public AboutsController (IGenericService<About> aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _aboutService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _aboutService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
            _aboutService.TDelete(id);
            return Ok("Hakkımızda alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateAboutDto createAboutDto) 
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            var about =_aboutService.TAdd(newValue);
            return Ok("Yeni hakkımızda alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımızda alanı güncellendi");
        }


    }
}
