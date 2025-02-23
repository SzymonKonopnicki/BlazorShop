namespace BlazorShop.Domain.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
    public double Price { get; set; }
    public List<ProductCategory> Categorys { get; set; }
    public List<ProductVariant> Variants { get; set; }
}
