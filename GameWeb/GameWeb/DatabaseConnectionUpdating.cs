using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWeb
{
    partial class DatabaseConnection
    {
        public bool UpdateGenre(string name, string old)
        {
            string query = $"update Genres set GenreName='{name}' where GenreName='{old}'";
            return this.NonQuery(query);
        }

        public bool UpdateCountry(string name, string id)
        {
            string query = $"update Countries set CountryName='{name}' where CountryId='{id}'";
            return this.NonQuery(query);
        }

        public bool UpdateGame(string name, string c, string id)
        {
            string query = $"update Games set GameName='{name}', CountryId='{c}' where GameId='{id}'";
            return this.NonQuery(query);
        }

        public bool UpdateUser(string id, string Country)
        {
            string q = $"update Users set CountryId='{Country}' where UserNick='{id}'";
            return this.NonQuery(q);
        }
        public bool UpdateUserNull(string id)
        {
            string q = $"update Users set CountryId=NULL where UserNick='{id}'";
            return this.NonQuery(q);
        }
    }
}
