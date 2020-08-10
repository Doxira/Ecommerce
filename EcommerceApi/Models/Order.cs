using Eccomerce.Models.OrderStatus;
using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public class Order
    {
        public int Id { get; set; }

        public UserModel User { get; set; }

        public int UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual StatusCodes StatusCodes { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
