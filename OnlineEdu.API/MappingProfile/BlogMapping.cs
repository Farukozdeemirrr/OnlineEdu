using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.MappingProfile
{
    public class BlogMapping : Profile //(Profile AutoMapper Kütüphanesine ait)
    {
       public BlogMapping() 
        {
           //DTO → Entity (veri alırken)
          // Entity → DTO(veri gösterirken)

        CreateMap<CreateBlogDto,Blog>().ReverseMap(); 
        CreateMap<UpdateBlogDto,Blog>().ReverseMap();
        CreateMap<ResultBlogDto,Blog>().ReverseMap();
        }
    }
}
