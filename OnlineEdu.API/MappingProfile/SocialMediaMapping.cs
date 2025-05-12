using AutoMapper;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping() 
        {

            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
            
        }
    }
}
