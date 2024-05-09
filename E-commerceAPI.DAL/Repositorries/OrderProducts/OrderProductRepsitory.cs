using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Data.Models;
using E_commerceAPI.DAL.Repositorries.Generic;
using E_commerceAPI.DAL.Repositorries.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.OrderProducts
{
    public class OrderProductRepsitory : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepsitory(E_commerceContext context) : base(context)
        {
        }
    }
}
