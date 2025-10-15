using System;
using System.Linq;
using System.Windows.Forms;
using HotelBookingSystem.Services;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Forms
{
    public partial class ManageBooking : Form
    {
        private readonly BookingService bookingService;

        internal ManageBooking()
        {
            InitializeComponent();
            bookingService = GlobalServices.BookingService; 

            lblUser.Text = $"Bookings for: {Session.CurrentUserEmail}";
            LoadBookings();

            btnRefresh.Click += (s, e) => LoadBookings();
            btnCancel.Click += BtnCancel_Click;
        }

        private void LoadBookings()
        {
            dgvBookings.DataSource = null;

            var bookings = bookingService.GetBookingsForCustomer(Session.CurrentUserEmail);
            var displayList = bookings.Select(b => new
            {
                b.BookingId,
                b.RoomNumber,
                CheckIn = b.CheckIn.ToString("dd/MM/yyyy"),
                CheckOut = b.CheckOut.ToString("dd/MM/yyyy"),
                b.TotalPrice,
                Status = b.IsCancelled ? "Cancelled" : "Active"
            }).ToList();

            dgvBookings.DataSource = displayList;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bookingId = dgvBookings.SelectedRows[0].Cells["BookingId"].Value.ToString();

            var confirm = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool result = bookingService.CancelBooking(bookingId);
                if (result)
                {
                    MessageBox.Show("Booking cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                }
                else
                {
                    MessageBox.Show("Failed to cancel booking. It may have already been cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
