using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Dtos.Carts
{
    public class AddToCartDto
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; } = 0;
        public string UserId { get; set; } = string.Empty;
    }
}
