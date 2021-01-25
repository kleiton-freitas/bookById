using System;
namespace BookByIdApi.Data.ValueObject
{
    public class UserSchedulesVO
    {
        public int UserScheduleID { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string ScheduleTime { get; set; }
        public int ScheduleStatus { get; set; }
        public int UserID { get; set; }

    }
}
