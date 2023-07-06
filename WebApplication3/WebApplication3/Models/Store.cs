using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public string? StoreName { get; set; }

    public decimal? Phone { get; set; }

    public string? Email { get; set; }

    public byte[]? Street { get; set; }

    public string? City { get; set; }

    public byte[]? State { get; set; }

    public decimal? ZipCode { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
