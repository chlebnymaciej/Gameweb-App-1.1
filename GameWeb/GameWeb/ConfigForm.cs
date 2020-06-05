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
    public partial class ConfigForm : Form
    {
        public Main main;
        public ConfigForm(Main main)
        {
            this.main = main;
            InitializeComponent();
            genreName.Text = "Data Source=127.0.0.1,1433;Network Library=DBMSSOCN;Initial Catalog=Gameweb;User ID=sa;Password=student;";

        }

        private void add_countryButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            DialogResult dialogResult =  MessageBox.Show("This changes cannot be undone, are you sure ?", "Really?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.No)
                return;


            string con = genreName.Text;
            DatabaseConnection.connection_string = con;
            this.main.InvokeRef();
            this.Close();
            return;
        }

        private void genre_Validating(object sender, CancelEventArgs e)
        {
            TextBox s = sender as TextBox;

            if (s.TextLength <= 0)
            {
                e.Cancel = true;
                s.Select(0, s.Text.Length);
                errorProvider.SetError(s, "Value is too short");
            }
        }

        private void genre_Validated(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            errorProvider.SetError(s, string.Empty);
        }
    }
}
