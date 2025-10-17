using HotelBookingSystem.Models;
using HotelBookingSystemApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HotelBookingSystem.Services
{
    public static class BookingService
    {
        // saves a booking to bookings.txt
        public static bool SaveBooking(Booking booking)
        {
            try
            {
                File.AppendAllText(GlobalServices.BookingFilePath, booking.ToFileString() + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                // show error if file save fails
                System.Windows.Forms.MessageBox.Show(
                $"Error saving booking: {ex.Message}",
                "File Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error
                );
                return false;
            }
        }

        // makes a new booking if no overlap with existing
        public static bool MakeBooking(string customerEmail, string roomNumber, DateTime checkIn, DateTime checkOut, decimal ratePerNight)
        {
            // load all existing bookings
            var existingBookings = File.Exists(GlobalServices.BookingFilePath)
            ? File.ReadAllLines(GlobalServices.BookingFilePath)
            .Select(line => Booking.FromFileString(line))
            .Where(b => b != null)
            .Cast<Booking>()
            .ToList()
            : new List<Booking>();

            // check if dates overlap with an existing booking
            bool overlap = existingBookings.Any(b =>
            b.RoomNumber == roomNumber &&
            ((checkIn < b.CheckOut) && (checkOut > b.CheckIn))
            );

            if (overlap)
                return false;

            // create new booking
            var booking = new Booking
            {
                RoomNumber = roomNumber,
                CustomerEmail = customerEmail,
                CheckIn = checkIn,
                CheckOut = checkOut,
                TotalPrice = (checkOut - checkIn).Days * ratePerNight
            };

            return SaveBooking(booking);
        }

        // gets all bookings for a specific customer
        public static List<Booking> GetBookingsForCustomer(string customerEmail)
        {
            return File.Exists(GlobalServices.BookingFilePath)
            ? File.ReadAllLines(GlobalServices.BookingFilePath)
            .Select(line => Booking.FromFileString(line))
            .Where(b => b != null && b.CustomerEmail == customerEmail)
            .Cast<Booking>()
            .ToList()
            : new List<Booking>();
        }

        // cancels a booking by id
        public static bool CancelBooking(string bookingId)
        {
            if (!File.Exists(GlobalServices.BookingFilePath)) return false;

            var all = File.ReadAllLines(GlobalServices.BookingFilePath)
            .Select(line => Booking.FromFileString(line))
            .Where(b => b != null)
            .Cast<Booking>()
            .ToList();

            var booking = all.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking == null || booking.IsCancelled) return false;

            // mark booking as cancelled
            booking.IsCancelled = true;

            // save back to file
            File.WriteAllLines(GlobalServices.BookingFilePath,
            all.Select(b => b.ToFileString()));

            return true;
        }
    }
}
