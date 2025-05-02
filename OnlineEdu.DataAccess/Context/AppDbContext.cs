﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.DataAccess.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
        
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogsCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }  
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
