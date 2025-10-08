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

        private void InitializeComponent()
        {
            this.btnBook = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 15);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Customer Dashboard";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(20, 60);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 30);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Make a Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CustomerDashboardForm";
            this.Text = "Customer Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnBook;
        private Label lblWelcome;
    }
}
