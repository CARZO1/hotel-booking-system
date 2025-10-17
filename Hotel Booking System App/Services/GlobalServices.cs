using System;
using System.IO;

namespace HotelBookingSystemApp.Services
{
    public static class GlobalServices
    {
        // file path where all bookings are saved
        public static readonly string BookingFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bookings.txt");

        // file path where all customers are saved
        public static readonly string CustomerFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");
    }
}
