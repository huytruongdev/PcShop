using PcShop.Api.DTOs.Products.Variants;

namespace PcShop.Api.DTOs.Products;

public class CreateProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<CreateProductVariantDto> Variants { get; set; } = [];
}
