using AutoMapper;
using OnlineEdu.DTO.DTOs.SocialMediaDtos;
using OnlineEdu.DTO.DTOs.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping()
        {
            CreateMap<CreateSubscriberDto, SocialMedia>().ReverseMap();
            CreateMap<UpdateSubscriberDto, SocialMedia>().ReverseMap();
        }
    }
}
