using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystemApp.Services;
using HotelBookingSystem.Models;
using System.IO;

namespace HotelBookingSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Admin Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Setup event handlers
            btnAddCustomer.Click += BtnAddCustomer_Click;
            btnRemoveCustomer.Click += BtnRemoveCustomer_Click;
            btnAddRoom.Click += BtnAddRoom_Click;
            btnRemoveRoom.Click += BtnRemoveRoom_Click;
            btnAddBooking.Click += BtnAddBooking_Click;
            btnRemoveBooking.Click += BtnRemoveBooking_Click;

            LoadCustomers();
        }

        // Customers
        private void LoadCustomers()
        {
            lstCustomers.Items.Clear();
            var customers = FileManager.LoadCustomers();
            foreach (var c in customers)
                lstCustomers.Items.Add($"{c.Name} - {c.Email} ({c.Phone})");
        }

        private void BtnAddCustomer_Click(object? sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.ShowDialog();
            LoadCustomers();
        }

        private void BtnRemoveCustomer_Click(object? sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer to remove.", "Notice");
                return;
            }

            var selected = lstCustomers.SelectedItem.ToString();
            var email = selected.Split('-')[1].Split('(')[0].Trim();

            var customers = FileManager.LoadCustomers();
            customers.RemoveAll(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            // overwrite file
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.txt");
            File.WriteAllLines(filePath, customers.ConvertAll(c =>
                $"{c.Email},{c.Name},{c.Password},{c.Phone}"));

            LoadCustomers();
            MessageBox.Show("Customer removed successfully.", "Success");
        }

        // Rooms
        private void BtnAddRoom_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Add Room functionality coming soon!");
        }

        private void BtnRemoveRoom_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Remove Room functionality coming soon!");
        }

        // Bookings
        private void BtnAddBooking_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Add Booking functionality coming soon!");
        }

        private void BtnRemoveBooking_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Remove Booking functionality coming soon!");
        }
    }
}

