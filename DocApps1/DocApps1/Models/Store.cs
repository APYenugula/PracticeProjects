﻿using System;
using System.Collections.Generic;

namespace DocApps1.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Stocks = new HashSet<Stock>();
            staff = new HashSet<Staff>();
        }

        public int StoreId { get; set; }
        public string? StoreName { get; set; }
        public decimal? Phone { get; set; }
        public string? Email { get; set; }
        public byte[]? Street { get; set; }
        public string? City { get; set; }
        public byte[]? State { get; set; }
        public decimal? ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
