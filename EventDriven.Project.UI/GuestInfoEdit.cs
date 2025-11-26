using EventDriven.Project.Controller;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class GuestInfoEdit : Form
    {
        public int GuestID { get; set; }
        public GuestInfoEdit()
        {
            InitializeComponent();
        }

        public void LoadGuest(Guest guest)
        {
            GuestID = guest.GuestID;
            txtboxFirstName.Text = guest.FirstName;
            txtboxLastName.Text = guest.LastName;
            txtboxMI.Text = guest.MiddleInitial.ToString();
            datetimeBirth.Value = guest.DateOfBirth;
            comboboxSex.SelectedItem = guest.Sex.ToString();
            txtboxContactNo.Text = guest.ContactNumber;
            txtboxEmail.Text = guest.Email;
            txtboxAddress.Text = guest.Address;
            txtboxEmergencyContact.Text = guest.EmergencyContact;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFirstName.Text))
            {
                MessageBox.Show("First Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxFirstName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtboxLastName.Text))
            {
                MessageBox.Show("Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxLastName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtboxContactNo.Text))
            {
                MessageBox.Show("Contact Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxContactNo.Focus();
                return;
            }
            if (!long.TryParse(txtboxContactNo.Text.Trim(), out _))
            {
                MessageBox.Show("Contact Number must be numeric. Please remove any letters or symbols.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxContactNo.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtboxEmail.Text) && !txtboxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxEmail.Focus();
                return;
            }
            try
            {
                Guest guest = new Guest
                {
                    GuestID = this.GuestID,
                    FirstName = txtboxFirstName.Text.Trim(),
                    LastName = txtboxLastName.Text.Trim(),
                    MiddleInitial = string.IsNullOrEmpty(txtboxMI.Text) ? ' ' : txtboxMI.Text[0],
                    DateOfBirth = datetimeBirth.Value,
                    Sex = comboboxSex.SelectedItem.ToString()[0],
                    ContactNumber = txtboxContactNo.Text.Trim(),
                    Email = txtboxEmail.Text.Trim(),
                    Address = txtboxAddress.Text.Trim(),
                    EmergencyContact = txtboxEmergencyContact.Text.Trim()
                };

                GuestController guestController = new GuestController();
                guestController.UpdateGuest(guest);

                MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
