using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
        public ResultCourseCatageoryDto CourseCategory { get; set; }//Category içinde Course ile, burada ise Category ile eşleştirdik ve ilişkili olmuş oldular.
    }
}
