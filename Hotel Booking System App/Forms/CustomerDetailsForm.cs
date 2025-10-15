using HotelBookingSystem.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    public partial class CustomerDetailsForm : Form
    {
        private Label lblHeading = null!;
        private Label lblName = null!;
        private Label lblEmail = null!;
        private Label lblPhone = null!;
        private Button btnClose = null!;

        public CustomerDetailsForm()
        {
            InitializeComponent();
            this.Load += CustomerDetailsForm_Load;
        }

        private void CustomerDetailsForm_Load(object? sender, EventArgs e)
        {
            this.Text = "Customer Details";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Heading
            lblHeading = new Label();
            lblHeading.Text = "Your Profile Details";
            lblHeading.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(20, 20);
            this.Controls.Add(lblHeading);

            // Name
            lblName = new Label();
            lblName.Text = $"Name: {Session.CurrentUserName}";
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 80);
            this.Controls.Add(lblName);

            // Email
            lblEmail = new Label();
            lblEmail.Text = $"Email: {Session.CurrentUserEmail}";
            lblEmail.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 120);
            this.Controls.Add(lblEmail);

            // Phone
            lblPhone = new Label();
            lblPhone.Text = $"Phone: {Session.CurrentUserPhone}";
            lblPhone.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 160);
            this.Controls.Add(lblPhone);

            // Close button
            btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Size = new Size(100, 30);
            btnClose.Location = new Point(20, 210);
            btnClose.Click += (s, ev) => this.Close();
            this.Controls.Add(btnClose);
        }
    }
}
