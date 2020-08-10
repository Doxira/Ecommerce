using System.Linq;

namespace Eccomerce.Models
{
    public class LoginCheck : ILoginCheck
    {
        private readonly EccomerceDbContext dbContext;
        public bool userExists(UserModel user)
        {
            var usera = dbContext.Users.FirstOrDefault(x => x.Username == user.Username);

            if (user != null)
            {
                return true;
            }

            return false;

        }
    }
}
