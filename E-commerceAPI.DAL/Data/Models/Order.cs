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
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
        public decimal TotelPrice { get; set; }


        public ICollection<Product> Products { get; set; } = new HashSet<Product>();



    }
}
