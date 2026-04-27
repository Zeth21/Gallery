using AutoMapper;
using Gallery.Business.DTOs.CarDTOs;
using Gallery.Entities;

namespace Gallery.Business.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            // Car

            CreateMap<CreateCarRequestDTO, Car>()
            .ForMember(dest => dest.Cover, opt => opt.Ignore())
            .ForMember(dest => dest.Images, opt => opt.Ignore());

            CreateMap<Car, CarListResponseDTO>()
                .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Brand.Id))
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.BrandLogoUrl, opt => opt.MapFrom(src => src.Brand.Logo.Url))
                .ForMember(dest => dest.CoverUrl, opt => opt.MapFrom(src => src.Cover.Url));
            
            CreateMap<Car, CarDetailResponseDTO>()
                .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Brand.Id))
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.BrandLogoUrl, opt => opt.MapFrom(src => src.Brand.Logo.Url))
                .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Images.Select(x => x.ImageUrl).ToList()));
        }

    }
}
