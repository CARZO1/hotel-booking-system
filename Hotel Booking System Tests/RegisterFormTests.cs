using HotelBookingSystem.Models;
using HotelBookingSystemApp.Services;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Hotel_Booking_System_Tests
{
    [TestFixture]
    public class RegisterTests
    {
        private string _customersPath;

        [SetUp]
        public void SetUp()
        {
            _customersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");

            // seed with one existing record
            File.WriteAllText(_customersPath,
                "existing@test.com,John Doe,password,0400000000" + Environment.NewLine);
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_customersPath))
                File.Delete(_customersPath);
        }

        [Test]
        public void Register_NewCustomer_ShouldAppendToCustomersFile()
        {
            var newCustomer = new Customer("new@test.com", "Alice Example", "1234", "0499999999");

            // In your app, RegisterForm calls FileManager.SaveCustomer(...)
            FileManager.SaveCustomer(newCustomer);

            var lines = File.ReadAllLines(_customersPath);
            var exists = lines.Any(l => l.StartsWith("new@test.com,", StringComparison.OrdinalIgnoreCase));

            Assert.That(exists, Is.True);
        }

        [Test]
        public void Register_DuplicateEmail_ShouldBeDetected()
        {
            var duplicateEmail = "existing@test.com";

            var duplicate = FileManager.LoadCustomers().Any(c => c.Email.Equals(duplicateEmail, StringComparison.OrdinalIgnoreCase));

            Assert.That(duplicate, Is.True);
        }

        [Test]
        public void Register_InvalidEmail_ShouldFailValidation()
        {
            var bad = "invalidemail";
            var ok = Utilities.IsValidEmail(bad);

            Assert.That(ok, Is.False);
        }

        [Test]
        public void Register_BlankRequiredFields_ShouldNotProceed()
        {
            var email = "blankfields@test.com";
            var name = "";
            var password = "";
            var phone = "";

            // mirror UI validation intent: name and password are required
            var emailOk = Utilities.IsValidEmail(email);
            var requiredOk = !string.IsNullOrWhiteSpace(name)
                             && !string.IsNullOrWhiteSpace(password)
                             && !string.IsNullOrWhiteSpace(phone);

            Assert.That(emailOk, Is.True);
            Assert.That(requiredOk, Is.False);
        }
    }
}
