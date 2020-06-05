using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb
{
    public partial class AddGameForm : Form
    {
        private DatabaseConnection databaseConnection;
        public AddGameForm()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();

            countriesChoice.DataSource = databaseConnection.ShowTable("Countries");
            countriesChoice.DisplayMember = "CountryName";
            countriesChoice.ValueMember = "CountryId";

            genresBox.DataSource = databaseConnection.ShowTable("Genres");
            genresBox.DisplayMember = "GenreName";
            genresBox.ValueMember = "GenreName";
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            TextBox s = sender as TextBox;

            if (s.TextLength <= 0)
            {
                e.Cancel = true;
                s.Select(0, s.Text.Length);
                errorProvider.SetError(s, "Value is too short");
            }
        }

        private void name_Validated(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            errorProvider.SetError(s, string.Empty);
        }

        private void genresBox_Validating(object sender, CancelEventArgs e)
        {
            CheckedListBox c = sender as CheckedListBox;
            if (c.CheckedItems.Count < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(c, "Too few values");
            }

        }

        private void genresBox_Validated(object sender, EventArgs e)
        {
            CheckedListBox c = sender as CheckedListBox;
            errorProvider.SetError(c, string.Empty);
        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            string c_name = gameName.Text;
            string c_id = countriesChoice.SelectedValue.ToString();
            if (!databaseConnection.CanGameBeInserted(c_name))
            {
                MessageBox.Show("Game with this title already exist",
                                "Cannot add!",
                                MessageBoxButtons.OK);
                return;
            }

            if (!databaseConnection.InsertGame(c_name, c_id))
            {
                MessageBox.Show("Error occurs", "Failed!", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            StringBuilder sb = new StringBuilder("select GameId from Games where GameName='");
            sb.Append(c_name);
            sb.Append("'");

            string id = databaseConnection.QuerySelected(sb.ToString()).Rows[0]["GameId"].ToString();
            Debug.WriteLine(id);

            foreach(DataRowView item in genresBox.CheckedItems)
            {
               if(!databaseConnection.InsertGameGenre(id, item["GenreId"].ToString()))
               {
                    MessageBox.Show($"Error occurs with {item.ToString()}",
                                    "Failed!", MessageBoxButtons.OK);

               }
            }

            MessageBox.Show("Game have been added", "Success!", MessageBoxButtons.OK);
            this.Close();
        }
    }
}