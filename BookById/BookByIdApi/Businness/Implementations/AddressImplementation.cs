using System;
using System.Collections.Generic;
using BookByIdApi.Data.Converter.Implementations;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
using BookByIdApi.Repository.Generic;

namespace BookByIdApi.Businness.Implementations
{
    public class AddressImplementation : IAddressBusinness
    {
        private readonly IRepository<Address> repository;
        private AddressConverter addressConverter;

        public AddressImplementation(IRepository<Address> repository)
        {
            this.repository = repository;
            addressConverter = new AddressConverter();
        }

        public AddressVO Create(AddressVO address)
        {
            var addressEntity = addressConverter.Parse(address);
            addressEntity = repository.Create(addressEntity);
            return addressConverter.Parse(addressEntity);
        }

        public AddressVO Update(AddressVO address)
        {
            var addressEntity = addressConverter.Parse(address);
            addressEntity = repository.Update(addressEntity);
            return addressConverter.Parse(repository.Update(addressEntity));

        }
        public List<AddressVO> FindAll()
        {
            return addressConverter.Parse(repository.FindAll());
        }
    }
}
