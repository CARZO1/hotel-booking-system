using System;
using System.Collections.Generic;
using System.Linq;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Services
{
    // Service to manage bookings
    // NOTE: right now this is in memory only, no file/db
    internal class BookingService
    {
        // list to store bookings temporarily
        private List<Booking> bookings = new List<Booking>();

        // create a booking if no conflicts
        public bool MakeBooking(string customerEmail, string roomNumber, DateTime checkIn, DateTime checkOut, decimal nightlyRate)
        {
            // Check if any existing booking overlaps
            bool hasConflict = bookings.Any(b =>
                b.RoomNumber == roomNumber &&
                !b.IsCancelled &&
                b.CheckIn < checkOut &&
                b.CheckOut > checkIn
            );

            if (hasConflict)
            {
                return false; // conflict found, booking not created
            }

            // Create a new booking object
            var newBooking = new Booking
            {
                BookingId = Guid.NewGuid().ToString(),
                CustomerEmail = customerEmail,
                RoomNumber = roomNumber,
                CheckIn = checkIn,
                CheckOut = checkOut,
                TotalPrice = nightlyRate * Math.Max(1, (checkOut - checkIn).Days),
                IsCancelled = false
            };

            // Add to the in-memory list
            bookings.Add(newBooking);
            return true;
        }

        // cancel booking by id
        public bool CancelBooking(string bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                booking.IsCancelled = true;
                return true;
            }
            return false;
        }

        // get all bookings for a room 
        public List<Booking> GetBookingsForRoom(string roomNumber)
        {
            return bookings
                .Where(b => b.RoomNumber == roomNumber)
                .ToList();
        }

        // get all bookings for a customer (useful for "My Bookings" page)
        public List<Booking> GetBookingsForCustomer(string customerEmail)
        {
            return bookings
                .Where(b => b.CustomerEmail == customerEmail)
                .ToList();
        }
    }
}
