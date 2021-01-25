using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
namespace BookByIdApi.Data.Converter.Implementations
{
    public class UserSchedulesConverter : IParser<UserSchedulesVO, UserSchedule>, IParser<UserSchedule, UserSchedulesVO>
    {
        public UserSchedule Parse(UserSchedulesVO origin)
        {
            if (origin == null) return null;
            return new UserSchedule
            {
                ID = origin.UserScheduleID,
                ScheduleDate = origin.ScheduleDate,
                ScheduleTime = origin.ScheduleTime,
                ScheduleStatus = origin.ScheduleStatus,
                UserID = origin.UserID
            };
        }

        public List<UserSchedule> Parse(List<UserSchedulesVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public UserSchedulesVO Parse(UserSchedule origin)
        {
            if (origin == null) return null;
            return new UserSchedulesVO
            {
                UserScheduleID= origin.ID,
                ScheduleDate = origin.ScheduleDate,
                ScheduleTime = origin.ScheduleTime,
                ScheduleStatus = origin.ScheduleStatus,
                UserID = origin.UserID
            };
        }

        public List<UserSchedulesVO> Parse(List<UserSchedule> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
