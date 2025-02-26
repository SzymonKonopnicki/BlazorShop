namespace BlazorShop.Domain.Models;

public class Cart
{
    public int Id { get; set; }
    public List<CartItem> CartItems { get; set; }
    public double CartPrice { get; set; }
}