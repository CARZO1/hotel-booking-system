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

        private Label lblRoomDetails;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Label lblTotal;
        private Button btnConfirm;
        private TextBox txtCardName;
        private TextBox txtCardNumber;
        private TextBox txtExpiry;
        private TextBox txtCVV;

        private void InitializeComponent()
        {
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // lblRoomDetails
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Location = new Point(20, 20);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new Size(300, 20);
            this.lblRoomDetails.Text = "Room Details";

            // dtpCheckIn
            this.dtpCheckIn.Location = new Point(20, 60);
            this.dtpCheckIn.Name = "dtpCheckIn";

            // dtpCheckOut
            this.dtpCheckOut.Location = new Point(20, 100);
            this.dtpCheckOut.Name = "dtpCheckOut";

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new Point(20, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(120, 20);
            this.lblTotal.Text = "Total Price: $0.00";

            // Cardholder Name
            this.txtCardName.Location = new Point(20, 180);
            this.txtCardName.Width = 250;
            this.txtCardName.PlaceholderText = "Cardholder Name";

            // Card Number
            this.txtCardNumber.Location = new Point(20, 220);
            this.txtCardNumber.Width = 250;
            this.txtCardNumber.PlaceholderText = "Card Number (16 digits)";

            // Expiry Date
            this.txtExpiry.Location = new Point(20, 260);
            this.txtExpiry.Width = 100;
            this.txtExpiry.PlaceholderText = "MM/YY";

            // CVV
            this.txtCVV.Location = new Point(140, 260);
            this.txtCVV.Width = 80;
            this.txtCVV.PlaceholderText = "CVV";

            // btnConfirm
            this.btnConfirm.Location = new Point(20, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new Size(150, 35);
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;

            // BookingConfirmationForm
            this.ClientSize = new Size(500, 380);  // bigger window to fit payment
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
