using GameWeb.ModifyForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb
{
    partial class Main
    {
        private class ModifyGenre : AbstractChain
        {
            public ModifyGenre(Main main) : base(main)
            {
                me = "Genres";
            }
            public override bool Do()
            {
                if (main.my_mutex != me) return false;


                ModifyGenreForm modifyGenreForm =
                       new ModifyGenreForm(main.showBoxMain1.SelectedValue.ToString());
                modifyGenreForm.Show();

                return true;
            }
        }

        private class ModifyCountry : AbstractChain
        {
            public ModifyCountry(Main main) : base(main)
            {
                me = "Countries";
            }
            public override bool Do()
            {
                if (main.my_mutex != me) return false;


                ModifyCountryForm modifyCountryForm  =
                       new ModifyCountryForm(main.showBoxMain1.SelectedValue.ToString());
                modifyCountryForm.Show();

                return true;
            }
        }

        private class ModifyGame : AbstractChain
        {
            public ModifyGame(Main main) : base(main)
            {
                me = "Games";
            }
            public override bool Do()
            {
                if (main.my_mutex != me) return false;

                string id = $"select GameId from Games where GameName='{main.showBoxMain1.SelectedValue.ToString()}'";
                  ModifyGameForm modifyGameForm=
                       new ModifyGameForm(main
                                    .databaseConnection
                                    .QuerySelected(id)
                                    .Rows[0]["GameId"].ToString(), main.showBoxMain1.SelectedValue.ToString());
                modifyGameForm.Show();

                return true;
            }
        }

        private class ModifyUser : AbstractChain
        {
            public ModifyUser(Main main) : base(main)
            {
                me = "Users";
            }
            public override bool Do()
            {
                if (main.my_mutex != me) return false;

                
                ModifyUserForm modifyGameForm = new ModifyUserForm(main.showBoxMain1.SelectedValue.ToString());
                modifyGameForm.Show();

                return true;
            }
        }
    }
}
