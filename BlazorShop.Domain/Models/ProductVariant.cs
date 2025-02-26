namespace BlazorShop.Domain.Models;

public class ProductVariant
{
    public int Id { get; set; }
    public string Size { get; set; }
    public double Price { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
}
