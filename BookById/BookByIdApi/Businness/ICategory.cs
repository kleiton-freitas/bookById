using System;
using System.Collections.Generic;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface ICategory
    {
        EstablishmentCategory Create(EstablishmentCategory category);
        EstablishmentCategory FindById(int id);
        List<EstablishmentCategory> FindAll();
        EstablishmentCategory Update(EstablishmentCategory category);
        void Delete(int id);
    }
}
