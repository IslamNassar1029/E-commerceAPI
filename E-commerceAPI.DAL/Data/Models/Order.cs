using E_commerceAPI.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationOrderDate { get; set; } = DateTime.Now;
        public DateTime? DeliverdDate { get; set; } = null;
        public decimal TotelPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string? UserId { get; set; } = string.Empty;
        public User? User { get; set; }

        public IEnumerable<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    }
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}
