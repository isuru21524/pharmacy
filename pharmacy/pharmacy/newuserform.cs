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
    public partial class newuserform : Form
    {
        public newuserform()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            main_window mra = (main_window)this.Owner;

            mra.Enabled = true;
            mra.dataview();
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            main_window am = (main_window)this.Owner;

            this.WindowState = FormWindowState.Minimized;

            am.bunifuFlatButton2_Click(sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void newuserform_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection db = new dbconnection();

                string query33 = "select userid from lastthings;";

                db.openconnection();
                db.command(query33);

                int olduid = 0;
                while (db.readdata().Read())
                {
                    olduid = db.readdata().GetInt32("userid");
                }
                int z = olduid + 1;
                text_uid.Text = z.ToString();

                db.closeconnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        private void button_createnew_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_firstname.Text == "" || text_lastname.Text == "" || text_surname.Text == "" || text_nicnumber.Text == "" || text_mnumber.Text == "" || text_addnum.Text == "" || text_addstreet.Text == "" || text_addtown.Text == "" || text_type.Text == "" || text_username.Text == "" || text_newpassword.Text == "" || text_repass.Text == "")
                {
                    MessageBox.Show("You cannot keep blank fields ");
                }

                else
                {
                    
                    if (!text_type.Text.Contains("MainAdmin") && !text_type.Text.Contains("Admin") && !text_type.Text.Contains("User"))
                    {
                        MessageBox.Show("You have selected wrong Account type ");
                    }
                    else if (text_newpassword.Text.Length <8)
                    {
                        MessageBox.Show("Password must be contained atleast 8 characters");
                    }
                    else if (text_repass.Text != text_newpassword.Text)
                    {
                        MessageBox.Show("New password and re-enter password are not  matching");
                    }
                    else {
                       yesnofrm bb = new yesnofrm(7);
                        
                        bb.Owner = this;
                        bb.warningtext = "Do you Want to create Account";
                        this.Enabled = false;
                        bb.Show();


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void savedata() {
            try
            {
                dbconnection ac = new dbconnection();

                string querry33 = "insert into useraccounts values('" + text_username.Text + "','" + text_newpassword.Text + "','" + text_type.Text + "','" + Int32.Parse(text_uid.Text) + "','"+text_firstname.Text+"','"+text_lastname.Text+"','"+text_surname.Text+"','"+ text_date.Text + "','"+text_nicnumber.Text+"','"+text_mnumber.Text+"','"+text_addnum.Text+"','"+text_addstreet.Text+"','"+text_addtown.Text+"');";

                ac.openconnection();
                ac.command(querry33).ExecuteNonQuery();
                ac.closeconnection();

                int olid = Int32.Parse(text_uid.Text) - 1;

                string query34 = "update lastthings set userid='" + text_uid.Text+ "' where userid='" +olid + "';";

                ac.openconnection();
                ac.command(query34).ExecuteNonQuery();
                ac.closeconnection();

                MessageBox.Show("Account created");

                int newid = Int32.Parse(text_uid.Text) + 1;
                text_uid.Text = newid.ToString();

                text_firstname.Text = "";
                text_lastname.Text = "";
                text_surname.Text = "";
                text_nicnumber.Text = "";
                text_mnumber.Text = "";
                text_addnum.Text = "";
                text_addstreet.Text = "";
                text_addtown.Text = "";
                text_type.Text = "";
                text_username.Text = "";
                text_newpassword.Text = "";
                text_repass.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closebutton_Click(sender, e);
        }

        private void button_clearall_Click(object sender, EventArgs e)
        {
            text_firstname.Text = "";
            text_lastname.Text = "";
            text_surname.Text = "";
            text_nicnumber.Text = "";
            text_mnumber.Text = "";
            text_addnum.Text = "";
            text_addstreet.Text = "";
            text_addtown.Text = "";
            text_type.Text = "";
            text_username.Text = "";
            text_newpassword.Text = "";
            text_repass.Text = "";
        }

        private void newuserform_Shown(object sender, EventArgs e)
        {
            text_firstname.Focus();
        }

        private void text_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_lastname.Focus();
            }
        }

        private void text_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_surname.Focus();
            }
        }

        private void text_surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_date.Focus();
            }
        }

        private void text_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_nicnumber.Focus();
            }
        }

        private void text_nicnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_mnumber.Focus();
            }
        }

        private void text_addnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_addstreet.Focus();
            }
        }

        private void text_addstreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_addtown.Focus();
            }
        }

        private void text_addtown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_type.Focus();
            }
        }

        private void text_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_username.Focus();
            }
        }

        private void text_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_newpassword.Focus();
            }
        }

        private void text_newpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_repass.Focus();
            }
        }

        private void text_repass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_createnew_Click(sender, e);
            }
        }

        private void text_mnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_addnum.Focus();
            }
        }
    }
}
