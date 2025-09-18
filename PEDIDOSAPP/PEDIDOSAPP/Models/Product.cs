using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PEDIDOSAPP.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser positivo.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock no puede ser negativo.")]
        public int Stock { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
