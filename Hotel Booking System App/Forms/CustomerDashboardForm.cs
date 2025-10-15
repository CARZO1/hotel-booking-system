using HotelBookingSystem.Forms;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();

            // Use Session instead of needing a Customer object
            lblWelcome.Text = $"Welcome, {Session.CurrentUserName}!";

            btnBook.Click += BtnBook_Click;
        }

        private void BtnBook_Click(object? sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void btnManageBooking_Click(object sender, EventArgs e)
        {
            // Create a BookingService instance
            BookingService bookingService = new BookingService();

            // Open the ManageBooking form and pass the service
            ManageBooking manageBookingForm = new ManageBooking();
            manageBookingForm.Show();
        }
    }
}
