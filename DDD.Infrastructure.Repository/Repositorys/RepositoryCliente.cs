using DDD.Domain.Core.Interfaces.Repositorys;
using DDD.Domain.Models;
using DDD.Infrastructure.Data;

namespace DDD.Infrastructure.Repository.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}