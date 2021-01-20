using System;
namespace BookByIdApi.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Document { get; set; }
        public string CellPhone { get; set; }
        public string SocialNetwork { get; set; }
        public string Picture { get; set; }
        //address
        public User()
        {
        }
    }
}
