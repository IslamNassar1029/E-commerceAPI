using E_commerceAPI.BL.Dtos.Carts;
using E_commerceAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Carts
{
    public class CartManager : ICartManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddProductToCart(AddToCartDto addToCart)
        {
            var cart = new Cart()
            {
                ProductId = addToCart.ProductId,
                UserId = addToCart.UserId,
                Quantity = addToCart.Quantity,
            };  

            _unitOfWork.CartRepository.Add(cart);
            _unitOfWork.SaveChanges();
        }

        public void DeleteProductFromCart(string userId, int productId)
        {
            var productToDelete = _unitOfWork.CartRepository.GetByUserIdAndProductId(userId, productId);
            if (productToDelete is null)
            {
                return;
            }
            _unitOfWork.CartRepository.Delete(productToDelete);
            _unitOfWork.SaveChanges();
        }

        public void UpdateProductInCart(EditToCartDto editProduct)
        {
            var productToEdit = _unitOfWork.CartRepository.GetByUserIdAndProductId(editProduct.UserId, editProduct.ProductId);
            if (productToEdit is null)
            {
                return;
            }
            productToEdit.Quantity = editProduct.Quantity;
            _unitOfWork.CartRepository.Update(productToEdit);
            _unitOfWork.SaveChanges();
        }
    }
}
