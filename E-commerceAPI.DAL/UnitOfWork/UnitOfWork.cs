using E_commerceAPI.DAL.Data.Context;
using E_commerceAPI.DAL.Repositorries.Carts;
using E_commerceAPI.DAL.Repositorries.Categories;
using E_commerceAPI.DAL.Repositorries.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly E_commerceContext _context;

        public IProductRepository ProductRepository { get; }

        public ICategoryRepository CategoryRepository { get; }
        public ICartRepository CartRepository { get; }

        public UnitOfWork( E_commerceContext context
            ,IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ICartRepository cartRepository) 
        { 
            _context=context;
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
            CartRepository = cartRepository;
        } 
        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }
    }
}
