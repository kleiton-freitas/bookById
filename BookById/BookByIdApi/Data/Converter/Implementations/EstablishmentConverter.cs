using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class EstablishmentConverter : IParser<EstablishmentVO, Establishment>, IParser<Establishment, EstablishmentVO>
    {
        public EstablishmentConverter()
        {
        }

        public Establishment Parse(EstablishmentVO origin)
        {
            if (origin == null) return null;

            return new Establishment {
                ID = origin.EstablishmentID,
                CnpjCpf = origin.CnpjCpf,
                CompanyName = origin.CompanyName,
                CompanyFancyName = origin.CompanyFancyName,
                Phone = origin.Phone,
                CellPhone = origin.CellPhone,
                Email = origin.Email,
                WebSite = origin.WebSite,
                SocialNetwork = origin.SocialNetwork,
                Logo = origin.Logo,
                CoverPhoto = origin.CoverPhoto,
                CategoryID = origin.CategoryID,
                UserID = origin.UserID

            };
        }

        public List<Establishment> Parse(List<EstablishmentVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public EstablishmentVO Parse(Establishment origin)
        {
            if (origin == null) return null;

            return new EstablishmentVO
            {
                EstablishmentID = origin.ID,
                CnpjCpf = origin.CnpjCpf,
                CompanyName = origin.CompanyName,
                CompanyFancyName = origin.CompanyFancyName,
                Phone = origin.Phone,
                CellPhone = origin.CellPhone,
                Email = origin.Email,
                WebSite = origin.WebSite,
                SocialNetwork = origin.SocialNetwork,
                Logo = origin.Logo,
                CoverPhoto = origin.CoverPhoto,
                CategoryID = origin.CategoryID,
                UserID = origin.UserID

            };
        }

        public List<EstablishmentVO> Parse(List<Establishment> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
