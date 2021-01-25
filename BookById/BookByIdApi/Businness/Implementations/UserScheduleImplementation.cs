using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;
namespace BookByIdApi.Businness.Implementations
{
    public class UserScheduleImplementation : IUserSchedule
    {
        private readonly IRepository<UserSchedule> _repository;
        private readonly UserSchedulesConverter _converter;

        public UserScheduleImplementation(IRepository<UserSchedule> repository)
        {
            _repository = repository;
            _converter = new UserSchedulesConverter();
        }

        public UserSchedulesVO Create(UserSchedulesVO userSchedulesVO)
        {
            var entity = _converter.Parse(userSchedulesVO);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<UserSchedulesVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public UserSchedulesVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public UserSchedulesVO Update(UserSchedulesVO userSchedulesVO)
        {
            var entity = _converter.Parse(userSchedulesVO);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
    }
}
