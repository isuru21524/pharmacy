using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pharmacy
{
    public partial class login_window : Form
    {
        backpanel bc = new backpanel();

        public login_window()
        {

           
           
            
           InitializeComponent();

            login_username_tbox.Focus();

            this.login_password_tbox.isPassword = true;

           
            bc.Show();
            this.Owner = bc;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            bc.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_tbox_Click(object sender, EventArgs e)
        {

        }

        private void login_username_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                login_password_tbox.Focus();

            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)


        {
            dbconnection ob = new dbconnection();

            try
            {
                string username = login_username_tbox.Text;
                string password = login_password_tbox.Text;

                string query = "select * from useraccounts where usernames='" + username + "' and password='" + password + "';";
              

                ob.openconnection();
                ob.command(query);
              

                bool correct = false;
               
                int uid = 0;
                string type = "";
                string firstname = "";
                while (ob.readdata().Read())
                {
                    correct = true;
                   
                    uid = ob.readdata().GetInt32("userid");
                    type = ob.readdata().GetString("type");
                    firstname = ob.readdata().GetString("firstname");

                }
              

                if (correct == true)
                {

                    if (type == "MainAdmin")
                    {
                        main_window ab = new main_window(uid,type,firstname);

                        ab.Show();
                        this.Hide();
                        bc.Hide();
                    }
                    else if (type == "Admin")
                    {
                        main_window ab = new main_window(uid,type,firstname);

                        ab.Show();
                        this.Hide();
                        bc.Hide();
                    }
                    else if (type == "User") {
                        main_window ab = new main_window(uid,type,firstname);

                        ab.Show();
                        this.Hide();
                        bc.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("invalid user name or password, type again correctly");
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }

            ob.closeconnection();

        } 

        private void login_username_tbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void login_password_tbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void login_password_tbox_Enter(object sender, EventArgs e)
        {
            this.login_password_tbox.isPassword = true;
        }

        private void login_username_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char enter = e.KeyChar;
            string word = login_username_tbox.Text;
            if (enter == ' ') {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                MessageBox.Show("you can not keep space in the username");
       

            }
           
           
            
        }

        private void login_window_Load(object sender, EventArgs e)
        {
           
        }

        private void login_password_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                bunifuFlatButton6_Click(sender, e);
            }
        }
    }
}
