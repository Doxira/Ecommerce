namespace Eccomerce.Models
{
   public interface ILoginCheck
    {
        bool userExists(UserModel user);
    }
}
