using System;
namespace BookByIdApi.Model
{
    public class UserSchedule
    {
        public int UserScheduleID { get; set; }
        //schedule
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleTime { get; set; }
        public ScheduleStatus scheduleStatus { get; set; }
        public int Rating { get; set; }
        //user_id
        public UserSchedule()
        {
        }
    }
}
