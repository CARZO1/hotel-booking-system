using System;

namespace HotelBookingSystemApp.Models
{
    public class Customer
    {
        public string CustomerId { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public override string ToString()
        {
            return $"{FullName} ({Email})";
        }
    }
}
