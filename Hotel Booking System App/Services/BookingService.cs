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
        public bool MakeBooking(string customerId, string roomId, DateTime checkIn, DateTime checkOut, decimal nightlyRate)
        {
            // TODO: check for overlaps here
            // TODO: if no conflict, create new booking and add to list
            return false; // temp return until implemented
        }

        // cancel booking by id
        public bool CancelBooking(string bookingId)
        {
            // TODO: look up booking by ID and mark as cancelled
            return false; // temp return until implemented
        }

        // get all bookings for a room 
        public List<Booking> GetBookingsForRoom(string roomId)
        {
            // TODO: filter bookings by room id
            return new List<Booking>(); // temp return
        }

        // get all bookings for a customer (useful for my bookings page)
        public List<Booking> GetBookingsForCustomer(string customerId)
        {
            // TODO: filter bookings by customer id
            return new List<Booking>(); // temp return
        }
    }
}
