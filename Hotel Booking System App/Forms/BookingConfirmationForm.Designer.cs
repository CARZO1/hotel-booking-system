using System.Drawing;
using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    partial class BookingConfirmationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // all ui controls for this form
        private Label lblRoomDetails;   // shows room info
        private DateTimePicker dtpCheckIn;   // pick check in date
        private DateTimePicker dtpCheckOut;  // pick check out date
        private Label lblTotal;         // shows total price
        private Button btnConfirm;      // confirm booking button
        private TextBox txtCardName;    // input cardholder name
        private TextBox txtCardNumber;  // input card number
        private TextBox txtExpiry;      // input expiry date
        private TextBox txtCVV;         // input cvv

        private void InitializeComponent()
        {
            this.lblRoomDetails = new Label();
            this.dtpCheckIn = new DateTimePicker();
            this.dtpCheckOut = new DateTimePicker();
            this.lblTotal = new Label();
            this.btnConfirm = new Button();
            this.txtCardName = new TextBox();
            this.txtCardNumber = new TextBox();
            this.txtExpiry = new TextBox();
            this.txtCVV = new TextBox();

            this.SuspendLayout();

            // lblRoomDetails - top label with room details
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Location = new Point(20, 20);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new Size(300, 20);
            this.lblRoomDetails.Text = "Room Details";

            // dtpCheckIn - calendar for check in
            this.dtpCheckIn.Location = new Point(20, 60);
            this.dtpCheckIn.Name = "dtpCheckIn";

            // dtpCheckOut - calendar for check out
            this.dtpCheckOut.Location = new Point(20, 100);
            this.dtpCheckOut.Name = "dtpCheckOut";

            // lblTotal - shows total cost
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new Point(20, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(120, 20);
            this.lblTotal.Text = "Total Price: $0.00";

            // txtCardName - enter name on card
            this.txtCardName.Location = new Point(20, 180);
            this.txtCardName.Width = 250;
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.PlaceholderText = "Cardholder Name";

            // txtCardNumber - enter card number
            this.txtCardNumber.Location = new Point(20, 220);
            this.txtCardNumber.Width = 250;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PlaceholderText = "Card Number (16 digits)";

            // txtExpiry - enter expiry date
            this.txtExpiry.Location = new Point(20, 260);
            this.txtExpiry.Width = 100;
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.PlaceholderText = "MM/YY";

            // txtCVV - enter cvv
            this.txtCVV.Location = new Point(140, 260);
            this.txtCVV.Width = 80;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PlaceholderText = "CVV";

            // btnConfirm - click to confirm booking
            this.btnConfirm.Location = new Point(20, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new Size(150, 35);
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;

            // BookingConfirmationForm - full form setup
            this.ClientSize = new Size(500, 380); // set size
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtExpiry);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.btnConfirm);
            this.Name = "BookingConfirmationForm";
            this.Text = "Booking Confirmation";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
