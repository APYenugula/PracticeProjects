using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal? Phone { get; set; }

    public string? Email { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public decimal? ZipCode { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
