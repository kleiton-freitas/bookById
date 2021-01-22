using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookByIdApi.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        [JsonIgnore]
        public int ID { get; set; }
    }
}
