using System.ComponentModel.DataAnnotations.Schema;

namespace BookByIdApi.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int ID { get; set; }
    }
}
