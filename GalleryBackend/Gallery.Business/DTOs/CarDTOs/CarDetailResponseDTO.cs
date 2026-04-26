using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gallery.Business.DTOs.CarDTOs
{
    public class CarDetailResponseDTO
    {
        public int Id { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;


    }
}
