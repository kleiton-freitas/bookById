using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class EstablishmentBusinnessConverter : IParser<EstablishmentBusinnessVO, EstablishmentBusinness>, IParser<EstablishmentBusinness, EstablishmentBusinnessVO>
    {
        public EstablishmentBusinness Parse(EstablishmentBusinnessVO origin)
        {
            if (origin == null) return null;
            return new EstablishmentBusinness
            {
                ID = origin.EstablishmentBusinnessID,
                OpeningTime = origin.OpeningTime,
                ClosingTime = origin.ClosingTime,
                OpeningDay = origin.OpeningDay,
                ClosingDay = origin.ClosingDay,
                AboutUs = origin.AboutUs,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<EstablishmentBusinness> Parse(List<EstablishmentBusinnessVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public EstablishmentBusinnessVO Parse(EstablishmentBusinness origin)
        {
            if (origin == null) return null;
            return new EstablishmentBusinnessVO
            {
                EstablishmentBusinnessID = origin.ID,
                OpeningTime = origin.OpeningTime,
                ClosingTime = origin.ClosingTime,
                OpeningDay = origin.OpeningDay,
                ClosingDay = origin.ClosingDay,
                AboutUs = origin.AboutUs,
                EstablishmentID = origin.EstablishmentID
            };
        }

        public List<EstablishmentBusinnessVO> Parse(List<EstablishmentBusinness> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
