﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_ESTABLISHMENT")]
    public class Establishment : BaseEntity
    {
        //[Column("id")]
        //public int EstablishmentID { get; set; }

        [Column("cnpj_cpf")]
        public string CnpjCpf { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("company_fancy_name")]
        public string CompanyFancyName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("cellphone")]
        public string CellPhone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("website")]
        public string WebSite { get; set; }

        [Column("social_network")]
        public string SocialNetwork { get; set; }

        [Column("logo")]
        public string Logo { get; set; }

        [Column("cover_photo")]
        public string CoverPhoto { get; set; }

        [Column("establishment_category_id")]
        public int CategoryID { get; set; }

        [Column("user_id")]
        public int UserID { get; set; }


        //address
        //userID


        public Establishment()
        {
        }
    }
}
