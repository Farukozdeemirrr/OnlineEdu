using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogDtos
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogCategoryId { get; set; }
       /* public ResultBlogCategoryDto BlogCategory { get; set; }*/// Entity tarafından BlogCategory geldi bunu ResultBlogDto ile değiştireceğiz// Entity ile ilişiği kesmek için ResultBlogCategoryDto tipinde tanım yaptık
    }
}
