using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    partial class AddRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            lblTitle = new Label();
            lblNumber = new Label();
            lblType = new Label();
            lblBeds = new Label();
            lblBathrooms = new Label();
            lblRate = new Label();
            lblAvailable = new Label();

            txtNumber = new TextBox();
            cmbType = new ComboBox();
            numBeds = new NumericUpDown();
            numBathrooms = new NumericUpDown();
            txtRate = new TextBox();
            chkAvailable = new CheckBox();

            btnSave = new Button();
            btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)numBeds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBathrooms).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Room";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(40, 70);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(54, 15);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(150, 67);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(150, 23);
            txtNumber.TabIndex = 2;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(40, 100);
            lblType.Name = "lblType";
            lblType.Size = new Size(34, 15);
            lblType.TabIndex = 3;
            lblType.Text = "Type:";
            // 
            // txtType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(150, 97);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(150, 23);
            cmbType.TabIndex = 4;
            cmbType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite", "Executive Suite" });
            cmbType.SelectedIndex = 0; // default
            // 
            // lblBeds
            // 
            lblBeds.AutoSize = true;
            lblBeds.Location = new Point(40, 130);
            lblBeds.Name = "lblBeds";
            lblBeds.Size = new Size(34, 15);
            lblBeds.TabIndex = 5;
            lblBeds.Text = "Beds:";
            // 
            // numBeds
            // 
            numBeds.Location = new Point(150, 127);
            numBeds.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBeds.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numBeds.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numBeds.Name = "numBeds";
            numBeds.Size = new Size(60, 23);
            numBeds.TabIndex = 6;
            // 
            // lblBathrooms
            // 
            lblBathrooms.AutoSize = true;
            lblBathrooms.Location = new Point(40, 160);
            lblBathrooms.Name = "lblBathrooms";
            lblBathrooms.Size = new Size(68, 15);
            lblBathrooms.TabIndex = 7;
            lblBathrooms.Text = "Bathrooms:";
            // 
            // numBathrooms
            // 
            numBathrooms.Location = new Point(150, 157);
            numBathrooms.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBathrooms.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numBathrooms.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numBathrooms.Name = "numBathrooms";
            numBathrooms.Size = new Size(60, 23);
            numBathrooms.TabIndex = 8;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(40, 190);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(80, 15);
            lblRate.TabIndex = 9;
            lblRate.Text = "Rate per night:";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(150, 187);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(150, 23);
            txtRate.TabIndex = 10;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(40, 220);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(61, 15);
            lblAvailable.TabIndex = 11;
            lblAvailable.Text = "Available?";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(150, 220);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(15, 14);
            chkAvailable.TabIndex = 12;
            chkAvailable.UseVisualStyleBackColor = true;
            chkAvailable.Checked = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(180, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 320);
            Controls.Add(lblTitle);
            Controls.Add(lblNumber);
            Controls.Add(txtNumber);
            Controls.Add(lblType);
            Controls.Add(cmbType);
            Controls.Add(lblBeds);
            Controls.Add(numBeds);
            Controls.Add(lblBathrooms);
            Controls.Add(numBathrooms);
            Controls.Add(lblRate);
            Controls.Add(txtRate);
            Controls.Add(lblAvailable);
            Controls.Add(chkAvailable);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddRoomForm";
            Text = "Add Room";
            ((System.ComponentModel.ISupportInitialize)numBeds).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBathrooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNumber;
        private Label lblType;
        private Label lblBeds;
        private Label lblBathrooms;
        private Label lblRate;
        private Label lblAvailable;
        private TextBox txtNumber;
        private ComboBox cmbType;
        private NumericUpDown numBeds;
        private NumericUpDown numBathrooms;
        private TextBox txtRate;
        private CheckBox chkAvailable;
        private Button btnSave;
        private Button btnCancel;
    }
}
