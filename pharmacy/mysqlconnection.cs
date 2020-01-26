using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pharmacy
{
    class mysqlconnection
    {
       static MySqlConnection connection;
       public static int ok = 0;
        public void conn()
        {
           
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Add("Database", "pharmacy");
            connBuilder.Add("Data Source", "localhost");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "24hoursnaya");

            connection = new MySqlConnection(connBuilder.ConnectionString);

            if (ok == 1) { Console.WriteLine("giye na"); }
            else
            {
                Console.WriteLine("yanne na");
                connection.Open();
                ok = 1;
                Console.WriteLine(ok);
            }

            // connection.Open();
         
        }
        MySqlDataReader msqlReader = null;
        public MySqlDataReader getdata(String sql)
        {
           

            try
            {
                //open the connection

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                //use a DataReader to process each record
              msqlReader = cmd.ExecuteReader();

             //   while (msqlReader.Read())
               // {
                 //   Console.WriteLine(msqlReader.GetString("username"));
                //}
            }
            catch (Exception er)
            {
                ok = 0;
                connection.Close();
                //do something with the exception
            }
            return msqlReader;
        }

        public MySqlDataReader updatedata(string sql) {

            try
            {
                //open the connection

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                //use a DataReader to process each record
                msqlReader = cmd.ExecuteReader();

                //   while (msqlReader.Read())
                // {
                //   Console.WriteLine(msqlReader.GetString("username"));
                //}
            }
            catch (Exception er)
            {
                ok = 0;
                connection.Close();
                //do something with the exception
            }
            return msqlReader;

        }
    }
}
