using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E_commerceAPI.DAL
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime CreationDateTime{ get; set; }= DateTime.Now;
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public string UserId { get; set; }=string.Empty;

        public User User { get; set; } = null!;
    }
}
