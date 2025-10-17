using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Hotel_Booking_System_Tests
{
    [TestFixture]
    public class BookingTests
    {
        private string _bookingsPath;

        [SetUp]
        public void SetUp()
        {
            _bookingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bookings.txt");

            // Clean file for every test
            if (File.Exists(_bookingsPath))
                File.Delete(_bookingsPath);
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_bookingsPath))
                File.Delete(_bookingsPath);
        }

        [Test]
        public void MakeBooking_NewBooking_ShouldSaveToFile()
        {
            var email = "user@test.com";
            var roomNumber = "101";
            var checkIn = DateTime.Today;
            var checkOut = DateTime.Today.AddDays(2);

            var success = BookingService.MakeBooking(email, roomNumber, checkIn, checkOut, 100m);

            Assert.That(success, Is.True);

            var lines = File.ReadAllLines(_bookingsPath);
            Assert.That(lines.Length, Is.EqualTo(1));
            Assert.That(lines[0], Does.Contain(email));
        }

        [Test]
        public void MakeBooking_OverlappingDates_ShouldFail()
        {
            var email = "user@test.com";
            var roomNumber = "101";
            var checkIn = DateTime.Today;
            var checkOut = DateTime.Today.AddDays(3);

            // first booking
            BookingService.MakeBooking(email, roomNumber, checkIn, checkOut, 100m);

            // attempt overlapping booking
            var result = BookingService.MakeBooking("other@test.com", roomNumber, checkIn.AddDays(1), checkOut.AddDays(1), 100m);

            Assert.That(result, Is.False);
        }

        [Test]
        public void CancelBooking_ExistingBooking_ShouldMarkAsCancelled()
        {
            var email = "user@test.com";
            var roomNumber = "101";
            var checkIn = DateTime.Today;
            var checkOut = DateTime.Today.AddDays(2);

            BookingService.MakeBooking(email, roomNumber, checkIn, checkOut, 100m);
            var booking = BookingService.GetBookingsForCustomer(email).First();

            var cancelled = BookingService.CancelBooking(booking.BookingId);

            Assert.That(cancelled, Is.True);

            var reloaded = BookingService.GetBookingsForCustomer(email).First();
            Assert.That(reloaded.IsCancelled, Is.True);
        }

        [Test]
        public void GetBookingsForCustomer_ShouldReturnCorrectRecords()
        {
            var email = "me@test.com";
            BookingService.MakeBooking(email, "101", DateTime.Today, DateTime.Today.AddDays(1), 100m);
            BookingService.MakeBooking("someoneelse@test.com", "102", DateTime.Today, DateTime.Today.AddDays(1), 200m);

            var myBookings = BookingService.GetBookingsForCustomer(email);

            Assert.That(myBookings.Count, Is.EqualTo(1));
            Assert.That(myBookings[0].CustomerEmail, Is.EqualTo(email));
        }
    }
}
