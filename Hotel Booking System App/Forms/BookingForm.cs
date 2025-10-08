namespace HotelBookingSystem.Forms
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingFormLoad;
        }

        private void BookingFormLoad(object? sender, EventArgs e)
        {
            this.Text = "Booking Page";
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome to the Booking Page!";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblWelcome);
        }
    }
}
