using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;
namespace BookByIdApi.Businness
{
    public interface IEstablishmentAddress
    {
        EstablishmentAddressVO Create(EstablishmentAddressVO establishmentAddress);
        EstablishmentAddressVO FindById(int id);
        List<EstablishmentAddressVO> FindAll();
        EstablishmentAddressVO Update(EstablishmentAddressVO establishmentAddress);
    }
}
