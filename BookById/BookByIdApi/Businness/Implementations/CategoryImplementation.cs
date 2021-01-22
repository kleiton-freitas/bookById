using System;
using System.Collections.Generic;
using BookByIdApi.Model;
using BookByIdApi.Repository.Contracts;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class CategoryImplementation : ICategory
    {
        private readonly IRepository<EstablishmentCategory> _repository;
        private readonly ICategoryRepository _repo_category;

        public CategoryImplementation(IRepository<EstablishmentCategory> repository, ICategoryRepository repocategory)
        {
            _repository = repository;
            _repo_category = repocategory;
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

        public EstablishmentCategory FindByFilter(string name)
        {
            return _repo_category.FindByFilter(name);
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
