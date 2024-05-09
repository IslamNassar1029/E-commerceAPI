using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Repositorries.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Repositorries.Products
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(E_commerceContext context) : base(context) { }

        public IEnumerable<Product> GetAllWithFiltration(int? categoryId, string? name)
        {
            var products = _context.Set<Product>()
            .AsNoTracking();

            if (categoryId != null || categoryId > 0)
            {
                products = products.Where(q => q.CategoryId == categoryId);
            }


            if (!string.IsNullOrEmpty(name))
            {
                products = products.Where(q => q.Name.Contains(name!));
            }

            return products.ToList();


        }

        public Product? GetByIdWithDetail(int id)
        {
            return _context.Set<Product>()
                .Include(p => p.Category)
                .FirstOrDefault(p=>p.Id==id);
        }
    }
}
