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
        private readonly Room selectedRoom; // the room chosen on booking form

        public BookingConfirmationForm(Room room)
        {
            InitializeComponent();
            selectedRoom = room;
            this.Load += BookingConfirmationForm_Load; // load form events
        }

        private void BookingConfirmationForm_Load(object? sender, EventArgs e)
        {
            this.Text = "Booking Confirmation";
            lblRoomDetails.Text = selectedRoom.ToString(); // show room info

            // set default dates
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
            UpdateTotalPrice();

            // recalc total when dates change
            dtpCheckIn.ValueChanged += (_, __) => UpdateTotalPrice();
            dtpCheckOut.ValueChanged += (_, __) => UpdateTotalPrice();

            // confirm button event
            btnConfirm.Click += BtnConfirm_Click;
        }

        // works out price based on nights and updates label
        private void UpdateTotalPrice()
        {
            int nights = Math.Max(1, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
            decimal total = nights * selectedRoom.RatePerNight;
            lblTotal.Text = $"Total Price: {total:C} for {nights} night(s)";
        }

        // confirm booking button click
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

            // check payment details
            if (!PaymentService.ValidateCard(txtCardName.Text, txtCardNumber.Text, txtExpiry.Text, txtCVV.Text))
            {
                MessageBox.Show("Invalid payment details. Please check and try again.",
                "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // work out total again for booking save
            int nights = Math.Max(1, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
            decimal total = nights * selectedRoom.RatePerNight;

            // create booking object
            var booking = new Booking
            {
                RoomNumber = selectedRoom.Number,
                CustomerEmail = Session.CurrentUserEmail,
                CheckIn = dtpCheckIn.Value.Date,
                CheckOut = dtpCheckOut.Value.Date,
                TotalPrice = total
            };

            // save booking through service
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

            // generate shorter booking ref
            string shortRef = booking.BookingId.Substring(0, Math.Min(8, booking.BookingId.Length)).ToUpper();

            // show success message
            MessageBox.Show(
                $"Booking confirmed for {booking.CustomerEmail}\n" +
                $"Room {selectedRoom.Number} from {booking.CheckIn:d} to {booking.CheckOut:d}\n" +
                $"Total: {booking.TotalPrice:C}\n\n" +
                $"Reference: {shortRef}",
                "Booking Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close(); // close form after confirm
        }
    }
}
