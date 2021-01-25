using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class EstablishmentImplementation : IEstablishment
    {
        private readonly IRepository<Establishment> _repository;
        private readonly EstablishmentConverter _converter;

        public EstablishmentImplementation(IRepository<Establishment> repository)
        {
            _repository = repository;
            _converter = new EstablishmentConverter();
        }

        public EstablishmentVO Create(EstablishmentVO establishment)
        {
            var entity = _converter.Parse(establishment);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<EstablishmentVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public EstablishmentVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public EstablishmentVO Update(EstablishmentVO establishment)
        {
            var entity = _converter.Parse(establishment);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
        
    }
}
