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
            tabAdmin = new TabControl();
            tabCustomers = new TabPage();
            btnRemoveCustomer = new Button();
            btnAddCustomer = new Button();
            lstCustomers = new ListBox();
            tabRooms = new TabPage();
            btnRemoveRoom = new Button();
            btnAddRoom = new Button();
            lstRooms = new ListBox();
            tabBookings = new TabPage();
            btnRemoveBooking = new Button();
            btnAddBooking = new Button();
            lstBookings = new ListBox();
            btnEditCustomer = new Button();
            tabAdmin.SuspendLayout();
            tabCustomers.SuspendLayout();
            tabRooms.SuspendLayout();
            tabBookings.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabCustomers);
            tabAdmin.Controls.Add(tabRooms);
            tabAdmin.Controls.Add(tabBookings);
            tabAdmin.Dock = DockStyle.Fill;
            tabAdmin.Location = new Point(0, 0);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(800, 450);
            tabAdmin.TabIndex = 0;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(btnEditCustomer);
            tabCustomers.Controls.Add(btnRemoveCustomer);
            tabCustomers.Controls.Add(btnAddCustomer);
            tabCustomers.Controls.Add(lstCustomers);
            tabCustomers.Location = new Point(4, 24);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(792, 422);
            tabCustomers.TabIndex = 0;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveCustomer.Location = new Point(661, 374);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(120, 30);
            btnRemoveCustomer.TabIndex = 2;
            btnRemoveCustomer.Text = "Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCustomer.Location = new Point(535, 374);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(120, 30);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lstCustomers
            // 
            lstCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(6, 6);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(775, 364);
            lstCustomers.TabIndex = 0;
            // 
            // tabRooms
            // 
            tabRooms.Controls.Add(btnRemoveRoom);
            tabRooms.Controls.Add(btnAddRoom);
            tabRooms.Controls.Add(lstRooms);
            tabRooms.Location = new Point(4, 24);
            tabRooms.Name = "tabRooms";
            tabRooms.Padding = new Padding(3);
            tabRooms.Size = new Size(792, 422);
            tabRooms.TabIndex = 1;
            tabRooms.Text = "Rooms";
            tabRooms.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveRoom.Location = new Point(661, 374);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(120, 30);
            btnRemoveRoom.TabIndex = 2;
            btnRemoveRoom.Text = "Remove Room";
            btnRemoveRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddRoom.Location = new Point(535, 374);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(120, 30);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // lstRooms
            // 
            lstRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRooms.FormattingEnabled = true;
            lstRooms.ItemHeight = 15;
            lstRooms.Location = new Point(6, 6);
            lstRooms.Name = "lstRooms";
            lstRooms.Size = new Size(775, 364);
            lstRooms.TabIndex = 0;
            // 
            // tabBookings
            // 
            tabBookings.Controls.Add(btnRemoveBooking);
            tabBookings.Controls.Add(btnAddBooking);
            tabBookings.Controls.Add(lstBookings);
            tabBookings.Location = new Point(4, 24);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(792, 422);
            tabBookings.TabIndex = 2;
            tabBookings.Text = "Bookings";
            tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBooking
            // 
            btnRemoveBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveBooking.Location = new Point(661, 374);
            btnRemoveBooking.Name = "btnRemoveBooking";
            btnRemoveBooking.Size = new Size(120, 30);
            btnRemoveBooking.TabIndex = 2;
            btnRemoveBooking.Text = "Remove Booking";
            btnRemoveBooking.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddBooking.Location = new Point(535, 374);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(120, 30);
            btnAddBooking.TabIndex = 1;
            btnAddBooking.Text = "Add Booking";
            btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // lstBookings
            // 
            lstBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstBookings.FormattingEnabled = true;
            lstBookings.ItemHeight = 15;
            lstBookings.Location = new Point(6, 6);
            lstBookings.Name = "lstBookings";
            lstBookings.Size = new Size(775, 364);
            lstBookings.TabIndex = 0;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(416, 374);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(113, 30);
            btnEditCustomer.TabIndex = 3;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            tabAdmin.ResumeLayout(false);
            tabCustomers.ResumeLayout(false);
            tabRooms.ResumeLayout(false);
            tabBookings.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnEditCustomer;
    }
}
