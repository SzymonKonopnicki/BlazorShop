namespace BlazorShop.Domain.Models;

public class JunctionProductCategory
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int CategoryId { get; set; }
    public ProductCategory Category { get; set; }
}
