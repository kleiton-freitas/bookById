using System;
using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface ICategory
    {
        CategoryVO Create(CategoryVO category);
        CategoryVO FindById(int id);
        List<CategoryVO> FindAll();
        CategoryVO Update(CategoryVO category);
        void Delete(int id);
        CategoryVO FindByFilter(string name);
    }
}
