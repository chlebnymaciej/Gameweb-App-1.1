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
    public partial class AddScoreForm : Form
    {
        private DatabaseConnection databaseConnection;
        private bool Init = false;
        public AddScoreForm()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();
            gameName.Enabled = false;

            userName.DataSource = databaseConnection.ShowTable("Users");
            userName.DisplayMember = "UserNick";
            userName.ValueMember = "UserNick";
            scoreBox.SelectedIndex = 0;

        }

        private void userName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!Init)
            {
                Init = true;
                return;
            }

            ComboBox c = sender as ComboBox;
            string s = (string)c.SelectedValue;
            if (gameName.Enabled == false)
            {
                gameName.Enabled = true;
            }

            gameName.DataSource = null;
            gameName.Refresh();
            StringBuilder sb = new StringBuilder(
            "select * from Games g where not exists(select * from[Games Scores] gs where gs.GameId = g.GameId and gs.UserNick = '");
            sb.Append(c.SelectedValue);
            sb.Append("');");

            gameName.DataSource = databaseConnection.QuerySelected(sb.ToString());
            gameName.DisplayMember = "GameName";
            gameName.ValueMember = "GameId";
        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            var user = userName.SelectedValue;
            var game = gameName.SelectedValue;
            var score = scoreBox.SelectedIndex;
            if (this.databaseConnection.InsertScore(user.ToString(), game.ToString(), score))
                MessageBox.Show("Score successfuly added", "Succes!", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Error Occurs",
                                "Failed!",
                                MessageBoxButtons.OK);
            }
            this.Close();

        }
    }
}

