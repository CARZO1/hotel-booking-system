using System;

namespace HotelBookingSystemApp.Models;
public class Booking
{
    public string BookingId { get; set; } = Guid.NewGuid().ToString();
    public string RoomNumber { get; set; } = "";   // use Room.Number instead of GUID
    public string CustomerEmail { get; set; } = "";
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsCancelled { get; set; } = false;

    public int Nights => Math.Max(1, (CheckOut - CheckIn).Days);

    public string ToFileString()
    {
        return $"{BookingId}|{RoomNumber}|{CustomerEmail}|{CheckIn:O}|{CheckOut:O}|{TotalPrice}|{IsCancelled}";
    }

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

    public override string ToString()
    {
        return $"Booking {BookingId} | Room {RoomNumber} | Customer {CustomerEmail} " +
               $"({CheckIn:dd/MM/yyyy} - {CheckOut:dd/MM/yyyy}) | Total: {TotalPrice:C}";
    }
}
