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
    public partial class ModifyGameForm : Form
    {
        private DatabaseConnection databaseConnection;
        private string Id;
        private string nameDef;

        public ModifyGameForm(string id, string name)
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();

            this.Id = id;
            nameDef = name;
            gameName.Text = name;

            countriesChoice.DataSource = databaseConnection.ShowTable("Countries");
            countriesChoice.DisplayMember = "CountryName";
            countriesChoice.ValueMember = "CountryId";
            // ecery time change

            string q = $"select distinct g.GenreName, g.GenreId from Genres g where not exists(select * from [Games Genres] where[Games Genres].GenreId = g.GenreId and [Games Genres].GameId = '{id}')";
            genresBox.DataSource = databaseConnection.QuerySelected(q);
            genresBox.DisplayMember = "GenreName";
            genresBox.ValueMember = "GenreId";

            
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
            return;
        }

        private void genresBox_Validated(object sender, EventArgs e)
        {
            return;
        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            string c_name = gameName.Text;
            string c_id = countriesChoice.SelectedValue.ToString();
            if(c_name!=nameDef)
                if (!databaseConnection.CanGameBeInserted(c_name))
                {
                    MessageBox.Show("Game with this title already exist",
                                    "Cannot add!",
                                    MessageBoxButtons.OK);
                    return;
                }

            if (!databaseConnection.UpdateGame(c_name, c_id, this.Id))
            {
                MessageBox.Show("Error occurs", "Failed!", MessageBoxButtons.OK);
                this.Close();
                return;
            }

            foreach (DataRowView item in genresBox.CheckedItems)
            {
                if (!databaseConnection.InsertGameGenre(Id, item["GenreId"].ToString()))
                {
                    MessageBox.Show($"Error occurs with {item.ToString()}",
                                    "Failed!", MessageBoxButtons.OK);

                }
            }

            MessageBox.Show("Game have been updated", "Success!", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
