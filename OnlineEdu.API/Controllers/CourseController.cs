using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IGenericService<Course> _courseService;
        private readonly IMapper _mapper;

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _courseService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
            _courseService.TDelete(id);
            return Ok("Kurs alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TAdd(newValue);
            return Ok("Yeni Kurs alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(value);
            return Ok("Kurs alanı güncellendi");
        }
    }
}
