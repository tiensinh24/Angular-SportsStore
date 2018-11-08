﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.BindingTargets
{
    public class ProductData
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Price must be atleast 1")]
        public decimal Price { get; set; }

        public long Supplier { get; set; }

        public Product Product => new Product
        {
            Name = Name,
            Category = Category,
            Description = Description,
            Price = Price,
            Supplier = Supplier == 0 ? null : new Supplier { SupplierId = Supplier }
        };
    }
}
