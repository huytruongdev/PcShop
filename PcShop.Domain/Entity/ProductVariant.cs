using PcShop.Domain.Interface;

namespace PcShop.Domain.Entity;

public class ProductVariant : IEntity
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public decimal Price { get; set; }
    public int Stock { get; set; }

    public ICollection<VariantAttribute> Attributes { get; set; }
}
