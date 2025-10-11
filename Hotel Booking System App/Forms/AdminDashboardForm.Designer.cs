namespace HotelBookingSystem.Forms
{
    partial class AdminDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnRemoveBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.tabAdmin.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabCustomers);
            this.tabAdmin.Controls.Add(this.tabRooms);
            this.tabAdmin.Controls.Add(this.tabBookings);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(800, 450);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.btnRemoveCustomer);
            this.tabCustomers.Controls.Add(this.btnAddCustomer);
            this.tabCustomers.Controls.Add(this.lstCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 24);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(792, 422);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveCustomer.Location = new System.Drawing.Point(661, 374);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveCustomer.TabIndex = 2;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.Location = new System.Drawing.Point(535, 374);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 15;
            this.lstCustomers.Location = new System.Drawing.Point(6, 6);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(775, 364);
            this.lstCustomers.TabIndex = 0;
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.btnRemoveRoom);
            this.tabRooms.Controls.Add(this.btnAddRoom);
            this.tabRooms.Controls.Add(this.lstRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 24);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(792, 422);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Rooms";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveRoom.Location = new System.Drawing.Point(661, 374);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveRoom.TabIndex = 2;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.Location = new System.Drawing.Point(535, 374);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 30);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // lstRooms
            // 
            this.lstRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 15;
            this.lstRooms.Location = new System.Drawing.Point(6, 6);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(775, 364);
            this.lstRooms.TabIndex = 0;
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.btnRemoveBooking);
            this.tabBookings.Controls.Add(this.btnAddBooking);
            this.tabBookings.Controls.Add(this.lstBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 24);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(792, 422);
            this.tabBookings.TabIndex = 2;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBooking
            // 
            this.btnRemoveBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBooking.Location = new System.Drawing.Point(661, 374);
            this.btnRemoveBooking.Name = "btnRemoveBooking";
            this.btnRemoveBooking.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveBooking.TabIndex = 2;
            this.btnRemoveBooking.Text = "Remove Booking";
            this.btnRemoveBooking.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBooking.Location = new System.Drawing.Point(535, 374);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(120, 30);
            this.btnAddBooking.TabIndex = 1;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // lstBookings
            // 
            this.lstBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.ItemHeight = 15;
            this.lstBookings.Location = new System.Drawing.Point(6, 6);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(775, 364);
            this.lstBookings.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.tabAdmin.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabRooms.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Button btnRemoveBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.ListBox lstBookings;
    }
}
