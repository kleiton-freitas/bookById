using System;
namespace BookByIdApi.Model
{
    public class Schedules
    {
        public int ScheduleID { get; set; }
        //servicetype
        public DateTime AvailableTime { get; set; }
        public DateTime AvailableDate { get; set; }
        //establishment_businness
        public ScheduleStatus scheduleStatus { get; set; }

        public Schedules()
        {
        }
    }
}
