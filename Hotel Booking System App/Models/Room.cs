using System;

namespace HotelBookingSystemApp.Models
{
    public class Room
    {
        public string RoomId { get; set; } = Guid.NewGuid().ToString();
        public string Number { get; set; } = "";      // e.g. "101"
        public string Type { get; set; } = "";        // e.g. "Standard", "Deluxe", "Suite"
        public decimal RatePerNight { get; set; }     // e.g. 120.50
        public bool IsAvailable { get; set; } = true; // true if not booked

        public override string ToString()
        {
            return $"Room {Number} ({Type}) - ${RatePerNight}/night";
        }
    }
}