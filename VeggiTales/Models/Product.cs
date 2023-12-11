﻿using System.ComponentModel.DataAnnotations;

namespace VeggiTales.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
        public string? Description { get; set; }

        public string? Photo { get; set; }

        // add reference to the parent Category
        public Category? Category { get; set; }

        // add child refs
        public List<CartItem>? CartItems { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
