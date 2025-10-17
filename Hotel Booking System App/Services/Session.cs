using System;

namespace HotelBookingSystem.Services
{
    // Session class tracks the currently logged-in user across the system.
    // This avoids having to pass Customer objects through every form.
    public static class Session
    {
        // Stores the logged-in customer email used as a key for bookings
        public static string CurrentUserEmail { get; set; } = string.Empty;

        // Stores the name of the logged-in user for UI display
        public static string CurrentUserName { get; set; } = string.Empty;

        // Stores the phone number for customer details
        public static string CurrentUserPhone { get; set; } = string.Empty;

        // Flag to indicate whether the current user is an Admin
        public static bool IsAdmin { get; set; } = false;


        // Clears session values when logging out
        // This resets the app to a clean state for the next login

        public static void Clear()
        {
            CurrentUserEmail = string.Empty;
            CurrentUserName = string.Empty;
            CurrentUserPhone = string.Empty;
            IsAdmin = false;
        }
    }
}
