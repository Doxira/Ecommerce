using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}
