namespace PcShop.Domain.Entity;

public class VariantAttribute
{
    public int Id { get; set; }
    public int VariantId { get; set; }
    public ProductVariant Variant { get; set; }

    public string Key { get; set; }
    public string Value { get; set; }
}
