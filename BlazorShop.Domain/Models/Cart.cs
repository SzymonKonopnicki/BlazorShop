using BlazorShop.Domain.DTO;

namespace BlazorShop.Domain.Models;

public class Cart
{
    public int Id { get; set; }
    public List<ProductCartDTO> ProductCartDtos { get; set; }
    public double CartPrice { get; set; }
}