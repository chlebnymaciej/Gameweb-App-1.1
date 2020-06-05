using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb.ModifyForms
{
    public partial class ModifyUserForm : Form
    {
        private DatabaseConnection databaseConnection;
        private string Id;
        public ModifyUserForm(string id)
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();

            this.Id = id;

            countriesChoice.DataSource = databaseConnection.ShowTable("Countries");
            countriesChoice.DisplayMember = "CountryName";
            countriesChoice.ValueMember = "CountryId";

        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (this.countryBox.Checked == true)
            {
                if (this.databaseConnection.UpdateUserNull(Id))
                    MessageBox.Show("User have been updated", "Success!", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Error occurs", "Failed!", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            if(this.databaseConnection.UpdateUser(Id, countriesChoice.SelectedValue.ToString()))
                MessageBox.Show("User have been updated", "Success!", MessageBoxButtons.OK);
            else
                MessageBox.Show("Error occurs", "Failed!", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
