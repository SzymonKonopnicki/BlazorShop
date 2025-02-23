﻿namespace BlazorShop.Domain.Models;

public class Order
{
    public int Id { get; set; }
    public bool Paid { get; set; }
    public Status OrderStatus { get; set; }
    public DateTime DeliveryDate { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public Address BuyerAddress { get; set; }
    public Address DeliveryAddress { get; set; }
    public Person BuyerPerson { get; set; }
    public Person DeliveryPerson { get; set; }
    public string Description { get; set; }
}