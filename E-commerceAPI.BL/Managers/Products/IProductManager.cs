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
        IEnumerable<ProductReadDto> GetAll();
        IEnumerable<ProductReadDto> GetAllWithFiltration(int? categoryId, string? name);
        ProductDetailDto? GetById(int id);
    }
}
