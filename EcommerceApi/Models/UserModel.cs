using System.Collections.Generic;

namespace Eccomerce.Models
{
    public class UserModel
    {
            public UserModel()
            {
                RefreshTokens = new HashSet<RefreshToken>();
            }
            public int Id { get; set; }

            public string Username { get; set; }

            public string Password { get; set; }

            public string CurrencyCode { get; set; }

            public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        }
}
