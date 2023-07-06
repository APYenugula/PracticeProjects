using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? FirstName { get; set; }

    public byte[]? LastName { get; set; }

    public string? Email { get; set; }

    public decimal? Phone { get; set; }

    public string? Active { get; set; }

    public int StoreId { get; set; }

    public int ManagerId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Store Store { get; set; } = null!;
}
