using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace pharmacy
{
    class dbconnection
    {

        public static MySqlConnection conn=null;
        public static MySqlCommand cmd=null;
        public static MySqlDataReader dataread=null;
        public  MySqlConnection openconnection() {
            try
            {

                MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

                connBuilder.Add("Database", "pharmacy");
                connBuilder.Add("Data Source", "localhost");
                connBuilder.Add("User Id", "root");
                connBuilder.Add("Password", "your password");

                conn = new MySqlConnection(connBuilder.ConnectionString);
                conn.Open();
                return conn;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              
            }
            return conn;
        }

        public bool closeconnection() {
            try {
                conn.Close();
                return true;
               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            }
          
        }

        public MySqlCommand command(String query)
        {
            try
            {
                 cmd = new MySqlCommand(query,conn);
                return cmd;
            }
            catch (Exception )
            {
                closeconnection();
            }
            return cmd;
           
            
        }
        public MySqlDataReader readdata() {
            try
            {
                 dataread = cmd.ExecuteReader();
                
            }
            catch (Exception )
            {
              
                
            }
            return dataread;

        }
    }
}
