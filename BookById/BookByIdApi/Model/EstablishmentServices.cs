using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_ESTABLISHMENT_SERVICES")]
    public class EstablishmentServices : BaseEntity
    {
        [Column("service_name")]
        public string ServiceName { get; set; }
        [Column("service_description")]
        public string ServiceDescription { get; set; }
        [Column("service_value")]
        public string ServiceValue { get; set; }
        [Column("establishment_id")]
        public int EstablishmentID { get; set; }


    }
}
