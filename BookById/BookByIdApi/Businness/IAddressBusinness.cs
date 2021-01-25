using System;
using System.Collections.Generic;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Businness
{
    public interface IAddressBusinness
    {
        AddressVO Create(AddressVO address);
        AddressVO Update(AddressVO address);
        List<AddressVO> FindAll();
    }
}
