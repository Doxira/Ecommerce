using System;
using System.Collections.Generic;

namespace Eccomerce.Models
{
    public partial class RefreshTokens
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual Users User { get; set; }
    }
}
