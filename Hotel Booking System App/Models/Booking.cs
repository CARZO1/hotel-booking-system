using System;

namespace HotelBookingSystem.Models
{
    public class Booking
    {
        // unique id for each booking
        public string BookingId { get; set; } = Guid.NewGuid().ToString();

        // room number that was booked
        public string RoomNumber { get; set; } = "";   // comes from Room.Number

        // customer email for the booking
        public string CustomerEmail { get; set; } = "";

        // check in and check out dates
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // total price for stay
        public decimal TotalPrice { get; set; }

        // flag for cancelled bookings
        public bool IsCancelled { get; set; } = false;

        // how many nights the booking is for (at least 1)
        public int Nights => Math.Max(1, (CheckOut - CheckIn).Days);

        // convert booking to a line to save in file
        public string ToFileString()
        {
            return $"{BookingId}|{RoomNumber}|{CustomerEmail}|{CheckIn:O}|{CheckOut:O}|{TotalPrice}|{IsCancelled}";
        }

        // read booking back from file line
        public static Booking FromFileString(string line)
        {
            var parts = line.Split('|');
            return new Booking
            {
                BookingId = parts[0],
                RoomNumber = parts[1],
                CustomerEmail = parts[2],
                CheckIn = DateTime.Parse(parts[3]),
                CheckOut = DateTime.Parse(parts[4]),
                TotalPrice = decimal.Parse(parts[5]),
                IsCancelled = bool.Parse(parts[6])
            };
        }

        // display booking details nicely in list
        public override string ToString()
        {
            return $"Booking {BookingId} | Room {RoomNumber} | Customer {CustomerEmail} " +
                   $"({CheckIn:dd/MM/yyyy} - {CheckOut:dd/MM/yyyy}) | Total: {TotalPrice:C}";
        }
    }
}
