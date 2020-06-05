using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameWeb
{
    public partial class Main : Form
    {
        internal DatabaseConnection databaseConnection;
        private string my_mutex = "None";
        private IChain chainInit;
        private IChain chainColumn1;
        private IChain chainColumn2;

        private IChain deleteChainColumn1;
        private IChain deleteChainColumn2;
        private IChain deleteChainColumn3;

        private IChain modifyChainColumn1;
        public Main()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetInstance();

            gbShowMain.Text = "";
            groupBox2.Text = "";
            chainInit = new UserInitChain(this);
            chainInit.Next(new GamesInitChain(this))
                     .Next(new CountriesInitChain(this))
                     .Next(new GenresInitChain(this));

            
            chainColumn1 = new UserChain(this);
            chainColumn1.Next(new GamesChain(this))
                  .Next(new CountriesChain(this))
                  .Next(new GenresChain(this));
            
            chainColumn2 = new User2_Chain(this);
            chainColumn2.Next(new Games2_Chain(this));

            deleteChainColumn1 = new DeleteCountry(this);
            deleteChainColumn1.Next(new DeleteGenre(this))
                        .Next(new DeleteUser(this))
                        .Next(new DeleteGame(this));

            deleteChainColumn2 = new DeleteScore1(this);
            deleteChainColumn2.Next(new DeleteScore2(this));

            deleteChainColumn3 = new DeleteGameGenre(this);

            modifyChainColumn1 = new ModifyCountry(this);
            modifyChainColumn1.Next(new ModifyGenre(this))
                        .Next(new ModifyGame(this))
                        .Next(new ModifyUser(this));
        }

        private void usersT_Click(object sender, EventArgs e)
        {
            string users = "Users";
            my_mutex = users;

            this.chainInit.Handle();
            //gbShowMain.Text = users;
            //genreBox.DataSource = null;
            //showBoxMain1.DataSource = databaseConnection.ShowTable(users);
            //showBoxMain1.DisplayMember = "UserNick";
            //showBoxMain1.ValueMember = "UserNick";
        }

        private void gamesT_Click(object sender, EventArgs e)
        {
            string games = "Games";
            //gbShowMain.Text = games;

            my_mutex = games;
            this.chainInit.Handle();
            //showBoxMain1.DataSource = databaseConnection.ShowTable(games);
            //showBoxMain1.DisplayMember = "GameName";
            //showBoxMain1.ValueMember = "GameName";

        }

        private void countriesT_Click(object sender, EventArgs e)
        {
            string country = "Countries";
            //gbShowMain.Text = country;

            my_mutex = country;
            this.chainInit.Handle();
            //genreBox.DataSource = null;
            //showBoxMain1.DataSource = databaseConnection.ShowTable(country);
            //showBoxMain1.DisplayMember = "CountryName";
            //showBoxMain1.ValueMember = "CountryId";
            //this.infoLabel.Text = "";

        }

        private void genresT_Click(object sender, EventArgs e)
        {
            string genre = "Genres";
            my_mutex = genre;
            this.chainInit.Handle();
            //gbShowMain.Text = genre;

            //genreBox.DataSource = null;
            //my_mutex = genre;
            //showBoxMain1.DataSource = databaseConnection.ShowTable(genre);
            //showBoxMain1.DisplayMember = "GenreName";
            //showBoxMain1.ValueMember = "GenreName";
        }

        private void showBoxMain1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.infoLabel.Text = string.Empty;
            this.chainColumn1.Handle();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chainColumn2.Handle();
        }

        private void add_CountryT_Click(object sender, EventArgs e)
        {
            AddCountryForm addCountryForm = new AddCountryForm();
            addCountryForm.Show();
            this.chainInit.Handle();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            addGenreForm.Show();
            this.chainInit.Handle();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
            this.chainInit.Handle();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            addScoreForm.Show();
            this.chainInit.Handle();
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            addGameForm.Show();
            this.chainInit.Handle();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void showBoxMain1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.deleteChainColumn1.Handle();
            }
            if (e.KeyCode == Keys.Insert)
            {
                this.modifyChainColumn1.Handle();
                this.chainColumn1.Handle();
                this.Refresh();
            }
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.deleteChainColumn2.Handle();
                this.chainInit.Handle();
                //this.chainColumn1.Handle();
                this.Refresh();
            }
            
        }

        private void genreBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.deleteChainColumn3.Handle();
                this.chainInit.Handle();
                //this.chainColumn1.Handle();
                this.Refresh();
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm(this);
            configForm.Show();
            
        }
        public void InvokeRef()
        {
            chainInit.Handle();
        }

        private void createRaportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog fd = new SaveFileDialog())
            {
                StreamWriter streamWriter;
                fd.Filter = "super database (*.sd)|*.sd";
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    if((streamWriter = new StreamWriter(fd.OpenFile())) != null)
                    {
                        streamWriter.Write("GameWeb Databse Raport \n\n");
                        streamWriter.Write(DateTime.Now.ToString());
                        streamWriter.Write("\n\n");

                        string one = "[Average User Score]";
                        streamWriter.Write(one + "\n\n");
                        streamWriter.Write(data_from_table(one));

                        string two = "[Users By Countries]";
                        streamWriter.Write(two + "\n\n");
                        streamWriter.Write(data_from_table(two));

                        string two1 = "[Average Genre Score]";
                        streamWriter.Write(two1 + "\n\n");
                        streamWriter.Write(data_from_table(two1));

                        streamWriter.Close();
                        MessageBox.Show("Zapisano do pliku!!!");
                    }
                }
            }
            
        }

        private string data_from_table(string table_name)
        {
            var data = databaseConnection.ShowTable(table_name);
            StringBuilder sb = new StringBuilder();
            foreach(DataRow row in data.Rows)
            {
                foreach(var o in row.ItemArray)
                {
                    if(o is System.Int32)
                        sb.Append(((Int32)o).ToString());
                    else
                        sb.Append(o.ToString());

                    sb.Append("\t\t\t");
                }
                sb.Append("\n");
            }
            sb.Append("\n");
            return sb.ToString();
        }
    }
}
