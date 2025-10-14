using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using HotelBookingSystem.Services;
using HotelBookingSystem.Models;

namespace Hotel_Booking_System_Tests
{
    [TestFixture]
    public class LoginTests
    {
        private string _customersPath;

        [SetUp]
        public void SetUp()
        {
            // the app builds file paths from AppDomain.CurrentDomain.BaseDirectory,so we write our test data file into that directory
            _customersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");

            // fresh file for each test run
            File.WriteAllText(_customersPath,
                "user@example.com,John Doe,pass123,0412345678" + Environment.NewLine);
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_customersPath))
                File.Delete(_customersPath);
        }

        [Test]
        public void AdminLogin_WithHotelDomainAndCorrectPassword_ShouldPass()
        {
            var email = "manager@hotel.local";
            var password = "admin123";

            // mirrors the simple rule used in Login form for Admins
            var isAdmin = email.EndsWith("@hotel.local", StringComparison.OrdinalIgnoreCase)
                          && password == "admin123";

            Assert.That(isAdmin, Is.True);
        }

        [Test]
        public void AdminLogin_WithIncorrectPassword_ShouldFail()
        {
            var email = "manager@hotel.local";
            var password = "wrongpass";

            var isAdmin = email.EndsWith("@hotel.local", StringComparison.OrdinalIgnoreCase)
                          && password == "admin123";

            Assert.That(isAdmin, Is.False);
        }

        [Test]
        public void EmailValidation_InvalidEmail_ShouldFail()
        {
            var invalid = "no-at-symbol.com";
            var valid = Utilities.IsValidEmail(invalid);

            Assert.That(valid, Is.False);
        }

        [Test]
        public void EmailValidation_ValidEmail_ShouldPass()
        {
            var good = "hello@test.com";
            var valid = Utilities.IsValidEmail(good);

            Assert.That(valid, Is.True);
        }

        [Test]
        public void CustomerCredentials_KnownEmailAndPassword_ShouldBeFoundInFile()
        {
            // simulate what LoginForm does for customer flow
            var email = "user@example.com";
            var password = "pass123";

            var found = FileManager.LoadCustomers()
                                   .Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                                             && c.Password == password);

            Assert.That(found, Is.True);
        }
    }
}
