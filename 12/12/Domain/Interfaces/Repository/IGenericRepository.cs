﻿using System;
using System.Linq;

namespace Domain.Interfaces.Repository
{
    public interface IGenericRepository<T>
        where T: class
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
