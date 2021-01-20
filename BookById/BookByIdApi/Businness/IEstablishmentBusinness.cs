using System.Collections.Generic;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface IEstablishmentBusinness
    {
        Establishment Create(Establishment establishment);
        Establishment FindById(int id);
        List<Establishment> FindAll();
        Establishment Update(Establishment establishment);
        void Delete(int id);
    }
}
