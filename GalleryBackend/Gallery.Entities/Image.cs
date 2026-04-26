using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = "default.png";
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
