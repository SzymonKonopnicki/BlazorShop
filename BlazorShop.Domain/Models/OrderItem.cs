﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Domain.Models;

public class OrderItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }
    public int Quantity { get; set; }
}