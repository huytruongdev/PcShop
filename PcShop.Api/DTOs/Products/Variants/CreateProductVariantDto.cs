using PcShop.Api.DTOs.Products.Variants.Attributes;

namespace PcShop.Api.DTOs.Products.Variants;

public class CreateProductVariantDto
{
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public ICollection<CreateVariantAttributeDto> Attributes { get; set; } = [];
}
