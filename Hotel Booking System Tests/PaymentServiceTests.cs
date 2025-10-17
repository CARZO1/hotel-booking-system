using HotelBookingSystem.Services;
using HotelBookingSystemApp.Services;
using NUnit.Framework;

namespace Hotel_Booking_System_Tests
{
    [TestFixture]
    public class PaymentServiceTests
    {
        [Test]
        public void ValidateCard_WithValidDetails_ShouldPass()
        {
            var result = PaymentService.ValidateCard("Alice Example", "4111111111111111", "12/30", "123");
            Assert.That(result, Is.True);
        }

        [Test]
        public void ValidateCard_WithInvalidCardNumber_ShouldFail()
        {
            var result = PaymentService.ValidateCard("Bob Example", "123", "12/30", "123");
            Assert.That(result, Is.False);
        }

        [Test]
        public void ValidateCard_WithExpiredDate_ShouldFail()
        {
            var result = PaymentService.ValidateCard("Bob Example", "4111111111111111", "01/20", "123");
            Assert.That(result, Is.False);
        }

        [Test]
        public void ValidateCard_WithWrongCVV_ShouldFail()
        {
            var result = PaymentService.ValidateCard("Charlie Example", "4111111111111111", "12/30", "12");
            Assert.That(result, Is.False);
        }
    }
}
