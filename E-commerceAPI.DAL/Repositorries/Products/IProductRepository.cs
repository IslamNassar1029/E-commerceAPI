using E_commerceAPI.DAL.Repositorries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetAllWithFiltration(int? categoryId, string? name);
        Product? GetByIdWithDetail(int id);
    }
}
