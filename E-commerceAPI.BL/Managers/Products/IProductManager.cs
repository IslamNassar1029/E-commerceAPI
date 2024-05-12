using E_commerceAPI.BL.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Products
{
    public interface IProductManager
    {
        void AddProduct(AddProductDto product);
        bool DeleteProduct(int id);
        void EditProduct(EditProductDto product);
        IEnumerable<ProductReadDto> GetAll();
        IEnumerable<ProductReadDto> GetAllWithFiltration(int? categoryId, string? name);
        ProductDetailDto? GetById(int id);
    }
}
