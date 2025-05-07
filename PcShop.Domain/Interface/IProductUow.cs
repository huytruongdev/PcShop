using PcShop.Domain.Entity;

namespace PcShop.Domain.Interface;

public interface IProductUow
{
    IRepository<Product> Products { get; }
    IRepository<ProductVariant> ProductVariants { get; }
    IRepository<VariantAttribute> VariantAttributes { get; }

    Task<int> SaveChangesAsync();
}
