using PEDIDOSAPP.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PEDIDOSAPP.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }      // FK a ApplicationUser.Id
        public ApplicationUser User { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Required, StringLength(50)]
        public string Status { get; set; } = "Pendiente";

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
