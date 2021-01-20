﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_ESTABLISHMENT_CATEGORY")]
    public class EstablishmentCategory : BaseEntity
    {
        //[Column("id")]
        //public int CategoryID { get; set; }
        [JsonPropertyName("category")]
        [Column("category_name")]
        public string CategoryName { get; set; }
        [JsonPropertyName("description")]
        [Column("category_description")]
        public string CategoryDescription { get; set; }

        public EstablishmentCategory()
        {
        }
    }
}
