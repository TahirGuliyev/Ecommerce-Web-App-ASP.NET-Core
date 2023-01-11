using Ecommerce.Application.Repositories;
using Ecommerce.Domain.Entities;
using Ecommerce.Persistence.Contexts;

namespace Ecommerce.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
