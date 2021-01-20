using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookByIdApi.Model
{
    [Table("tb_ADDRESS")]
    public class Address
    {
        [Column("id")]
        public int AddressID { get; set; }
        [Column("country")]
        public string Coutry { get; set; }
        [Column("postal_code")]
        public string PostalCode { get; set; }
        [Column("uf")]
        public string UF { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("neighborhood")]
        public string Neighborhood { get; set; }
        [Column("street")]
        public string Street { get; set; }
        [Column("number")]
        public int Number { get; set; }
        [Column("complement")]
        public string Complement { get; set; }

        public Address()
        {
        }
    }
}
