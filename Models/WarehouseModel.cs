using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Reformation.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public required ProductModel Product { get; set; }
        public required int Quantity { get; set; }
        [Range(1, 20)]
        public required int Size { get; set; }
        [MaxLength(64)]
        public required string Color { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}