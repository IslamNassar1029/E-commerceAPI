using E_commerceAPI.BL.Dtos.OrderProducts;
using E_commerceAPI.BL.Dtos.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Managers.Orders
{
    public interface IOrderManager
    {
        void AddOrder(List<OrderProductListDTO> orderProductLists, string userId);
        IEnumerable<ReadOrderHistoryDTO> GetOrderSHistory();
    }
}
