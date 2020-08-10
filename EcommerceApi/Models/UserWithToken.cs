namespace Eccomerce.Models
{
    public class UserWithToken : UserModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public UserWithToken(UserModel user)
        {
            this.Id = user.Id;
            this.Username = user.Username;
        }
    }
}
