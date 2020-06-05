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
    public partial class AddCountryForm : Form
    {
        private DatabaseConnection databaseConnection;
        public AddCountryForm()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();
        }

        private void countryId_Validating(object sender, CancelEventArgs e)
        {
            TextBox s = sender as TextBox;

            if (s.TextLength <= 0)
            {
                e.Cancel = true;
                s.Select(0, s.Text.Length);
                errorProvider.SetError(s, "Value is too short");
            }            
        }

        private void countryId_Validated(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            errorProvider.SetError(s, string.Empty);
        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            string c_name = countryName.Text;
            string c_id = countryId.Text;
            if(!databaseConnection.CanCountryBeInsterted(c_name,c_id))
            {
                MessageBox.Show("Country with any of this values already exist",
                                "Cannot add!",
                                MessageBoxButtons.OK);
                return;
            }
            if (databaseConnection.InsertCountry(c_name, c_id))
            {
                MessageBox.Show("New Country have been added", "Success!", MessageBoxButtons.OK);
                this.Close();

                return;
            }
            MessageBox.Show("Error occured!", "Failed!", MessageBoxButtons.OK);
            this.Close();





        }
    }
}
