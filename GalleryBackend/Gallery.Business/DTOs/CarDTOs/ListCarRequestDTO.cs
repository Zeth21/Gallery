namespace Gallery.Business.DTOs.CarDTOs
{
    public class ListCarRequestDTO
    {
        public string? Model { get; set; }
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public int? BrandId { get; set; }
    }
}
