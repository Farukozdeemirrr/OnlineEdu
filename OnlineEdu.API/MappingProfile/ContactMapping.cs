using AutoMapper;
using OnlineEdu.DTO.DTOs.ContactDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class ContactMapping: Profile
    {
        public ContactMapping() 
        {
          CreateMap<CreateContactDto, Contact>().ReverseMap();
          CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
