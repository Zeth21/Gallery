using Microsoft.AspNetCore.Http;

namespace Gallery.Business.DTOs.CarDTOs
{
    public class CreateCarRequestDTO
    {
        public int BrandId { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }
        public required IFormFile Cover { get; set;  }
        public required ICollection<IFormFile> Images { get; set; }
    }
}
