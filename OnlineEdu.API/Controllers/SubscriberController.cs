using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.DTO.DTOs.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
            private readonly IMapper _mapper;
            private readonly IGenericService<Subscriber> _subscriberService;

            public SubscriberController(IMapper mapper, IGenericService<Subscriber> subscriberService)
            {
                _mapper = mapper;
                _subscriberService = subscriberService;
            }

            [HttpGet]
            public IActionResult GetAllList()
            {
                var values = _subscriberService.TGetAllList();
                return Ok(values);
            }
            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var value = _subscriberService.TGetBydId(id);
                return Ok(value);
            }
            [HttpDelete("{id}")]
            public IActionResult DeleteById(int id)
            {
                //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
                _subscriberService.TDelete(id);
                return Ok("Abone alanı silindi");
            }
            [HttpPost]
            public IActionResult Create(CreateSocialMediaDto createSubscriberDto)
            {
                var newValue = _mapper.Map<Subscriber>(createSubscriberDto);
                _subscriberService.TAdd(newValue);
                return Ok("Abone alanı oluşturuldu");
            }

            [HttpPut]
            public IActionResult Update(UpdateSocialMediaDto updateSubscriberDto)
            {
                var value = _mapper.Map<Subscriber>(updateSubscriberDto);
                _subscriberService.TUpdate(value);
                return Ok("Sosyal Medya güncellendi");
            }
        }
    }

