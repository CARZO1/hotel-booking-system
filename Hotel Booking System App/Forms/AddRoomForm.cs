using HotelBookingSystem.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace HotelBookingSystem.Forms
{
    public partial class AddRoomForm : Form
    {
        public Room? CreatedRoom { get; private set; }

        public AddRoomForm()
        {
            InitializeComponent();

            Text = "Add Room";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = MinimizeBox = false;

            AcceptButton = btnSave;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void SaveRoomAndClose()
        {
            string number = txtNumber.Text.Trim();
            string type = cmbType.SelectedItem?.ToString() ?? "";   // << changed
            string rateText = txtRate.Text.Trim();

            if (string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Number and Type are required.", "Validation");
                return;
            }
            if (!decimal.TryParse(rateText, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Enter a valid nightly rate (e.g., 120.00).", "Validation");
                return;
            }

            CreatedRoom = new Room
            {
                Number = number,
                Type = type,
                Beds = (int)numBeds.Value,
                Bathrooms = (int)numBathrooms.Value,
                RatePerNight = rate,
                IsAvailable = chkAvailable.Checked
            };

            DialogResult = DialogResult.OK;
            Close();
        }


        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveRoomAndClose();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
