using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace GameWeb
{
    partial class  DatabaseConnection
    {
        //SqlConnectionStringBuilder

        public static string connection_string_default = "Data Source=hackercats.pl,1433;Network Library = DBMSSOCN; Initial Catalog = Gameweb; User ID = sa; Password=XX_XX_XXX_XX;";
        public static string connection_string = connection_string_default;
        private static DatabaseConnection instance = null;
        private DatabaseConnection() { }
        public DataTable ShowTable(string table_name)
        {
            DataTable dataTable = new DataTable();
            StringBuilder sb = new StringBuilder("select * from ");
            sb.Append(table_name);
            string query = sb.ToString();

            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlDataAdapter adapter =  new SqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
                instance = new DatabaseConnection();
            return instance;
        }

        public DataTable QuerySelected(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        private bool NonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {

                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    command.Connection.Close();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }
    }
}
