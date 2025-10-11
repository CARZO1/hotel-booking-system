namespace HotelBookingSystemApp.Services
{
    public static class PaymentService
    {
        public static bool ValidateCard(string cardNumber, string expiry, string cvv)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
                return false;

            if (string.IsNullOrWhiteSpace(cvv) || (cvv.Length != 3 && cvv.Length != 4) || !cvv.All(char.IsDigit))
                return false;

            if (!DateTime.TryParseExact("01/" + expiry, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate))
                return false;

            if (expiryDate < DateTime.Now)
                return false;

            return true;
        }
    }
}
