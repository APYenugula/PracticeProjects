﻿using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class OrderItem
{
    public int OrderId { get; set; }

    public int ItemId { get; set; }

    public int ProductId { get; set; }

    public int? Qunatity { get; set; }

    public decimal? ListPrice { get; set; }

    public decimal? Discount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}