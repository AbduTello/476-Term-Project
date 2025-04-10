namespace DriveShare.Frontend.Models.DTOs
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }

        public long BookingId { get; set; }
    }
}