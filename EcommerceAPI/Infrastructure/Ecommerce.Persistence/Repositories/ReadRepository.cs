using Ecommerce.Application.Repositories;
using Ecommerce.Domain.Entities.Common;
using Ecommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EcommerceDbContext _context;

        public ReadRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true) 
        {
            IQueryable<T> query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        } 


        

        
    }
}
