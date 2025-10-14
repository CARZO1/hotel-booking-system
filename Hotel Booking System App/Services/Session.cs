using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Services
{
    public static class Session
    {
        public static string CurrentUserEmail { get; set; } = string.Empty;
        public static string CurrentUserName { get; set; } = string.Empty;
        public static string CurrentUserPhone { get; set; } = string.Empty;
        public static bool IsAdmin { get; set; } = false;

        public static void Clear()
        {
            CurrentUserEmail = string.Empty;
            CurrentUserName = string.Empty;
            CurrentUserPhone = string.Empty;
            IsAdmin = false;
        }
    }
}
