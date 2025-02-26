namespace BlazorShop.Domain.Models;

public class ProductCategory
{
    public int Id { get; set; }
    public string Category { get; set; }

    public ICollection<JunctionProductCategory> Products { get; set; }

}
