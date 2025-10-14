using System;
using System.Windows.Forms;
using HotelBookingSystem.Models;
using HotelBookingSystem.Services;

namespace HotelBookingSystem.Forms
{
    public partial class EditCustomerForm : Form
    {
        private Customer? _current; // loaded customer snapshot

        public EditCustomerForm()
        {
            InitializeComponent();
            SetupForm();
        }

        public EditCustomerForm(string prefillEmail) : this()
        {
            txtSearchEmail.Text = prefillEmail;
            txtSearchEmail.SelectAll();
            txtSearchEmail.Focus();
        }

        private void SetupForm()
        {
            this.Text = "Edit Customer";
            this.StartPosition = FormStartPosition.CenterParent;
            this.AcceptButton = btnFind; // default in search state

            // wire events
            btnFind.Click += BtnFind_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
            chkEditEmail.CheckedChanged += (_, __) =>
            {
                txtEmail.ReadOnly = !chkEditEmail.Checked;
                if (!chkEditEmail.Checked && _current != null)
                    txtEmail.Text = _current.Email; // revert if toggled off
            };

            // initial state
            ShowSearchState();
        }

        private void ShowSearchState()
        {
            panelSearch.Visible = true;
            panelEdit.Visible = false;
            this.AcceptButton = btnFind;
            txtSearchEmail.Focus();
        }

        private void ShowEditState(Customer c)
        {
            _current = c;

            // prefill fields
            txtEmail.Text = c.Email;
            txtName.Text = c.Name;
            txtPhone.Text = c.Phone;
            txtPassword.Text = c.Password;

            // defaults
            txtEmail.ReadOnly = true;
            chkEditEmail.Checked = false;

            panelSearch.Visible = false;
            panelEdit.Visible = true;
            this.AcceptButton = btnSave;
            txtName.Focus();
        }

        private void BtnFind_Click(object? sender, EventArgs e)
        {
            var email = txtSearchEmail.Text.Trim();

            if (!Utilities.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Invalid e-mail",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = FileManager.FindCustomerByEmail(email);
            if (customer is null)
            {
                MessageBox.Show("No customer found with that e-mail.", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ShowEditState(customer);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (_current is null)
            {
                MessageBox.Show("Nothing to save. Please search for a customer first.");
                return;
            }

            var newEmail = txtEmail.Text.Trim();
            var name = txtName.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var pwd = txtPassword.Text;

            if (!Utilities.IsValidEmail(newEmail))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Invalid e-mail");
                return;
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Name and password are required.");
                return;
            }
            // simple phone sanity check (loose by design)
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9 +()\-]{8,20}$"))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            // If e-mail changed, ensure uniqueness
            if (!newEmail.Equals(_current.Email, StringComparison.OrdinalIgnoreCase)
                && FileManager.EmailExists(newEmail))
            {
                MessageBox.Show("That e-mail is already in use by another account.",
                    "Duplicate e-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updated = new Customer(newEmail, name, pwd, phone);

            // persist (match by old e-mail)
            var ok = FileManager.UpdateCustomer(_current.Email, updated);
            if (!ok)
            {
                MessageBox.Show("Update failed — original record not found.");
                return;
            }

            MessageBox.Show("Customer updated successfully.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
