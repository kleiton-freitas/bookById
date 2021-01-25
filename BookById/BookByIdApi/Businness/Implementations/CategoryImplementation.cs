using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Contracts;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class CategoryImplementation : ICategory
    {
        private readonly IRepository<EstablishmentCategory> _repository;
        private readonly ICategoryRepository _repo_category;
        private readonly CategoryConverter _categoryConverter;

        public CategoryImplementation(IRepository<EstablishmentCategory> repository, ICategoryRepository repocategory)
        {
            _repository = repository;
            _repo_category = repocategory;
            _categoryConverter = new CategoryConverter();
        }
        
        public CategoryVO Create(CategoryVO category)
        {
            var categoryEntity = _categoryConverter.Parse(category);
            categoryEntity = _repository.Create(categoryEntity);
            return _categoryConverter.Parse(categoryEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<CategoryVO> FindAll()
        {
            return _categoryConverter.Parse(_repository.FindAll());
        }

        public CategoryVO FindByFilter(string name)
        {
            return _categoryConverter.Parse(_repo_category.FindByFilter(name));
        }

        public CategoryVO FindById(int id)
        {
            return _categoryConverter.Parse(_repository.FindById(id));
        }

        public CategoryVO Update(CategoryVO category)
        {
            var categoryEntity = _categoryConverter.Parse(category);
            categoryEntity = _repository.Update(categoryEntity);
            return _categoryConverter.Parse(categoryEntity);
        }
    }
}
