using DDD.Domain.Core.Interfaces.Repositorys;
using DDD.Domain.Core.Interfaces.Services;
using DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto RepositoryProduto)
            : base(RepositoryProduto)
        {
            _repositoryProduto = RepositoryProduto;
        }
    }
}
