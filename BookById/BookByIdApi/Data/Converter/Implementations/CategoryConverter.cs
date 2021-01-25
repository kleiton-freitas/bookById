using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Data.Converter.Contract;
using BookByIdApi.Data.ValueObject;
using BookByIdApi.Model;

namespace BookByIdApi.Data.Converter.Implementations
{
    public class CategoryConverter : IParser<CategoryVO, EstablishmentCategory>, IParser<EstablishmentCategory, CategoryVO>
    {
        public EstablishmentCategory Parse(CategoryVO origin)
        {
            if (origin == null) return null;
            return new EstablishmentCategory
            {
                ID = origin.CategoryID,
                CategoryName = origin.CategoryName,
                CategoryDescription = origin.CategoryDescription
            };
        }

        public List<EstablishmentCategory> Parse(List<CategoryVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public CategoryVO Parse(EstablishmentCategory origin)
        {
            if(origin == null) return null;
            return new CategoryVO
            {
                CategoryID = origin.ID,
                CategoryName = origin.CategoryName,
                CategoryDescription = origin.CategoryDescription
            };
        }

        public List<CategoryVO> Parse(List<EstablishmentCategory> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
