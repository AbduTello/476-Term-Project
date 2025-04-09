namespace DriveShare.Frontend.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public CarListing Car { get; set; }
        public BNUser Renter { get; set; }
        public BNUser Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public BookingStatus Status { get; set; }

        public enum BookingStatus
        {
            Pending,
            Confirmed,
            Completed,
            Canceled
        }
    }
}
