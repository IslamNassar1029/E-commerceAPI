using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Dtos.Orders
{
    public class ReadOrderHistory
    {
        public int Id { get; set; }
        public DateTime CreationOrderDate { get; set; }
        public decimal TotelPrice { get; set; }
    }
}
