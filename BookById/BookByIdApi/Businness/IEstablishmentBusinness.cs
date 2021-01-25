using System;
using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;

namespace BookByIdApi.Businness
{
    public interface IEstablishmentBusinness
    {
        EstablishmentBusinnessVO Create(EstablishmentBusinnessVO establishmentBusinness);
        EstablishmentBusinnessVO Update(EstablishmentBusinnessVO establishmentBusinness);
        List<EstablishmentBusinnessVO> FindAll();
        void Delete(int id);
    }
}
