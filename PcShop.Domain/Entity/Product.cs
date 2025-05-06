using PcShop.Domain.Interface;

namespace PcShop.Domain.Entity;

public class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = decimal.Zero;

    public ICollection<ProductVariant> Variants { get; set; } = [];
}
