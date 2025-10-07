using System;
using System.Windows.Forms;
using HotelBookingSystemApp.Services;

namespace HotelBookingSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Configure role combo box
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.SelectedIndex = 1; // Default to Customer
            cmbRole.SelectedIndexChanged += (_, __) => TogglePasswordForRole();

            // Configure password field
            txtPassword.UseSystemPasswordChar = true;
            TogglePasswordForRole();

            // Form properties
            this.AcceptButton = btnLogin;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";

            // Attach events
            btnLogin.Click += BtnLogin_Click;
        }

        private void TogglePasswordForRole()
        {
            var role = cmbRole.SelectedItem?.ToString() ?? "Customer";
            bool isAdmin = role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            txtPassword.Enabled = isAdmin;
            if (!isAdmin)
                txtPassword.Text = string.Empty;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem?.ToString() ?? "";
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate email using Utilities
            if (!Utilities.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (role == "Admin")
            {
                // Basic mock admin authentication
                if (email.EndsWith("@hotel.local", StringComparison.OrdinalIgnoreCase) && password == "admin123")
                {
                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: open AdminDashboardForm here
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Customer
            {
                MessageBox.Show($"Welcome, {email}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: open CustomerDashboardForm here
            }
        }
    }
}
