using E_commerceAPI.BL.Dtos.OrderProducts;
using E_commerceAPI.BL.Dtos.Orders;
using E_commerceAPI.DAL;
using E_commerceAPI.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Orders
{
    public class OrderManager:IOrderManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddOrder(List<OrderProductListDTO> orderProductLists, string userId)
        {
            if (orderProductLists == null)
            {
                return;
            }
            var orderProductListWithPrice = orderProductLists.Select(p =>
            {
                var product = _unitOfWork.ProductRepository.GetById(p.ProductId);
                if (product != null)
                {
                    return new
                    {
                        p.ProductId,
                        p.ProductCount,
                        ProductPrice = product.Price
                    };
                }
                else
                {
                    throw new Exception($"Product with ID {p.ProductId} not found.");
                }
            });
            var totalPrice=orderProductListWithPrice
                           .Select(p=>p.ProductPrice*p.ProductCount)
                           .Sum();
            
            Order NewOrder = new Order()
            {
                UserId = userId,
                CreationOrderDate = DateTime.Now,
                DeliverdDate = DateTime.Now.AddDays(10),
                OrderStatus=OrderStatus.Pending,
                TotelPrice=totalPrice,
            };
            _unitOfWork.OrderRepository.Add(NewOrder);
            _unitOfWork.SaveChanges();  

           int orderId= _unitOfWork.OrderRepository.GetLastOrderId(userId);

            //orderProductListWithPrice.Select(p =>
            //_unitOfWork.OrderProductRepository.Add(new OrderProduct()
            //{
            //    OrderId=orderId,
            //    ProductId=p.ProductId,
            //    ProductCount=p.ProductCount,
            //    ProductPriceAtThisTime=p.ProductPrice,
            //})
            //);

            //foreach (var product in orderProductListWithPrice)
            //{
            //    _unitOfWork.OrderProductRepository.Add(new OrderProduct()
            //    {
            //        OrderId = orderId,
            //        ProductId = product.ProductId,
            //        ProductCount = product.ProductCount,
            //        ProductPriceAtThisTime = product.ProductPrice,
            //    });
            //}
            var orderProductsToAdd = orderProductListWithPrice.Select(p => new OrderProduct()
            {
                OrderId = orderId,
                ProductId = p.ProductId,
                ProductCount = p.ProductCount,
                ProductPriceAtThisTime = p.ProductPrice
            });

            _unitOfWork.OrderProductRepository.AddRange(orderProductsToAdd);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<ReadOrderHistoryDTO> GetOrderSHistory()
        {
            var orders = _unitOfWork.OrderRepository.GetAll();
            var ordersHistory = orders.Select(o => new ReadOrderHistoryDTO()
            {
                Id = o.Id,
                TotelPrice = o.TotelPrice,
                CreationOrderDate=o.CreationOrderDate,
            });

            return ordersHistory;   
        }
    }
}
