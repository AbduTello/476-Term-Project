namespace DriveShare.Frontend.Models.DTOs
{
    public class CreateCarListingRequest
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Location { get; set; }
        public decimal PricePerDay { get; set; }
        public string Availability { get; set; }
        public string PickUpLocation { get; set; }
    }
}