using System;

namespace HotelBookingSystem.Models
{
    public class Customer
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public Customer(string email, string name, string password, string phone)
        {
            Email = email;
            Name = name;
            Password = password;
            Phone = phone;
        }
    }
}
