using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public partial class OrderProducts
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
