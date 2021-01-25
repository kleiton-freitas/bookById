using System;
using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;

namespace BookByIdApi.Businness
{
    public interface IEstablishmentServices
    {
        EstablishmentServicesVO Create(EstablishmentServicesVO establishmentServicesVO);
        EstablishmentServicesVO Update(EstablishmentServicesVO establishmentServicesVO);
        List<EstablishmentServicesVO> FindAll();
        void Delete(int id);
    }
}
