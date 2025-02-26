namespace BlazorShop.Domain.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
    public ICollection<JunctionProductCategory> ProductCategories { get; set; }
    public List<ProductVariant> Variants { get; set; }
}
