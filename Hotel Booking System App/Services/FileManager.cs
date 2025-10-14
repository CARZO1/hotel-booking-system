using HotelBookingSystem.Models;
using HotelBookingSystemApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HotelBookingSystemApp.Services
{
    public static class FileManager
    {
        private static readonly string filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");

        private static readonly string adminsPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "admins.txt");

        private static readonly string bookingsPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bookings.txt");

        public static List<Customer> LoadCustomers()
        {
            List<Customer> customers = new();

            if (!File.Exists(filePath))
                return customers;

            foreach (string line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    string email = parts[0].Trim();
                    string name = parts[1].Trim();
                    string password = parts[2].Trim();
                    string phone = parts[3].Trim();
                    customers.Add(new Customer(email, name, password, phone));
                }
            }

            return customers;
        }

        // saves a new customer by appending to the file
        public static void SaveCustomer(Customer c) 
        {
            string line = $"{c.Email},{c.Name},{c.Password},{c.Phone}";
            File.AppendAllLines(filePath, new[] { line });
        }

        public static Customer? FindCustomer(string email, string password)
        {
            return LoadCustomers().FirstOrDefault(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                c.Password == password);
        }

        // Load all customers and check if the email already exists (case-insensitive)
        public static bool EmailExists(string email)
        {
            return LoadCustomers()
                .Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public static Customer? FindCustomerByEmail(string email) =>
            LoadCustomers().FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        // Update by “old key e-mail”; overwrite file atomically
        public static bool UpdateCustomer(string originalEmail, Customer updated)
        {
            var customers = LoadCustomers();
            var idx = customers.FindIndex(c => c.Email.Equals(originalEmail, StringComparison.OrdinalIgnoreCase));
            if (idx < 0) return false;

            customers[idx] = updated;

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");
            File.WriteAllLines(path, customers.Select(c => $"{c.Email},{c.Name},{c.Password},{c.Phone}"));
            return true;
        }

        public static List<Admin> LoadAdmins()
        {
            List<Admin> admins = new();

            if (!File.Exists(adminsPath))
                return admins;

            foreach (string line in File.ReadAllLines(adminsPath))
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string email = parts[0].Trim();
                    string name = parts[1].Trim();
                    string password = parts[2].Trim();
                    admins.Add(new Admin(email, name, password));
                }
            }

            return admins;
        }

        public static Admin? FindAdmin(string email, string password)
        {
            return LoadAdmins().FirstOrDefault(a =>
                a.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                a.Password == password);
        }

        public static List<Booking> LoadBookings()
        {
            if (!File.Exists(bookingsPath)) return new List<Booking>();
            return File.ReadAllLines(bookingsPath)
                       .Where(line => !string.IsNullOrWhiteSpace(line))
                       .Select(Booking.FromFileString)   // uses your parser
                       .ToList();
        }

        public static bool RemoveBookingById(string bookingId)
        {
            var all = LoadBookings();
            int before = all.Count;
            all.RemoveAll(b => string.Equals(b.BookingId, bookingId, StringComparison.OrdinalIgnoreCase));
            if (all.Count == before) return false;

            File.WriteAllLines(bookingsPath, all.Select(b => b.ToFileString()));
            return true;
        }
    }
}
