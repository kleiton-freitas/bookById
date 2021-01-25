using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
namespace BookByIdApi.Businness
{
    public interface IUserSchedule
    {
        UserSchedulesVO Create(UserSchedulesVO userSchedulesVO);
        UserSchedulesVO FindById(int id);
        List<UserSchedulesVO> FindAll();
        UserSchedulesVO Update(UserSchedulesVO userSchedulesVO);
        void Delete(int id);
    }
}
