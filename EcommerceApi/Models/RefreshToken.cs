using System;

namespace Eccomerce.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }
        public virtual UserModel User { get; set; }
    }
}
