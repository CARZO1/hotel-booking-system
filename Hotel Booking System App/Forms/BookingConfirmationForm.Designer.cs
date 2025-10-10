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

        private void InitializeComponent()
        {
            this.lblRoomDetails = new Label();
            this.dtpCheckIn = new DateTimePicker();
            this.dtpCheckOut = new DateTimePicker();
            this.lblTotal = new Label();
            this.btnConfirm = new Button();
            this.SuspendLayout();

            // lblRoomDetails
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Location = new Point(20, 20);
            this.lblRoomDetails.Size = new Size(300, 20);
            this.lblRoomDetails.Name = "lblRoomDetails";

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

            // btnConfirm
            this.btnConfirm.Location = new Point(20, 180);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new Size(120, 30);
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = true;

            // BookingConfirmationForm
            this.ClientSize = new Size(420, 240);
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirm);
            this.Name = "BookingConfirmationForm";
            this.Text = "Booking Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
