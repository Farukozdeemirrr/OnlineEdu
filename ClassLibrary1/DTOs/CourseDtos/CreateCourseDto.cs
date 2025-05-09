using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.CourseDtos
{
    public class CreateCourseDto
    {
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; } // !!!CategoryId olarak değil CourseCategoryId tanımlanmalı
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
