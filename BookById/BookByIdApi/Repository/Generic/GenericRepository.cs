using System;
using System.Collections.Generic;
using System.Linq;
using BookByIdApi.Model.Base;
using BookByIdApi.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace BookByIdApi.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> dataSet;
        public GenericRepository(MySqlContext context)
        {
            _context = context;
            dataSet = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                dataSet.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<T> FindAll()
        {
           return dataSet.ToList();
        }

        public T FindById(int id)
        {
            return dataSet.SingleOrDefault(p => p.ID.Equals(id));
        }

        public T Update(T item)
        {
            var result = dataSet.SingleOrDefault(u => u.ID == item.ID);

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
                return result;
            }
            else
            {
                return null;
            }
        }
        public void Delete(int id)
        {
            var result = dataSet.SingleOrDefault(p => p.ID.Equals(id));
            if (result != null)
            {
                try
                {
                    dataSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public bool Exists(int id)
        {
            return dataSet.Any(p => p.ID.Equals(id));
        }
    }
}
