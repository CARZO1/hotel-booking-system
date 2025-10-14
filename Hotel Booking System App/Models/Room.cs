using System;

namespace HotelBookingSystem.Models
{
    public class Room
    {
        public string RoomId { get; set; } = Guid.NewGuid().ToString();
        public string Number { get; set; } = "";       // e.g. "101"
        public string Type { get; set; } = "";         // e.g. "Standard", "Deluxe", "Suite"
        public int Beds { get; set; }                  // e.g. 1, 2
        public int Bathrooms { get; set; }             // e.g. 1, 2
        public decimal RatePerNight { get; set; }      // e.g. 120.50
        public bool IsAvailable { get; set; } = true;  // true if not booked

        public override string ToString()
        {
            return $"Room {Number} ({Type}) - {Beds} bed(s), {Bathrooms} bath(s) - ${RatePerNight}/night";
        }

        public static List<Room> GetRooms()
        {
            return new List<Room>
            {
                new Room { Number = "101", Type = "Standard", Beds = 1, Bathrooms = 1, RatePerNight = 120.00m },
                new Room { Number = "102", Type = "Deluxe", Beds = 2, Bathrooms = 1, RatePerNight = 180.00m },
                new Room { Number = "201", Type = "Suite", Beds = 2, Bathrooms = 2, RatePerNight = 250.00m },
                new Room { Number = "202", Type = "Standard", Beds = 1, Bathrooms = 1, RatePerNight = 115.00m },
                new Room { Number = "301", Type = "Executive Suite", Beds = 3, Bathrooms = 2, RatePerNight = 350.00m }
            };
        }
    }
}
