﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceAPI.BL.Dtos.Products
{
    public class EditProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ProductImageURL { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public int CategoryId { get; set; }

    }
}
