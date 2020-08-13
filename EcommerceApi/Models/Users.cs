using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
            RefreshTokens = new HashSet<RefreshTokens>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CurrencyCode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<RefreshTokens> RefreshTokens { get; set; }
    }
}
