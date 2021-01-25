using System;
using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;

namespace BookByIdApi.Businness
{
    public interface ISchedules
    {
        SchedulesVO Create(SchedulesVO schedules);
        SchedulesVO FindById(int id);
        List<SchedulesVO> FindAll();
        SchedulesVO Update(SchedulesVO schedules);
        void Delete(int id);
    }
}
