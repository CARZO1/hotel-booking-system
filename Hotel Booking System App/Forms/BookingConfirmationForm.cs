using HotelBookingSystem.Models;
using HotelBookingSystem.Services;
using HotelBookingSystemApp.Services;
using System;
using System.IO;
using System.Windows.Forms;


namespace HotelBookingSystem.Forms
{
    public partial class BookingConfirmationForm : Form
    {
        private readonly Room selectedRoom;


        public BookingConfirmationForm(Room room)
        {
            InitializeComponent();
            selectedRoom = room;
            this.Load += BookingConfirmationForm_Load;
        }


        private void BookingConfirmationForm_Load(object? sender, EventArgs e)
        {
            this.Text = "Booking Confirmation";
            lblRoomDetails.Text = selectedRoom.ToString();


            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
            UpdateTotalPrice();


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
            if (selectedRoom == null)
            {
                MessageBox.Show("No room selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(Session.CurrentUserEmail))
            {
                MessageBox.Show("You must be logged in to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Updated to include cardName param
            if (!PaymentService.ValidateCard(txtCardName.Text, txtCardNumber.Text, txtExpiry.Text, txtCVV.Text))
            {
                MessageBox.Show("Invalid payment details. Please check and try again.",
                "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int nights = Math.Max(1, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
            decimal total = nights * selectedRoom.RatePerNight;


            // Save booking directly through BookingService
            var booking = new Booking
            {
                RoomNumber = selectedRoom.Number,
                CustomerEmail = Session.CurrentUserEmail,
                CheckIn = dtpCheckIn.Value.Date,
                CheckOut = dtpCheckOut.Value.Date,
                TotalPrice = total
            };


            bool ok = BookingService.MakeBooking(
            booking.CustomerEmail,
            booking.RoomNumber,
            booking.CheckIn,
            booking.CheckOut,
            selectedRoom.RatePerNight
            );


            if (!ok)
            {
                MessageBox.Show("This room is already booked for the selected dates.",
                "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // Safe reference generation
            string shortRef = booking.BookingId.Substring(0, Math.Min(8, booking.BookingId.Length)).ToUpper();


            MessageBox.Show(
            $"Booking confirmed for {booking.CustomerEmail}\n" +
            $"Room {selectedRoom.Number} from {booking.CheckIn:d} to {booking.CheckOut:d}\n" +
            $"Total: {booking.TotalPrice:C}\n\n" +
            $"Reference: {shortRef}",
            "Booking Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );


            this.Close();
        }
    }
}