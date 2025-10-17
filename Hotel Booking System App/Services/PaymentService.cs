using System;

namespace HotelBookingSystemApp.Services
{
    public static class PaymentService
    {
        // method to check if card details are valid
        public static bool ValidateCard(string cardName, string cardNumber, string expiry, string cvv)
        {
            // must have a name
            if (string.IsNullOrWhiteSpace(cardName)) return false;

            // card number must be 16 digits
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
                return false;

            // expiry must be in MM/yy format and not in the past
            if (string.IsNullOrWhiteSpace(expiry) || !DateTime.TryParseExact(expiry, "MM/yy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime expDate))
                return false;
            if (expDate < DateTime.Now.Date) return false;

            // cvv must be 3 digits
            if (string.IsNullOrWhiteSpace(cvv) || cvv.Length != 3 || !cvv.All(char.IsDigit))
                return false;

            // if everything passes return true
            return true;
        }
    }
}
