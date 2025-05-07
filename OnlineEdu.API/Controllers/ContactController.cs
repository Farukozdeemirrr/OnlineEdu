using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public class BlogsController : ControllerBase
        {
            private readonly IGenericService<Contact> _contactService;
            private readonly IMapper _mapper;
            public BlogsController(IGenericService<Contact> contactService, IMapper mapper)
            {
                _contactService = contactService;
                _mapper = mapper;
            }
            [HttpGet]
            public IActionResult GetAllList()
            {
                var values = _contactService.TGetAllList();
                return Ok(values);
            }
            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var value = _contactService.TGetBydId(id);
                return Ok(value);
            }
            [HttpDelete("{id}")]
            public IActionResult DeleteById(int id)
            {
                //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
                _contactService.TDelete(id);
                return Ok("Contact alanı silindi");
            }
            [HttpPost]
            public IActionResult Create(CreateContactDto createContactDto)
            {
                var newValue = _mapper.Map<Contact>(createContactDto);
                _contactService.TAdd(newValue);
                return Ok("Yeni Contact alanı oluşturuldu");
            }

            [HttpPut]
            public IActionResult Update(UpdateContactDto updateContactDto)
            {
                var value = _mapper.Map<Contact>(updateContactDto);
                _contactService.TUpdate(value);
                return Ok("Contact alanı güncellendi");
            }
        }
}
