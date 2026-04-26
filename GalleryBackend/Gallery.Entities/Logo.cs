using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Entities
{
    public class Logo
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Url { get; set; } = "default.png";
        public Brand Brand { get; set; } = null!;
    }
}
