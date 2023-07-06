using System;
using System.Collections.Generic;

namespace DocApps1.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string? FirstName { get; set; }
        public byte[]? LastName { get; set; }
        public string? Email { get; set; }
        public decimal? Phone { get; set; }
        public string? Active { get; set; }
        public int StoreId { get; set; }
        public int ManagerId { get; set; }

        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
