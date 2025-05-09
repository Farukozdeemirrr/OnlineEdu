using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private readonly IGenericService<CourseCategory> _courseCategoryService;
        private readonly IMapper _mapper;

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _courseCategoryService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseCategoryService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            //Id 0 İse, bu Id li değer bulunamadı hatası döndürme işlemi eklenecek(Backend tarafında)
            _courseCategoryService.TDelete(id);
            return Ok("Kurs kategori alanı silindi");
        }
        [HttpPost]
        public IActionResult Create(CreateCourseCatageoryDto createCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TAdd(newValue);
            return Ok("Yeni Kurs kategori alanı oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseCatageoryDto updateCourseCategoryDto)
        {
            var value = _mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(value);
            return Ok("Kurs kategori alanı güncellendi");
        }
    }
}
