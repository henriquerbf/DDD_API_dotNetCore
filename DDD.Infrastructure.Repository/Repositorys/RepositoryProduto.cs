using DDD.Domain.Core.Interfaces.Repositorys;
using DDD.Domain.Models;
using DDD.Infrastructure.Data;

namespace DDD.Infrastructure.Repository.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {

        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}