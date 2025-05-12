using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocailMediaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<SocialMedia> _socialMediaService;
        public SocailMediaController(IMapper mapper, IGenericService<SocialMedia> socialMediaService)
        {
            _mapper = mapper;
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _socialMediaService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _socialMediaService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
            _socialMediaService.TDelete(id);
            return Ok("Sosyal Medya alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateSocialMediaDto createSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>(createSocialMediaDto);
            _socialMediaService.TAdd(newValue);
            return Ok("Sosyal Medya alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>(updateSocialMediaDto);
            _socialMediaService.TUpdate(value);
            return Ok("Sosyal Medya güncellendi");
        }
    }
}
