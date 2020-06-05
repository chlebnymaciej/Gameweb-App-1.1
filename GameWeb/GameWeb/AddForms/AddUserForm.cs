using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb
{
    public partial class AddUserForm : Form
    {

        private DatabaseConnection databaseConnection;
        public AddUserForm()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();

            countriesChoice.DataSource = databaseConnection.ShowTable("Countries");
            countriesChoice.DisplayMember = "CountryName";
            countriesChoice.ValueMember = "CountryId";
        }

        private void userName_Validating(object sender, CancelEventArgs e)
        {

            TextBox s = sender as TextBox;

            if (s.TextLength <= 0)
            {
                e.Cancel = true;
                s.Select(0, s.Text.Length);
                errorProvider.SetError(s, "Value is too short");
            }
        }

        private void userName_Validated(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            errorProvider.SetError(s, string.Empty);
        }

        private void add_userButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            string c_name = userName.Text;
            
            if (!databaseConnection.CanUserBeInserted(c_name))
            {
                MessageBox.Show("This username already exist",
                                "Cannot add!",
                                MessageBoxButtons.OK);
                return;
            }
            if (countryBox.Checked == true) 
            {
                if (databaseConnection.InsertUserNull(c_name))
                {
                    MessageBox.Show("User successfuly added", "Succes!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error Occurs",
                                    "Failed!",
                                    MessageBoxButtons.OK);
                }
                this.Close();
                return;
            }

            string c_id = (string)(countriesChoice.SelectedValue);

            if (!countryBox.Checked && databaseConnection.InsertUserNotNull(c_name, c_id))
            {
                MessageBox.Show("User successfuly added", "Succes!", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Error Occurs",
                                 "Failed!",
                                 MessageBoxButtons.OK);
            this.Close();
        }

        private void countryBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            if (c.Checked == true)
            {
                countriesChoice.DataSource = null;
                countriesChoice.Enabled = false;
            }
            else
            {
                countriesChoice.Enabled = true;
                countriesChoice.DataSource = databaseConnection.ShowTable("Countries");
                countriesChoice.DisplayMember = "CountryName";
                countriesChoice.ValueMember = "CountryId";
            }
        }
    }
}
