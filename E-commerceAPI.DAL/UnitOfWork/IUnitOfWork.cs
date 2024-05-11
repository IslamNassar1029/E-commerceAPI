using E_commerceAPI.DAL.Repositorries.Carts;
using E_commerceAPI.DAL.Repositorries.Categories;
using E_commerceAPI.DAL.Repositorries.OrderProducts;
using E_commerceAPI.DAL.Repositorries.Orders;
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
        public ICartRepository CartRepository { get; }  
        public IOrderRepository OrderRepository { get; }
        public IOrderProductRepository OrderProductRepository { get; }
        void SaveChanges();
    }
}
