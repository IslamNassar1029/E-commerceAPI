using E_commerceAPI.BL.Dtos.Products;
using E_commerceAPI.BL.Managers.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_commerceAPI.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductManager _productManager;

        public ProductsController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts(int? categoryId,String? name)
        {
            var products = _productManager.GetAllWithFiltration(categoryId,name);
            return products.ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductDetailDto> GetProductById(int id)
        {
            var product= _productManager.GetById(id);
            if (product is null)
            {
                return NotFound();
            }
            return product;
        }

    }
}
