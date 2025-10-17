namespace HotelBookingSystem.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        // cleanup resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        // this method builds the base form
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // BookingForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); // scaling for UI
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450); // size of window
            this.Name = "BookingForm";  // internal name
            this.Text = "Booking Page"; // text on window title bar
            this.ResumeLayout(false);
        }

        #endregion
    }
}
