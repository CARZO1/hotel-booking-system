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
            btnEditCustomer.Click += BtnEditCustomer_Click;
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

        private void BtnEditCustomer_Click(object? sender, EventArgs e)
        {
            // Try to prefill from the selected list item; if none, open blank (search state)
            string? selectedEmail = TryExtractSelectedEmail();

            using var dlg = selectedEmail is not null
                ? new EditCustomerForm(selectedEmail)  // prefill search box
                : new EditCustomerForm();              // admin can type an email

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                LoadCustomers(); // refresh after a successful save
                MessageBox.Show("Customer updated successfully.", "Saved");
            }
        }

        // Helper to parse "Name - email (phone)" from lstCustomers
        private string? TryExtractSelectedEmail()
        {
            if (lstCustomers.SelectedIndex < 0) return null;
            var text = lstCustomers.SelectedItem?.ToString() ?? "";
            try
            {
                // Expected format: "John Smith - john@example.com (0412 345 678)"
                var emailPart = text.Split('-')[1].Split('(')[0].Trim();
                return string.IsNullOrWhiteSpace(emailPart) ? null : emailPart;
            }
            catch
            {
                return null; // fallback if format changes
            }
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

