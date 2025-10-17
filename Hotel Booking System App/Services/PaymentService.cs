using System;

namespace HotelBookingSystemApp.Services
{
    public static class PaymentService
    {
        public static bool ValidateCard(string cardName, string cardNumber, string expiry, string cvv)
        {
            if (string.IsNullOrWhiteSpace(cardName)) return false;

            // simple checks (student-level)
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
                return false;

            if (string.IsNullOrWhiteSpace(expiry) || !DateTime.TryParseExact(expiry, "MM/yy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime expDate))
                return false;
            if (expDate < DateTime.Now.Date) return false;

            if (string.IsNullOrWhiteSpace(cvv) || cvv.Length != 3 || !cvv.All(char.IsDigit))
                return false;

            return true;
        }
    }
}
