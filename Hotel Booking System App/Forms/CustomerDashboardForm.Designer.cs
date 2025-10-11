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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 20);
            this.lblWelcome.Text = "Welcome!";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(20, 60);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 30);
            this.btnBook.Text = "Make a Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBook);
            this.Name = "CustomerDashboardForm";
            this.Text = "Customer Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
