namespace DriveShare.Frontend.Models;

public class CarListing
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public string Location { get; set; }
    public decimal PricePerDay { get; set; }
    public string Availability { get; set; }
    public string PickUpLocation { get; set; }
    public CarStatus Status { get; set; }
    public DateTime? ReservedStartDate { get; set; }
    public DateTime? ReservedEndDate { get; set; }
    public BNUser Seller { get; set; }

    public enum CarStatus
    {
        Available,
        Booked,
        Unavailable
    }

    public class Builder
    {
        private string model;
        private int year;
        private int mileage;
        private string location;
        private decimal pricePerDay;
        private string availability;
        private string pickUpLocation;
        private BNUser seller;

        public Builder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public Builder SetYear(int year)
        {
            this.year = year;
            return this;
        }

        public Builder SetMileage(int mileage)
        {
            this.mileage = mileage;
            return this;
        }

        public Builder SetLocation(string location)
        {
            this.location = location;
            return this;
        }

        public Builder SetPricePerDay(decimal pricePerDay)
        {
            this.pricePerDay = pricePerDay;
            return this;
        }

        public Builder SetAvailability(string availability)
        {
            this.availability = availability;
            return this;
        }

        public Builder SetPickUpLocation(string pickUpLocation)
        {
            this.pickUpLocation = pickUpLocation;
            return this;
        }

        public Builder SetSeller(BNUser seller)
        {
            this.seller = seller;
            return this;
        }

        public CarListing Build()
        {
            return new CarListing
            {
                Model = this.model,
                Year = this.year,
                Mileage = this.mileage,
                Location = this.location,
                PricePerDay = this.pricePerDay,
                Availability = this.availability,
                PickUpLocation = this.pickUpLocation,
                Seller = this.seller
            };
        }
    }
}