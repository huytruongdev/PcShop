using PcShop.Domain.Entity;

namespace PcShop.Infrastructure.Seeders;

internal static class ProductSeeder
{
    public static IEnumerable<Product> Generate()
    {
        List<Product> products = [];

        for (int i = 1; i <= 30; i++)
        {
            products.Add(new Product
            {
                Id = i,
                Name = $"Product {i}",
                Description = $"This is the description for product {i}",
                //Price = 10 + i * 2
            });
        }

        return products;
    }
}
