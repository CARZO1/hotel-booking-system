using System;
using System.IO;

namespace HotelBookingSystemApp.Services
{
    public static class GlobalServices
    {
        public static readonly string BookingFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bookings.txt");

        public static readonly string CustomerFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");
    }
}