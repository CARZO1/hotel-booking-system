using System;

namespace HotelBookingSystemApp.Models
{
    public class Booking
    {
        public string BookingId { get; set; } = Guid.NewGuid().ToString();
        public string RoomId { get; set; } = "";      // link to Room
        public string CustomerId { get; set; } = "";  // link to Customer
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsCancelled { get; set; } = false;

        public override string ToString()
        {
            return $"Booking {BookingId} - Room {RoomId} for Customer {CustomerId} " +
                   $"from {CheckIn:dd/MM/yyyy} to {CheckOut:dd/MM/yyyy} " +
                   (IsCancelled ? "[CANCELLED]" : "");
        }
    }
}
