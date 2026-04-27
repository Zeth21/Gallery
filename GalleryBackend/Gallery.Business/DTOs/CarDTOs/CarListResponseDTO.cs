using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Gallery.Business.DTOs.CarDTOs
{
    public class CarListResponseDTO
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string CoverUrl { get; set; } = null!;
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public string BrandLogoUrl { get; set; } = null!;
    }
}
