using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Services;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Register New Customer";
            this.StartPosition = FormStartPosition.CenterScreen;

            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (!Utilities.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate accounts
            if (FileManager.EmailExists(email))
            {
                MessageBox.Show("That email is already registered.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newCustomer = new Customer(email, name, password, phone);
            FileManager.SaveCustomer(newCustomer);

            MessageBox.Show("Registration successful! You can now log in.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Return to Login
        }
    }
}
