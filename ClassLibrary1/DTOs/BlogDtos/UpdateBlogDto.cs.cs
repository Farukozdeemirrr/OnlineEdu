﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogDtos
{
    public class UpdateBlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }

        public int BlogCategoryId { get; set; }
        /* public ResultBlogDto BlogCategory { get; set; }*/// Entity tarafından BlogCategory geldi bunu ResultBlogDto ile değiştireceğiz
    }
}