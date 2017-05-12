using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printinhackfest
{
    class DBHelper
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public DBHelper()
        {
            con = new SqlConnection("Data Source = printinDB.db");
            CreateTableUser();
            CreateTableFileDownload();
        }

        public void CreateTableUser()
        {
            con.Open();
            string query = "CREATE TABLE IF NOT EXISTS pengguna" +
                "(ID INTEGER AUTOINCREMENT, EMAIL TEXT, PASSWORD TEXT, NamaToko TEXT)";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void CreateTableFileDownload()
        {
            con.Open();
            string query = "CREATE TABLE IF NOT EXISTS pesanan" +
                "(ID INTEGER, ID_FILE INTEGER AUTOINCREMENT, FILENAME TEXT," +
                "JenisTinta INTEGER, TipeCetak INTEGER, STATUS INTEGER)";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertTableUser(string email, string password, string namaToko)
        {
            con.Open();
            string query = "INSERT INTO pengguna (EMAIL, PASSWORD, NamaToko)" +
                "values ('" + email + "','" + password + "','" + namaToko + "')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
