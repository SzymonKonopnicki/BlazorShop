using BlazorShop.Domain.Models;

namespace BlazorShop.Domain.DTO;

public class ProductViewDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
    public List<ProductVariant> Variants { get; set; }
}