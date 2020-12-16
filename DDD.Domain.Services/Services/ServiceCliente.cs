using DDD.Domain.Core.Interfaces.Repositorys;
using DDD.Domain.Core.Interfaces.Services;
using DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }

    }
}
