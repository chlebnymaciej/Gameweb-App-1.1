using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeb
{
    partial class Main
    {
        private class UserInitChain : AbstractChain
        {
            public UserInitChain(Main main) : base(main) { this.me = "Users"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {
                    string users = "Users";
                    main.gbShowMain.Text = users;
                    main.genreBox.DataSource = null;
                    main.showBoxMain1.DataSource = main.databaseConnection.ShowTable(users);
                    main.showBoxMain1.DisplayMember = "UserNick";
                    main.showBoxMain1.ValueMember = "UserNick";

                    main.chainColumn1.Handle();
                    return true;
                }

                return false;

            }
        }

        private class GamesInitChain : AbstractChain
        {
            public GamesInitChain(Main main) : base(main) { this.me = "Games"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {
                    main.gbShowMain.Text = me;
                    main.genreBox.DataSource = null;
                    main.showBoxMain1.DataSource = main.databaseConnection.ShowTable(me);
                    main.showBoxMain1.DisplayMember = "GameName";
                    main.showBoxMain1.ValueMember = "GameName";
                    main.chainColumn1.Handle();

                    return true;
                }

                return false;

            }
        }
        private class CountriesInitChain : AbstractChain
        {
            public CountriesInitChain(Main main) : base(main) { this.me = "Countries"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {

                    main.gbShowMain.Text = me;
                    main.genreBox.DataSource = null;
                    main.showBoxMain1.DataSource = main.databaseConnection.ShowTable(me);
                    main.showBoxMain1.DisplayMember = "CountryName";
                    main.showBoxMain1.ValueMember = "CountryId";
                    main.infoLabel.Text = "";
                    main.chainColumn1.Handle();

                    return true;
                }

                return false;

            }
        }

        private class GenresInitChain : AbstractChain
        {
            public GenresInitChain(Main main) : base(main) { this.me = "Genres"; }
            public override bool Do()
            {
                if (this.main.my_mutex == me)
                {
                    main.gbShowMain.Text = me;
                    main.genreBox.DataSource = null;
                    main.showBoxMain1.DataSource = main.databaseConnection.ShowTable(me);
                    main.showBoxMain1.DisplayMember = "GenreName";
                    main.showBoxMain1.ValueMember = "GenreName";
                    main.infoLabel.Text = "";
                    main.chainColumn1.Handle();


                    return true;
                }

                return false;

            }
        }
    }
}
