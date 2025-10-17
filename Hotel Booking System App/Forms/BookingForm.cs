using System;
using System.Windows.Forms;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services;

namespace HotelBookingSystem.Forms
{
    public partial class BookingForm : Form
    {
        // list to show rooms
        private ListBox listRooms = null!;
        // button to open booking confirmation
        private Button btnBook = null!;

        public BookingForm()
        {
            InitializeComponent();
            this.Load += BookingFormLoad; // run when form loads
        }

        private void BookingFormLoad(object? sender, EventArgs e)
        {
            this.Text = "Booking Page";

            // label at top
            Label lblWelcome = new Label();
            lblWelcome.Text = "Select a room to book:";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblWelcome);

            // listbox to display rooms
            listRooms = new ListBox();
            listRooms.Location = new System.Drawing.Point(20, 60);
            listRooms.Size = new System.Drawing.Size(500, 200);
            this.Controls.Add(listRooms);

            // load rooms from file
            var rooms = FileManager.LoadRooms();

            // if no file or empty, fallback to hardcoded rooms
            if (rooms.Count == 0)
            {
                rooms = Room.GetRooms();
            }

            // show all rooms in list
            foreach (var r in rooms.OrderBy(r => r.Number))
            {
                listRooms.Items.Add(r); // uses Room.ToString()
            }

            // button to book selected room
            btnBook = new Button();
            btnBook.Text = "Book Selected Room";
            btnBook.Location = new System.Drawing.Point(20, 280);
            btnBook.Click += BtnBook_Click;
            this.Controls.Add(btnBook);
        }

        // when book button clicked
        private void BtnBook_Click(object? sender, EventArgs e)
        {
            if (listRooms.SelectedItem is Room selectedRoom)
            {
                // open booking confirmation window
                var confirmationForm = new BookingConfirmationForm(selectedRoom);
                confirmationForm.ShowDialog();
            }
            else
            {
                // if no room picked
                MessageBox.Show("Please select a room first.", "No Room Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
