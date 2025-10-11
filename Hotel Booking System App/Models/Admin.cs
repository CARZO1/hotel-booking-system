using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models
{
    public class Admin
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Admin(string email, string name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
        }
    }
}
