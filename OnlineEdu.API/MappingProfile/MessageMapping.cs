﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class MessageMapping : Profile
    {
        public MessageMapping() 
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
}
