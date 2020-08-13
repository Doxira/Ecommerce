namespace Eccomerce.Models
{
    public class UserWithToken : Users
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public UserWithToken(Users user)
        {
            this.Id = user.Id;
            this.Username = user.Username;
        }
    }
}
