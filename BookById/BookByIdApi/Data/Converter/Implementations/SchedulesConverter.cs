using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
namespace BookByIdApi.Data.Converter.Implementations
{
    public class SchedulesConverter : IParser<SchedulesVO, Schedules>, IParser<Schedules, SchedulesVO>
    {
        public Schedules Parse(SchedulesVO origin)
        {
            if (origin == null) return null;
            return new Schedules
            {
                ID = origin.ScheduleID,
                AvailableTime = origin.AvailableTime,
                AvailableDate = origin.AvailableDate,
                scheduleStatus = origin.scheduleStatus,
                AttendancesNumber = origin.AttendancesNumber,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<Schedules> Parse(List<SchedulesVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public SchedulesVO Parse(Schedules origin)
        {
            if (origin == null) return null;
            return new SchedulesVO
            {
                ScheduleID = origin.ID,
                AvailableTime = origin.AvailableTime,
                AvailableDate = origin.AvailableDate,
                scheduleStatus = origin.scheduleStatus,
                AttendancesNumber = origin.AttendancesNumber,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<SchedulesVO> Parse(List<Schedules> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
