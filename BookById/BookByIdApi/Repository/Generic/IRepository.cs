﻿using System;
using System.Collections.Generic;
using BookByIdApi.Model.Base;

namespace BookByIdApi.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(int id);
        List<T> FindAll();
        T Update(T item);
        void Delete(int id);
        bool Exists(int id);
    }
}
