using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Orders
{
    public class OrderRepository:GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(E_commerceContext context) : base(context) { }

        public int GetLastOrderId(string userId)
        {
            return _context.Set<Order>()
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.CreationOrderDate)
                .First().Id;
        }

    }
}
