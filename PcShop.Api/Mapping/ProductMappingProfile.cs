using AutoMapper;
using PcShop.Api.DTOs.Products;
using PcShop.Api.DTOs.Products.Variants;
using PcShop.Api.DTOs.Products.Variants.Attributes;
using PcShop.Domain.Entity;

namespace PcShop.Api.Mapping;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<CreateProductDto, Product>();
        CreateMap<CreateProductVariantDto, ProductVariant>();
        CreateMap<CreateVariantAttributeDto, VariantAttribute>();
    }
}
