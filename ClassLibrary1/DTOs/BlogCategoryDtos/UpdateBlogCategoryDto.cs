using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
       /* public List<Blog> Blogs { get; set; }*/ //Blog ve BlogCategory arasında ilişki kurmak için kullandık.
    }
}
