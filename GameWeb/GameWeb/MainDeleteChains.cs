using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb
{
    public partial class Main
    {
        private class DeleteCountry : AbstractChain
        {
            public DeleteCountry(Main main): base(main)
            {
                me = "Countries";
            }
            public override bool Do()
            {
                if(main.my_mutex == me)
                {
                    string Id = main.showBoxMain1.SelectedValue.ToString();
                    Debug.WriteLine(Id);
                    if (this.main.databaseConnection.DeleteCountry(Id))
                    {
                        MessageBox.Show("Country deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }
        private class DeleteGenre : AbstractChain
        {
            public DeleteGenre(Main main) : base(main)
            {
                me = "Genres";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string genreName = main.showBoxMain1.SelectedValue.ToString();
                    if (this.main.databaseConnection.DeleteGenre(genreName))
                    {
                        MessageBox.Show("Genre deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }
        private class DeleteScore1 : AbstractChain
        {
            public DeleteScore1(Main main) : base(main)
            {
                me = "Games";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string Id = main.showBoxMain1.SelectedValue.ToString();
                    string Id2 = main.listBox2.SelectedValue.ToString();

                    string query = $"select ScoreId from [Games Scores] gs join Games G on gs.GameId = G.GameId where gs.UserNick='{Id2}' and GameName='{Id}'";
                    if (this.main.databaseConnection.DeleteScore(
                        this.main.databaseConnection.QuerySelected(query).Rows[0]["ScoreId"].ToString()))
                    {
                        MessageBox.Show("Score deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);
                    }
                    return true;
                }
                return false;
            }
        }
        private class DeleteScore2 : AbstractChain
        {
            public DeleteScore2(Main main) : base(main)
            {
                me = "Users";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string Id = main.showBoxMain1.SelectedValue.ToString();
                    string Id2 = main.listBox2.SelectedValue.ToString();

                    string query = $"select ScoreId from [Games Scores] where UserNick='{Id}' and GameId='{Id2}'";
                    if (this.main.databaseConnection.DeleteScore(
                        this.main.databaseConnection.QuerySelected(query).Rows[0]["ScoreId"].ToString()))
                    {
                        MessageBox.Show("Score deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }

        private class DeleteUser : AbstractChain
        {
            public DeleteUser(Main main) : base(main)
            {
                me = "Users";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string Id = main.showBoxMain1.SelectedValue.ToString();

                    if (this.main.databaseConnection.DeleteUser(Id))
                    {
                        MessageBox.Show("User deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }

        private class DeleteGame : AbstractChain
        {
            public DeleteGame(Main main) : base(main)
            {
                me = "Games";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string name = main.showBoxMain1.SelectedValue.ToString();

                    if (this.main.databaseConnection.DeleteGame(name))
                    {
                        MessageBox.Show("Game deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }
        // chainDelete3
        private class DeleteGameGenre : AbstractChain
        {
            public DeleteGameGenre(Main main) : base(main)
            {
                me = "Games";
            }
            public override bool Do()
            {
                if (main.my_mutex == me)
                {
                    string name = main.genreBox.SelectedValue.ToString();
                    string name2 = main.showBoxMain1.SelectedValue.ToString();

                    if (this.main.databaseConnection.DeleteGameGenre(name2, name))
                    {
                        MessageBox.Show("Game genre deleted", "Deleted", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error occur", "Error", MessageBoxButtons.OK);

                    }
                    return true;
                }
                return false;
            }
        }
    }
}

