using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;
using Microsoft.Extensions.Logging;

namespace BookByIdApi.Businness.Implementations
{
    public class EstablishmentBusinnessImplementation : IEstablishmentBusinness
    {
        private readonly ILogger<EstablishmentBusinnessImplementation> _logger;
        private readonly IRepository<EstablishmentBusinness> _repository; 
        private readonly EstablishmentBusinnessConverter _converter;

        public EstablishmentBusinnessImplementation(ILogger<EstablishmentBusinnessImplementation> logger,
            IRepository<EstablishmentBusinness> repository)
        {
            _logger = logger;
            _repository = repository;
            _converter = new EstablishmentBusinnessConverter();
        }

        public EstablishmentBusinnessVO Create(EstablishmentBusinnessVO establishmentBusinness)
        {
            var entity = _converter.Parse(establishmentBusinness);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<EstablishmentBusinnessVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public EstablishmentBusinnessVO Update(EstablishmentBusinnessVO establishmentBusinness)
        {
            var entity = _converter.Parse(establishmentBusinness);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
    }
}
