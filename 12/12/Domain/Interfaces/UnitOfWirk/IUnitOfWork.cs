﻿using Domain.Entities;
using Domain.Interfaces.Repository;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<ClientProfile> Clients { get; }

        Task SaveAsync();
        void Dispose(bool disposing);
    }
}
