using PcShop.Domain.Entity;

namespace PcShop.Infrastructure.UnitOfWorks;

public class ProductUow(
    AppDbContext context,
    IRepository<Product> products,
    IRepository<ProductVariant> productVariants,
    IRepository<VariantAttribute> variantAttributes) : IProductUow
{
    private readonly AppDbContext _context = context;

    public IRepository<Product> Products { get; } = products;
    public IRepository<ProductVariant> ProductVariants { get; } = productVariants;
    public IRepository<VariantAttribute> VariantAttributes { get; } = variantAttributes;

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
