using System;
namespace BookByIdApi.Data.ValueObject
{
    public class SchedulesVO
    {
        public int ScheduleID { get; set; }
        public string AvailableTime { get; set; }
        public DateTime AvailableDate { get; set; }
        public int scheduleStatus { get; set; }
        public int AttendancesNumber { get; set; }
        public int EstablishmentID { get; set; }
    }
}
