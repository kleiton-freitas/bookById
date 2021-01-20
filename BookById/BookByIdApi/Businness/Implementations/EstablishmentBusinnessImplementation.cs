using System.Collections.Generic;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class EstablishmentBusinnessImplementation : IEstablishmentBusinness
    {
        private readonly IRepository<Establishment> _repository;

        public EstablishmentBusinnessImplementation(IRepository<Establishment> repository)
        {
            _repository = repository;
        }

        public Establishment Create(Establishment establishment)
        {
            return _repository.Create(establishment);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Establishment> FindAll()
        {
            return _repository.FindAll();
        }

        public Establishment FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Establishment Update(Establishment establishment)
        {
            return _repository.Update(establishment);
        }
        
    }
}
