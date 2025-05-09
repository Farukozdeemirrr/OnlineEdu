using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.CourseCategoryDtos
{
    public class CreateCourseCatageoryDto
    {
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }

    }
}
