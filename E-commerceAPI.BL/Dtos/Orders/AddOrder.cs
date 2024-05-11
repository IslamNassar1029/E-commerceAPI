using E_commerceAPI.DAL.Data.Models;
using E_commerceAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerceAPI.BL.Dtos.OrderProducts;

namespace E_commerceAPI.BL.Dtos.Orders
{
    public class AddOrder
    {
        //public DateTime CreationOrderDate { get; set; } = DateTime.Now;
        //public DateTime? DeliverdDate { get; set; } = null;
        //public decimal TotelPrice { get; set; }
        //public OrderStatus OrderStatus { get; set; }=OrderStatus.Processing;
        public IEnumerable<OrderProductList> OrderProducts { get; set; } = [];

        //public string? UserId { get; set; } = string.Empty;
       
    }
}
