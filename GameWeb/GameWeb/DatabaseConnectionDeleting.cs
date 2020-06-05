using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWeb
{
    partial class DatabaseConnection
    {
        public bool DeleteScore(string id)
        {
            StringBuilder sb = new StringBuilder(
                "delete from [Games Scores] where ScoreId='");
            sb.Append(id);
            sb.Append("'");
            return this.NonQuery(sb.ToString());
        }

        public bool DeleteCountry(string id)
        {
            StringBuilder sb = new StringBuilder(
                "delete from Countries where CountryId='");
            sb.Append(id);
            sb.Append("';");
            return UpdateByDelete(id) && this.NonQuery(sb.ToString());
        }
        
        private bool UpdateByDelete(string id)
        {
            string query1 = $"update Users set CountryId = NULL where CountryId='{id}'";
            string query2 = $"update Games set CountryId = NULL where CountryId='{id}'";
            return this.NonQuery(query1) && this.NonQuery(query2);
        }

        public bool DeleteGenre(string genreName)
        {
            string q1 = $"select GenreId from Genres where GenreName='{genreName}'";
            string Id = this.QuerySelected(q1).Rows[0]["GenreId"].ToString();

            string del1 = $"delete from [Games Genres] where GenreId={Id}";
            string del2 = $"delete from Genres where GenreName='{genreName}'";
            return this.NonQuery(del1) && this.NonQuery(del2);

        }

        public bool DeleteUser(string Id)
        {
            string del1 = $"delete from [Games Scores] where UserNick='{Id}'";
            string del2 = $"delete from Users where UserNick='{Id}'";
            return this.NonQuery(del1) && this.NonQuery(del2);

        }

        public bool DeleteGame(string name)
        {
            string query = $"select GameId from Games where GameName='{name}'";
            string id = this.QuerySelected(query).Rows[0]["GameId"].ToString();
            string del1 = $"delete from [Games Genres] where GameId={id}";
            string del2 = $"delete from [Games Scores] where GameId={id}";
            string del3 = $"delete from Games where GameId={id}";

            return this.NonQuery(del1) && this.NonQuery(del2) && this.NonQuery(del3);

        }

        public bool DeleteGameGenre(string name, string gen)
        {
            string query = $"select GameId from Games where GameName='{name}'";
            string id = this.QuerySelected(query).Rows[0]["GameId"].ToString();
            string del1 = $"delete from [Games Genres] where GameId={id} and GenreId='{gen}'";

            return this.NonQuery(del1);

        }
    }
}
