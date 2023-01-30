using AutoMapper;
using ShoppingCart.Application.DTOs.ProductInfo;
using ShoppingCart.Domain.PrimaryEntities;

namespace ShoppingCart.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductInfo, ProductInfoListDto>().ReverseMap();
        }
    }
}
