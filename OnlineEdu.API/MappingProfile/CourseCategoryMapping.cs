using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping() 
        {
            CreateMap<CreateCourseCatageoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCatageoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCatageoryDto, CourseCategory>().ReverseMap();
        }
    }
}
