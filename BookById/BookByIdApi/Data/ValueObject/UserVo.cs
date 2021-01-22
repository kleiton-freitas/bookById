using System;
using BookByIdApi.Model;

namespace BookByIdApi.Data.ValueObject
{
    public class UserVo
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
        public string RefreshToken { get; set; }
        public DateTime RefresTokenExpiryTime { get; set; }
        public Address Address { get; set; }

        public UserVo() { Address = new Address(); }

    }
}
