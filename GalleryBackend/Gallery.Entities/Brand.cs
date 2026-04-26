using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Logo Logo { get; set; } = null!;
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
