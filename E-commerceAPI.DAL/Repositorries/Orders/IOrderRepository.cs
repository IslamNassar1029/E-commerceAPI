using E_commerceAPI.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Orders
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        int GetLastOrderId(string userId);
    }
}
