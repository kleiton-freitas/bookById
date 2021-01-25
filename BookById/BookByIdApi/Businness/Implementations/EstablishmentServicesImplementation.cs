using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Businness.Implementations
{
    public class EstablishmentServicesImplementation : IEstablishmentServices
    {
        private readonly IRepository<EstablishmentServices> _repository;
        private readonly EstablishmentServicesConverter _converter;

        public EstablishmentServicesImplementation(IRepository<EstablishmentServices> repository)
        {
            _repository = repository;
            _converter = new EstablishmentServicesConverter();
        }

        public EstablishmentServicesVO Create(EstablishmentServicesVO establishmentServicesVO)
        {
            var entity = _converter.Parse(establishmentServicesVO);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<EstablishmentServicesVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public EstablishmentServicesVO Update(EstablishmentServicesVO establishmentServicesVO)
        {
            var entity = _converter.Parse(establishmentServicesVO);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
    }
}
