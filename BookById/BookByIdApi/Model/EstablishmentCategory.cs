using System;
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
        [Column("category_name")]
        public string CategoryName { get; set; }
        [Column("category_description")]
        public string CategoryDescription { get; set; }

        public EstablishmentCategory()
        {
        }
    }
}
