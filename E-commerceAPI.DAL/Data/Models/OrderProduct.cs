using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.DAL.Data.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }= 0;
        public int OrderId { get; set; }= 0;
        public int ProductCount { get; set; } = 0;
        public decimal ProductPriceAtThisTime { get; set; }
        public Product Product { get; set; } = null!;

        public Order    Order { get; set; }=null!;

    }
}
