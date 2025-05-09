using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Course
    {
        //Entitylerde değişiklik yapıldıktan sonra migration işlemi yapılmalıdır. + Update-database
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; } // !!! CategoryId değil, CourseCategoryId olarak tanımlanmalı dikkat et
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
        public CourseCategory CourseCategory { get; set; }//Category içinde Course ile, burada ise Category ile eşleştirdik ve ilişkili olmuş oldular.
    }
}
