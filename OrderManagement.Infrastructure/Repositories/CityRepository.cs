using OrderManagement.Domain.AggregatesModel;
using OrderManagement.Domain.Interface;
using OrderManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Repositories
{
   public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public readonly OrderManagementContext context;
        public CityRepository(OrderManagementContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
