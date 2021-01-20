using System;
using System.Collections.Generic;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class CategoryImplementation : ICategory
    {
        private readonly IRepository<EstablishmentCategory> _repository;

        public CategoryImplementation(IRepository<EstablishmentCategory> repository)
        {
            _repository = repository;
        }

        public EstablishmentCategory Create(EstablishmentCategory category)
        {
            return _repository.Create(category);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<EstablishmentCategory> FindAll()
        {
            return _repository.FindAll();
        }

        public EstablishmentCategory FindById(int id)
        {
            return _repository.FindById(id);
        }

        public EstablishmentCategory Update(EstablishmentCategory category)
        {
            return _repository.Update(category);
        }
    }
}
