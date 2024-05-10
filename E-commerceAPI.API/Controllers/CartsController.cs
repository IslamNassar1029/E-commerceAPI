using E_commerceAPI.BL.Dtos.Carts;
using E_commerceAPI.BL.Managers.Carts;
using E_commerceAPI.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_commerceAPI.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartManager _cartManager;
        private readonly UserManager<User> _manager;

        public CartsController(ICartManager cartManager,UserManager<User> manager)
        {
            _cartManager = cartManager;
            _manager = manager;
        }


        [Authorize]
        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProductToCart(AddToCartDto addToCart)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            if (userId is null)
            {
                return BadRequest("not logged in");

            }
            addToCart.UserId = userId;  
            _cartManager.AddProductToCart(addToCart);

            return Ok("succeeded");
        }
        [Authorize]
        [HttpDelete]
        [Route("DeleteCart/{ProductId}")]
        public ActionResult DeleteProduct(int ProductId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            if (userId is null)
            {
                return BadRequest("not logged in");
            }
            _cartManager.DeleteProductFromCart(userId,ProductId);

            return Ok("Product deleted");
        }
        [Authorize]
        [HttpPut]
        [Route("updateProduct")]
        public ActionResult PutProduct(EditToCartDto editProduct)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            if (userId is null)
            {
                return BadRequest("not logged in");
            }
            editProduct.UserId = userId;
            _cartManager.UpdateProductInCart(editProduct);
            return Ok("product updated");
        }


    }
}
