using System;
using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;
using Microsoft.Extensions.Logging;
namespace BookByIdApi.Businness.Implementations
{
    public class EstablishmentAddressImplementation : IEstablishmentAddress
    {
        private readonly ILogger<EstablishmentAddressImplementation> _logger;
        private readonly IRepository<EstablishmentAddress> _repository;
        private readonly EstablishmentAddressConverter _converter;

        public EstablishmentAddressImplementation(ILogger<EstablishmentAddressImplementation> logger,
            IRepository<EstablishmentAddress> repository)
        {
            _logger = logger;
            _repository = repository;
            _converter = new EstablishmentAddressConverter();
        }

        public EstablishmentAddressVO Create(EstablishmentAddressVO establishmentAddress)
        {
            var entity = _converter.Parse(establishmentAddress);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public List<EstablishmentAddressVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public EstablishmentAddressVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public EstablishmentAddressVO Update(EstablishmentAddressVO establishmentAddress)
        {
            var entity = _converter.Parse(establishmentAddress);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
    }
}
