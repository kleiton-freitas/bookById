using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_USER")]
    public class User : BaseEntity
    {
        //[Key]
        //[Column("id")]
        //public int UserID { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("document")]
        public string Document { get; set; }
        [Column("cellphone")]
        public string CellPhone { get; set; }
        [Column("social_network")]
        public string SocialNetwork { get; set; }
        [Column("picture")]
        public string Picture { get; set; }
        [Column("refresh_token")]
        public string RefreshToken { get; set; }
        [Column("refresh_token_expire_time")]
        public DateTime RefresTokenExpiryTime { get; set; }
        [JsonIgnore]
        [Column("address_id")]
        public int AddressID { get; set; }
        
        public Address Address { get; set; }

        public User()
        {
            Address = new Address();
        }
    }
}
