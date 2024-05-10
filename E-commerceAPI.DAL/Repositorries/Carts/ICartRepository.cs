using E_commerceAPI.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Carts
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Cart GetByUserIdAndProductId(string userId, int productId);
    }
}
