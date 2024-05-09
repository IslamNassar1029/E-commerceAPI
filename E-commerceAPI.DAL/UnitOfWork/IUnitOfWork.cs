using E_commerceAPI.DAL.Repositorries.Categories;
using E_commerceAPI.DAL.Repositorries.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }    
        public ICategoryRepository CategoryRepository { get; }
        void SaveChanges();
    }
}
