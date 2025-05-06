using Microsoft.EntityFrameworkCore;
using PcShop.Domain.Entity;

namespace PcShop.Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
    public DbSet<VariantAttribute> VariantAttributes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Optional: cấu hình Fluent API nếu cần
    }
}
