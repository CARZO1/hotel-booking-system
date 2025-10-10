using System;
using System.Windows.Forms;
using HotelBookingSystemApp.Models;

namespace HotelBookingSystem.Forms
{
    public partial class BookingConfirmationForm : Form
    {
        private readonly Room selectedRoom;

        public BookingConfirmationForm(Room room)
        {
            InitializeComponent();
            selectedRoom = room;
            this.Load += BookingConfirmationForm_Load;   // <-- fixed name
        }

        private void BookingConfirmationForm_Load(object? sender, EventArgs e)
        {
            this.Text = "Booking Confirmation";

            // Show selected room details (your Room.ToString())
            lblRoomDetails.Text = selectedRoom.ToString();

            // Default dates
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);

            UpdateTotalPrice();

            // Recalculate when dates change
            dtpCheckIn.ValueChanged += (_, __) => UpdateTotalPrice();
            dtpCheckOut.ValueChanged += (_, __) => UpdateTotalPrice();
            btnConfirm.Click += BtnConfirm_Click;
        }

        private void UpdateTotalPrice()
        {
            int nights = Math.Max(1, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
            decimal total = nights * selectedRoom.RatePerNight;
            lblTotal.Text = $"Total Price: {total:C} for {nights} night(s)";
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                $"Booking confirmed for room {selectedRoom.Number}\n" +
                $"Check-in: {dtpCheckIn.Value:d}\n" +
                $"Check-out: {dtpCheckOut.Value:d}\n" +
                $"{lblTotal.Text}",
                "Booking Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}
