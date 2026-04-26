using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gallery.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public Cover Cover { get; set; } = null!;
        public ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
