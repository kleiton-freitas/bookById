using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface IEstablishment
    {
        EstablishmentVO Create(EstablishmentVO establishment);
        EstablishmentVO FindById(int id);
        List<EstablishmentVO> FindAll();
        EstablishmentVO Update(EstablishmentVO establishment);
        void Delete(int id);
    }
}
