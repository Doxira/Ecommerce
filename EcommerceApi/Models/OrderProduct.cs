using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eccomerce.Models
{
    public class OrderProduct
    {
        public virtual Order Order { get; set; }

        public int OrderId { get; set; }

        public virtual Product  Product{ get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }
    }
}
