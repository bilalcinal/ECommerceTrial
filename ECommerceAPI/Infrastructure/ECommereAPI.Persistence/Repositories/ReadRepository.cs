using System.Linq.Expressions;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommereAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ECommereAPI.Persistence.Repositories;

    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;

        public ReadRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) =>Table.Where(method);
        
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data =>data.Id == Guid.Parse(id));
        
    }
