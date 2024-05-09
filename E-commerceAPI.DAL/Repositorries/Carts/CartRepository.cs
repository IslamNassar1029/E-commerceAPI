using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Carts
{
    public class CartRepository:GenericRepository<Cart>,ICartRepository
    {
        public CartRepository(E_commerceContext context)
        : base(context)
        {
        }
    }
}
