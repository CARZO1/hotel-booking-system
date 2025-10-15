namespace HotelBookingSystem.Forms
{
    partial class CustomerDashboardForm
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

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBook;

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnBook = new Button();
            btnManageBooking = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(60, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(20, 60);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(120, 30);
            btnBook.TabIndex = 1;
            btnBook.Text = "Make a Booking";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnManageBooking
            // 
            btnManageBooking.Location = new Point(20, 96);
            btnManageBooking.Name = "btnManageBooking";
            btnManageBooking.Size = new Size(120, 30);
            btnManageBooking.TabIndex = 2;
            btnManageBooking.Text = "Manage Booking";
            btnManageBooking.UseVisualStyleBackColor = true;
            btnManageBooking.Click += btnManageBooking_Click;
            // 
            // CustomerDashboardForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(btnManageBooking);
            Controls.Add(lblWelcome);
            Controls.Add(btnBook);
            Name = "CustomerDashboardForm";
            Text = "Customer Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageBooking;
    }
}
