using E_commerceAPI.BL.Dtos.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Carts
{
    public interface ICartManager
    {
        void AddProductToCart(AddToCartDto addToCart);
        void DeleteProductFromCart(string userId, int productId);
        void UpdateProductInCart(EditToCartDto editProduct);
    }
}
