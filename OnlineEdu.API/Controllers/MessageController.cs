using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Replication.PgOutput.Messages;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
       private readonly IMapper _mapper;
       private readonly IGenericService<Message> _messageService;
        public MessageController(IMapper mapper, IGenericService<Message> messageService)
        {
            _mapper = mapper;
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _messageService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _messageService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
            _messageService.TDelete(id);
            return Ok("Mesaj alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateMessageDto createMessageDto)
        {
            var newValue = _mapper.Map<Message>(createMessageDto);
            _messageService.TAdd(newValue);
            return Ok("Yeni Mesaj alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(value);
            return Ok("Mesaj alanı güncellendi");
        }

    }

}
