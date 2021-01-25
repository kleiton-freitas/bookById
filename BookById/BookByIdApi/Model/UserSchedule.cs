using System;
using System.ComponentModel.DataAnnotations.Schema;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Model
{
    [Table("tb_USER_SCHEDULE")]
    public class UserSchedule : BaseEntity
    {
        [Column("schedule_date")]
        public DateTime ScheduleDate { get; set; }
        [Column("schedule_time")]
        public string ScheduleTime { get; set; }
        [Column("schedule_status_id")]
        public int ScheduleStatus { get; set; }
        [Column("user_id")]
        public int UserID { get; set; }
        //public int Rating { get; set; }
        //user_id
        public UserSchedule()
        {
        }
    }
}
