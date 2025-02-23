﻿namespace BlazorShop.Domain.DTO;

public class ProductCartDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }
    public int Quantity { get; set; }
}
