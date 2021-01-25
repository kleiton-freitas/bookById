using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class EstablishmentServicesConverter : IParser<EstablishmentServicesVO, EstablishmentServices>, IParser<EstablishmentServices, EstablishmentServicesVO>
    {
        public EstablishmentServices Parse(EstablishmentServicesVO origin)
        {
            if (origin == null) return null;
            return new EstablishmentServices
            {
                ID = origin.ServiceID,
                ServiceName = origin.ServiceName,
                ServiceDescription = origin.ServiceDescription,
                ServiceValue = origin.ServiceValue,
                EstablishmentID = origin.EstablishmentID

            };
        }

        public List<EstablishmentServices> Parse(List<EstablishmentServicesVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public EstablishmentServicesVO Parse(EstablishmentServices origin)
        {
            if (origin == null) return null;
            return new EstablishmentServicesVO
            {
                ServiceID = origin.ID,
                ServiceName = origin.ServiceName,
                ServiceDescription = origin.ServiceDescription,
                ServiceValue = origin.ServiceValue,
                EstablishmentID = origin.EstablishmentID

            };
        }

        public List<EstablishmentServicesVO> Parse(List<EstablishmentServices> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
