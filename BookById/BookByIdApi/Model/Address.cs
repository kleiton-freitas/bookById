﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_ADDRESS")]
    public class Address : BaseEntity
    {
        //[Column("id")]
        //public int AddressID { get; set; }
        [Column("country")]
        public string Country { get; set; }
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
        [Column("user_id")]
        public int UserID { get; set; }

        public Address()
        {
        }
    }
}
