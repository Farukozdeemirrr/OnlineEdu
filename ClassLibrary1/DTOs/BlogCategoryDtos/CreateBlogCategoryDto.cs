using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDtos
{
    public class CreateBlogCategoryDto
    {
        public string BlogCategoryName { get; set; }
        /*public List<ResultBlogDto> Blogs { get; set; } *///Blog ve BlogCategory arasında ilişki kurmak için kullandık.
    }                                                  //<Blog> --> <ResultBlogDto> olarak değişti
}
