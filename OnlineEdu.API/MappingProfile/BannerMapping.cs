﻿using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();

        }
    }
}
