using HotelBookingSystemApp.Models;
using HotelBookingSystemApp.Services;
using System;
using System.Windows.Forms;
using System.IO;

namespace HotelBookingSystem.Forms
{
    public partial class BookingConfirmationForm : Form
    {
        private readonly Room selectedRoom;

        public BookingConfirmationForm(Room room)
        {
            InitializeComponent();
            selectedRoom = room;
            this.Load += BookingConfirmationForm_Load;   // fixed name
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
            int nights = Math.Max(1, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
            decimal total = nights * selectedRoom.RatePerNight;

            var booking = new Booking
            {
                RoomNumber = selectedRoom.Number,
                CustomerEmail = Session.CurrentUserEmail,
                CheckIn = dtpCheckIn.Value.Date,
                CheckOut = dtpCheckOut.Value.Date,
                TotalPrice = total
            };

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bookings.txt");
            File.AppendAllText(filePath, booking.ToFileString() + Environment.NewLine);

            MessageBox.Show(
                $"Booking confirmed for {booking.CustomerEmail}\n" +
                $"Room {selectedRoom.Number} from {booking.CheckIn:d} to {booking.CheckOut:d}\n" +
                $"Total: {booking.TotalPrice:C}",
                "Booking Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}
