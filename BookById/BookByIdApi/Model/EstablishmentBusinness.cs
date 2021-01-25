using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_ESTABLISHMENT_BUSINNESS")]
    public class EstablishmentBusinness : BaseEntity
    {
        [Column("opening_time")]
        public string OpeningTime { get; set; }
        [Column("closing_time")]
        public string ClosingTime { get; set; }
        [Column("opening_day")]
        public string OpeningDay { get; set; }
        [Column("closing_day")]
        public string ClosingDay { get; set; }
        [Column("about_us")]
        public string AboutUs { get; set; }
        [Column("establishment_id")]
        public int EstablishmentID { get; set; }
        

        public EstablishmentBusinness()
        {
        }
    }
}
