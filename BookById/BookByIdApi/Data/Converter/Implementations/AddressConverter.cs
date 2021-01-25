using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class AddressConverter : IParser<AddressVO, Address>, IParser<Address, AddressVO>
    {
        public Address Parse(AddressVO origin)
        {
            if (origin == null) return null;
            return new Address
            {
                ID = origin.AddressID,
                Country = origin.Country,
                PostalCode = origin.PostalCode,
                UF = origin.UF,
                City = origin.City,
                Neighborhood = origin.Neighborhood,
                Street = origin.Street,
                Number = origin.Number,
                Complement = origin.Complement,
                UserID = origin.UserID
            };
        }

        public List<Address> Parse(List<AddressVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public AddressVO Parse(Address origin)
        {
            if (origin == null) return null;
            return new AddressVO
            {
                AddressID = origin.ID,
                Country = origin.Country,
                PostalCode = origin.PostalCode,
                UF = origin.UF,
                City = origin.City,
                Neighborhood = origin.Neighborhood,
                Street = origin.Street,
                Number = origin.Number,
                Complement = origin.Complement,
                UserID = origin.UserID
            };
        }

        public List<AddressVO> Parse(List<Address> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
