using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class SchedulesImplementation : ISchedules
    {
        private readonly IRepository<Schedules> _repository;
        private readonly SchedulesConverter _converter;

        public SchedulesImplementation(IRepository<Schedules> repository)
        {
            _repository = repository;
            _converter = new SchedulesConverter();
        }

        public SchedulesVO Create(SchedulesVO schedules)
        {
            var entity = _converter.Parse(schedules);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<SchedulesVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public SchedulesVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public SchedulesVO Update(SchedulesVO schedules)
        {
            var entity = _converter.Parse(schedules);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
    }
}
