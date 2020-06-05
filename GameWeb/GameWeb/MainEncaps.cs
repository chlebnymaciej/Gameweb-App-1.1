//using System;
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
        private interface IChain
        {
            IChain Next(IChain chain);
            bool Do();
            void Handle();
        }

        private abstract class AbstractChain : IChain
        {
            protected Main main;
            protected IChain next;
            protected string me;
            public abstract bool Do();
            
            public AbstractChain(Main main)
            {
                this.main = main;
            }

            public void Handle()
            {
                if (Do() || next==null)
                    return;
                
                next.Handle();
            }

            public IChain Next(IChain chain)
            {
                this.next = chain;
                return chain;
            }
        }

        private class UserChain : AbstractChain
        {
            public UserChain(Main main) : base(main) { this.me = "Users";  }
            public override bool Do()
            {
                if(this.main.my_mutex == me)
                {

                    var arg = this.main.showBoxMain1.SelectedValue;
                    StringBuilder sb = new StringBuilder("select g.GameName, g.GameId from Games g join [Games Scores] gs on g.GameId=gs.GameId where gs.UserNick='");
                    sb.Append(arg);
                    sb.Append("'");
                    this.main.groupBox2.Text = "User Rated Games";

                    this.main.listBox2.DataSource = this.main.databaseConnection.QuerySelected(sb.ToString());
                    this.main.listBox2.DisplayMember = "GameName";
                    this.main.listBox2.ValueMember = "GameId";

                    string q = $"select * from Countries c join Users u on u.CountryId=c.CountryId where u.UserNick='{arg}'";
                    this.main.genreBox.DataSource = main.databaseConnection.QuerySelected(q);
                    main.genreBox.DisplayMember = "CountryName";
                    main.genreBox.ValueMember = "CountryId";

                    string q1 = $"select * from [Average User Score] where UserNick='{arg}'";
                    var tmp = main.databaseConnection.QuerySelected(q1).Rows;
                    if (tmp.Count > 0)
                        main.aScore.Text = "Average user score: " + tmp[0]["Average Score"].ToString();
                    else
                        main.aScore.Text = string.Empty;

                    return true;
                }

                return false;

            }
        }

        private class GamesChain : AbstractChain
        {
            public GamesChain(Main main) : base(main) { this.me = "Games"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {

                    var arg = this.main.showBoxMain1.SelectedValue;
                    StringBuilder sb = new StringBuilder("select UserNick from Games g join [Games Scores] gs on g.GameId=gs.GameId where g.GameName='");
                    sb.Append(arg);
                    sb.Append("'");
                    this.main.groupBox2.Text = "Users That Rated Game";

                    this.main.listBox2.DataSource = this.main.databaseConnection.QuerySelected(sb.ToString());
                    this.main.listBox2.DisplayMember = "UserNick";
                    this.main.listBox2.ValueMember = "UserNick";

                    StringBuilder sb1 = new StringBuilder(
                    "select GenreName, Genres.GenreId from Genres join [Games Genres][G G] on Genres.GenreId = [G G].GenreId join Games G on [G G].GameId = G.GameId where GameName = '");
                    sb1.Append(arg);
                    sb1.Append("'");
                    this.main.genreBox.DataSource = this.main.databaseConnection.QuerySelected(sb1.ToString());
                    main.genreBox.DisplayMember = "GenreName";
                    main.genreBox.ValueMember = "Genres.GenreId";

                    string q1 = $"select * from [Average Game Score] join Games G on [Average Game Score].GameId = G.GameId where GameName = '{arg}'";
                    var tmp = main.databaseConnection.QuerySelected(q1).Rows;
                    if (tmp.Count > 0)
                        main.aScore.Text = "Average user score: " + tmp[0]["Average Score"].ToString();
                    else
                    {
                        main.aScore.Text = string.Empty;
                    }
                    return true;
                }

                return false;

            }
        }
        private class CountriesChain : AbstractChain
        {
            public CountriesChain(Main main) : base(main) { this.me = "Countries"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {

                    main.aScore.Text = string.Empty;

                    this.main.groupBox2.Text = "";
                    this.main.gbMoreInfo.Text = "More info";
                    this.main.infoLabel.Text = "Country id : " + this.main.showBoxMain1.SelectedValue.ToString();
                    this.main.listBox2.DataSource = null;
                    return true;
                }

                return false;

            }
        }

        private class GenresChain : AbstractChain
        {
            public GenresChain(Main main) : base(main) { this.me = "Genres"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {
                    main.aScore.Text = string.Empty;

                    this.main.groupBox2.Text = "";

                    this.main.listBox2.DataSource = null;
                    this.main.infoLabel.Text = string.Empty;
                    return true;
                }

                return false;

            }
        }


        // ===============================
        // Second box chain
        // ===============================

        private class User2_Chain : AbstractChain
        {
            public User2_Chain(Main main) : base(main) { this.me = "Users"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {

                    var arg1 = this.main.showBoxMain1.SelectedValue;
                    var arg2 = this.main.listBox2.SelectedValue;

                    StringBuilder sb = new StringBuilder(
                    "select gs.Score from Games g join [Games Scores] gs on g.GameId=gs.GameId where gs.UserNick='");
                    sb.Append(arg1);
                    sb.Append("' and gs.GameId='");
                    sb.Append(arg2);
                    sb.Append("'");
                    this.main.gbMoreInfo.Text = "More Info";

                    var tmp = this.main.databaseConnection.QuerySelected(sb.ToString());
                    if (tmp.Rows.Count < 1)
                        return true;

                    main.infoLabel.Text = "Score: " + tmp.Rows[0]["Score"].ToString();
                    return true;
                }

                return false;

            }
        }

        private class Games2_Chain : AbstractChain
        {
            public Games2_Chain(Main main) : base(main) { this.me = "Games"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {

                    var arg1 = this.main.showBoxMain1.SelectedValue;
                    var arg2 = this.main.listBox2.SelectedValue;

                    StringBuilder sb = new StringBuilder(
                    "select gs.Score from Games g join [Games Scores] gs on g.GameId=gs.GameId where gs.UserNick='");
                    sb.Append(arg2);
                    sb.Append("' and g.GameName='");
                    sb.Append(arg1);
                    sb.Append("'");
                    this.main.gbMoreInfo.Text = "More Info";

                    var tmp = this.main.databaseConnection.QuerySelected(sb.ToString());
                    if (tmp.Rows.Count < 1)
                        return true;

                    main.infoLabel.Text = "User Score: " + tmp.Rows[0]["Score"].ToString();
                    return true;
                }

                return false;

            }
        }
    }
}
