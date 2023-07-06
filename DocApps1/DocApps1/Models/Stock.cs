using System;
using System.Collections.Generic;

namespace DocApps1.Models
{
    public partial class Stock
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int? Qunatity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
