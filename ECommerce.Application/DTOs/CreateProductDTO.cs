using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs
{
    public class CreateProductDTO
    {
        [Required, MaxLength(200)]
        public string Name { get; set; } = null!;

        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be zero or more")]
        public int StockQuantity { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}

