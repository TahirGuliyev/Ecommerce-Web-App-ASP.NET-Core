using Ecommerce.Application.Repositories;
using Ecommerce.Domain.Entities;
using Ecommerce.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
