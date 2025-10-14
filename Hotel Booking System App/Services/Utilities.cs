using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelBookingSystem.Services
{
    public static class Utilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static void TogglePasswordVisibility(TextBox passwordBox, bool visible)
        {
            passwordBox.UseSystemPasswordChar = !visible;
        }

        public static decimal CalculateTotalPrice(decimal nightlyRate, DateTime checkIn, DateTime checkOut)
        {
            int nights = (checkOut.Date - checkIn.Date).Days;
            return nightlyRate * nights;
        }
    }
}
