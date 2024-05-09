using E_commerceAPI.BL.Dtos.Products;
using E_commerceAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Products
{
    public class ProductManager : IProductManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<ProductReadDto> GetAll()
        {
            var products=_unitOfWork.ProductRepository.GetAll();
            return products.Select(p => new ProductReadDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
                Model = p.Model,
                Discount = p.Discount,
                Description = p.Description,
                ProductImageURL = p.ProductImageURL,
            });
        }

        public IEnumerable<ProductReadDto> GetAllWithFiltration(int? categoryId, string? name)
        {
            var products = _unitOfWork.ProductRepository.GetAllWithFiltration(categoryId, name);
            return products.Select(p => new ProductReadDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
                Model = p.Model,
                Discount = p.Discount,
                Description = p.Description,
                ProductImageURL = p.ProductImageURL,
            });
        }

        public ProductDetailDto? GetById(int id)
        {
            var p =_unitOfWork.ProductRepository.GetByIdWithDetail(id);
            if (p is null)
            {
                return null;
            }

            return new ProductDetailDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Model = p.Model,
                Discount = p.Discount,
                Description = p.Description,
                ProductImageURL = p.ProductImageURL,
                CategoryId = p.Category.Id,
                CategoryName = p.Category.Name,

            };
        }
    }
}
