using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_SCHEDULES")]
    public class Schedules : BaseEntity
    {
        [Column("available_time")]
        public string AvailableTime { get; set; }

        [Column("date")]
        public DateTime AvailableDate { get; set; }

        [Column("schedule_status")]
        public int scheduleStatus { get; set; }

        [Column("attendances_number")]
        public int AttendancesNumber { get; set; }

        [Column("establishment_id")]
        public int EstablishmentID { get; set; }

        public Schedules()
        {
        }
    }
}
