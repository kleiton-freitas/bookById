using System;
using System.Linq;
using BookByIdApi.Model;
using BookByIdApi.Model.Context;
using BookByIdApi.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BookByIdApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MySqlContext _context;

        public CategoryRepository(MySqlContext context)
        {
            _context = context;
        }

        public EstablishmentCategory FindByFilter(string name)
        {
            var filter = _context.Categorys.Where(f => EF.Functions.Like(
                f.CategoryName, $"%{name}%"));

            return filter.SingleOrDefault();
                
        }
    }
}
