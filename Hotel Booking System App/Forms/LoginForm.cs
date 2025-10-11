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
            // Role dropdown
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.SelectedIndex = 1;

            // Password box
            txtPassword.UseSystemPasswordChar = true;
            TogglePasswordForRole();

            // Form behaviour
            this.AcceptButton = btnLogin;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";

            // Events
            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += (_, __) =>
            {
                var register = new RegisterForm();
                register.ShowDialog(); // modal
            };

        }

        private void TogglePasswordForRole()
        {
            txtPassword.Enabled = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem?.ToString() ?? string.Empty;
            string email = (txtEmail.Text ?? string.Empty).Trim();
            string password = (txtPassword.Text ?? string.Empty).Trim();

            // Basic e-mail validation via Utilities
            if (!Utilities.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Invalid e-mail",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (role == "Admin")
            {
                var admin = FileManager.FindAdmin(email, password);

                if (admin != null)
                {
                    MessageBox.Show($"Welcome, {admin.Name}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var dashboard = new AdminDashboardForm();
                    dashboard.FormClosed += (_, __) => this.Close();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
             }

        var customer = FileManager.FindCustomer(email, password);
            if (customer is not null)
            {
                // Set session for global access
                Session.CurrentUserEmail = customer.Email;
                Session.CurrentUserName = customer.Name;
                Session.CurrentUserPhone = customer.Phone;
                Session.IsAdmin = false;

                this.Hide();
                var dashboard = new CustomerDashboardForm();
                dashboard.FormClosed += (_, __) => this.Close();
                dashboard.Show();

                MessageBox.Show($"Welcome back, {customer.Name}!\nPhone: {customer.Phone}",
                    "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect e-mail or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
