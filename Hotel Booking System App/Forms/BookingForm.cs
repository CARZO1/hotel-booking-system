using System;
using System.Windows.Forms;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services;

namespace HotelBookingSystem.Forms
{
    public partial class BookingForm : Form
    {
        private ListBox listRooms = null!;
        private Button btnBook = null!;

        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingFormLoad;
        }

        private void BookingFormLoad(object? sender, EventArgs e)
        {
            this.Text = "Booking Page";

            // Welcome label
            Label lblWelcome = new Label();
            lblWelcome.Text = "Select a room to book:";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblWelcome);

            // ListBox to display rooms
            listRooms = new ListBox();
            listRooms.Location = new System.Drawing.Point(20, 60);
            listRooms.Size = new System.Drawing.Size(500, 200);
            this.Controls.Add(listRooms);

            var rooms = FileManager.LoadRooms();

            if (rooms.Count == 0)
            {
                rooms = Room.GetRooms();  // fallback if file is empty or missing
            }

            // Now bind rooms to the list
            foreach (var r in rooms.OrderBy(r => r.Number))
            {
                listRooms.Items.Add(r); // uses Room.ToString() for display
            }

            // Book button
            btnBook = new Button();
            btnBook.Text = "Book Selected Room";
            btnBook.Location = new System.Drawing.Point(20, 280);
            btnBook.Click += BtnBook_Click;
            this.Controls.Add(btnBook);
        }

        //private void BtnBook_Click(object? sender, EventArgs e)
        //{
        //    if (listRooms.SelectedItem is Room selectedRoom)
        //    {
        //        MessageBox.Show(
        //            $"You selected {selectedRoom}.",
        //            "Booking Confirmation",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information
        //        );
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a room first.", "No Room Selected",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void BtnBook_Click(object? sender, EventArgs e)
        {
            if (listRooms.SelectedItem is Room selectedRoom)
            {
                var confirmationForm = new BookingConfirmationForm(selectedRoom);
                confirmationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a room first.", "No Room Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
