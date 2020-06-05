using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeb
{

    partial class DatabaseConnection
    {
        public bool CanCountryBeInsterted(string countryName, string countryId)
        {
            StringBuilder sb = new StringBuilder("select * from Countries where CountryId='");
            sb.Append(countryId);
            sb.Append("' or CountryName='");
            sb.Append(countryName);
            sb.Append("'");

            var tmp = this.QuerySelected(sb.ToString());

            return tmp.Rows.Count == 0;
        }

        public bool CanGenreBeInserted(string genreName)
        {
            StringBuilder sb = new StringBuilder("select * from Genres where GenreName='");
            sb.Append(genreName);
            sb.Append("'");
            var tmp = this.QuerySelected(sb.ToString());

            return tmp.Rows.Count == 0;
        }

        public bool CanUserBeInserted(string userName)
        {
            StringBuilder sb = new StringBuilder("select * from Users where UserNick='");
            sb.Append(userName);
            sb.Append("'");
            var tmp = this.QuerySelected(sb.ToString());

            return tmp.Rows.Count == 0;
        }

        public bool CanGameBeInserted(string gameName)
        {
            StringBuilder sb = new StringBuilder("select * from Games where GameName='");
            sb.Append(gameName);
            sb.Append("'");
            var tmp = this.QuerySelected(sb.ToString());

            return tmp.Rows.Count == 0;
        }

        // ===================================
        //
        // ===================================

        public bool InsertCountry(string country, string key)
        {
            StringBuilder sb = new StringBuilder(
                "Insert into Countries(CountryId, CountryName) values('");
            sb.Append(key);
            sb.Append("','");
            sb.Append(country);
            sb.Append("')");

            return this.NonQuery(sb.ToString());

        }
        
        public bool InsertGenre(string name)
        {
            StringBuilder sb = new StringBuilder(
                "insert into Genres (GenreName) values ('");
            sb.Append(name);
            sb.Append("')");

            return this.NonQuery(sb.ToString());
        }

        public bool InsertUserNull(string name)
        {
            StringBuilder sb = new StringBuilder(
                "insert into Users (UserNick) values ('");
            sb.Append(name);
            sb.Append("')");

            return this.NonQuery(sb.ToString());
        }
        public bool InsertUserNotNull(string name, string country)
        {
            StringBuilder sb = new StringBuilder(
                "insert into Users (UserNick, CountryId) values ('");
            sb.Append(name);
            sb.Append("','");
            sb.Append(country);
            sb.Append("')");

            return this.NonQuery(sb.ToString());
        }

        public bool InsertScore(string uname, string gname, int score)
        {
            StringBuilder sb = new StringBuilder(
            "insert into[Games Scores](UserNick, GameId, Score) values('");
            sb.Append(uname);
            sb.Append("',");
            sb.Append(gname);
            sb.Append(",");
            sb.Append(score);
            sb.Append(")");

            return this.NonQuery(sb.ToString());
        }

        public bool InsertGame(string gname, string c_id)
        {
            StringBuilder sb = new StringBuilder(
            "Insert into Games (GameName, CountryId) values ( '");
            sb.Append(gname);
            sb.Append("','");
            sb.Append(c_id);
            sb.Append("')");

            return this.NonQuery(sb.ToString());
        }

        public bool InsertGameGenre(string gameId, string genreId)
        {
            StringBuilder sb = new StringBuilder(
            "Insert into [Games Genres] (GameId, GenreId) values (");
            sb.Append(gameId);
            sb.Append(",");
            sb.Append(genreId);
            sb.Append(")");

            return this.NonQuery(sb.ToString());
        }
    }
}
