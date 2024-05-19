using E_commerceAPI.BL.Dtos.Products;
using E_commerceAPI.BL.Managers.Products;
using Microsoft.AspNetCore.Authorization;
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
        [Route("GetProductsWithFilter")]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts(int? categoryId,String? name)
        {
            var products = _productManager.GetAllWithFiltration(categoryId,name);
            return products.ToList();
        }
        [HttpGet]
        [Route("GetProductWithDetails/{id}")]
        public ActionResult<ProductDetailDto> GetProductById(int id)
        {
            var product= _productManager.GetById(id);
            if (product is null)
            {
                return NotFound();
            }
            return product;
        }

        [Authorize(Policy = "AdminOnly")]
        [HttpPost]
        [Route("AddProduct")]
        public  ActionResult AddProduct(AddProductDto product)
        {
            if (product == null) return BadRequest();
            _productManager.AddProduct(product);
            return Ok("product was Add Successfully");
        }
        [Authorize(Policy = "AdminOnly")]
        [HttpPut]
        [Route("EditProduct")]
        public ActionResult EditProduct(EditProductDto product)
        {
            if (product == null) return BadRequest();
            _productManager.EditProduct(product);
            return Ok("product was Edited Successfully");
        }
        [Authorize(Policy = "AdminOnly")]
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public ActionResult<ProductDetailDto> DeleteProduct(int id)
        {
            bool isDeleted = _productManager.DeleteProduct(id);

            return isDeleted ? Ok("product was Deleted Successfully") : BadRequest();
        }
    }
}
