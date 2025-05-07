using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController : ControllerBase
    {
        private readonly IGenericService<BlogCategory> _blogCategoriesService;
        private readonly IMapper _mapper;
        public BlogCategoriesController(IGenericService<BlogCategory> blogCategoriesService, IMapper mapper)
        {
            _blogCategoriesService = blogCategoriesService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _blogCategoriesService.TGetAllList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        { 
            var value = _blogCategoriesService.TGetBydId(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _blogCategoriesService.TDelete(id);
            return Ok("Blog kategorisi silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto) //Create ve Update için Mapleme işlemi unutulmamalı.
        {
            var newValue = _mapper.Map<BlogCategory>(createBlogCategoryDto);
            _blogCategoriesService.TAdd(newValue);
            return Ok("Blog kategori oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto) 
        {
            var value = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
             _blogCategoriesService.TUpdate(value);
            return Ok("Blog kategorisi güncellendi");
        }




    }
}
