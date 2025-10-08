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

            // Wire up button click
            btnBook.Click += BtnBook_Click;
        }

        private void BtnBook_Click(object? sender, EventArgs e)
        {
            // Navigate to booking form
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }
    }
}
