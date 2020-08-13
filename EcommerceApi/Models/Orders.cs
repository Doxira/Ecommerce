using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StatusCodes { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}
