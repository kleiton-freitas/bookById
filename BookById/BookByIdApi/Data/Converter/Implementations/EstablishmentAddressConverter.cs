using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
namespace BookByIdApi.Data.Converter.Implementations
{
    public class EstablishmentAddressConverter : IParser<EstablishmentAddressVO, EstablishmentAddress>, IParser<EstablishmentAddress, EstablishmentAddressVO>
    {
        public EstablishmentAddress Parse(EstablishmentAddressVO origin)
        {
            if (origin == null) return null;
            return new EstablishmentAddress
            {
                ID = origin.EstablishmentAddressID,
                PostalCode = origin.PostalCode,
                Country = origin.Country,
                UF = origin.UF,
                City = origin.City,
                Neighborhood = origin.Neighborhood,
                Street = origin.Street,
                Number = origin.Number,
                Complement = origin.Complement,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<EstablishmentAddress> Parse(List<EstablishmentAddressVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public EstablishmentAddressVO Parse(EstablishmentAddress origin)
        {
            if (origin == null) return null;
            return new EstablishmentAddressVO
            {
                EstablishmentAddressID = origin.ID,
                PostalCode = origin.PostalCode,
                Country = origin.Country,
                UF = origin.UF,
                City = origin.City,
                Neighborhood = origin.Neighborhood,
                Street = origin.Street,
                Number = origin.Number,
                Complement = origin.Complement,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<EstablishmentAddressVO> Parse(List<EstablishmentAddress> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
