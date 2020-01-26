using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pharmacy
{
    public partial class salarypayment_window : Form
    {
        public salarypayment_window()
        {
            InitializeComponent();
        }

        int uidzz = 0;
        string unamez = "";
        public salarypayment_window(int uid,string uname)
        {
            InitializeComponent();

            uidzz = uid;
            unamez = uname;

            uidlabal.Text = uid.ToString();
            unamezzz.Text = unamez;

            fillcombo();

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            main_window mra = (main_window)this.Owner;

            mra.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            main_window am = (main_window)this.Owner;

            this.WindowState = FormWindowState.Minimized;

            am.bunifuFlatButton2_Click(sender, e);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            closebutton_Click(sender, e);
        }

        private void salarypayment_window_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void fillcombo()
        {
            string query48 = "select * from useraccounts;";
            dbconnection ab = new dbconnection();
            ab.openconnection();
            ab.command(query48);

            int word = 0;


            while (ab.readdata().Read())
            {
                word = ab.readdata().GetInt32("userid");

                combo_add_name.Items.Add(word);
            }

        }

        public void combo_add_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selecting = combo_add_name.Text;

                dbconnection ac = new dbconnection();
                ac.openconnection();
                string query64 = "select * from useraccounts where userid='" + selecting + "';";
                ac.command(query64);

                string firstname = "";
                string lastname = "";
                string surname = "";

                while (ac.readdata().Read()) {
                    firstname = ac.readdata().GetString("firstname");
                    lastname = ac.readdata().GetString("lastname");
                    surname = ac.readdata().GetString("surname");
                }
                ac.closeconnection();
                full_name_label.Text = surname + " " + firstname + " " + lastname;

                dbconnection ab = new dbconnection();

                string query48 = "select billno as 'Transaction No',type as 'Type', amount as 'Paid Amount',rebillno as 'Recorrected Bill No',paiduserid as 'Paid User ID',paidusername as 'Paid User Name',date as 'Date',time as 'Time' from pharmacy.salarybills where userid='" + selecting + "' ;";

                ab.openconnection();
                ab.command(query48);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = ab.command(query48);
                DataTable abc = new DataTable();
                sda.Fill(abc);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = abc;
                dataGridView1.DataSource = bsourse;
                sda.Update(abc);

                ab.closeconnection();








            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_qty_add_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void butto_pay_Click(object sender, EventArgs e)
        {
            string selecting = combo_add_name.Text;

            string firstname = "";
            string lastname = "";
            string surname = "";
            string username = "";

            dbconnection ac = new dbconnection();

            try
            {
              

                
                ac.openconnection();
                string query64 = "select * from useraccounts where userid='" + selecting + "';";
                ac.command(query64);

               

                while (ac.readdata().Read()) {
                    firstname = ac.readdata().GetString("firstname");
                    lastname = ac.readdata().GetString("lastname");
                    surname = ac.readdata().GetString("surname");
                    username = ac.readdata().GetString("usernames");
                }
                ac.closeconnection();

                
                string fullname= surname + " " + firstname + " " + lastname;
                ac.openconnection();
                int oldbilno = 0;
                string query66 = "select * from lastthings;";
                ac.command(query66);
                while (ac.readdata().Read()) {
                    oldbilno = ac.readdata().GetInt32("salaryinvoice");

                }
                ac.closeconnection();
                int newbilno = oldbilno + 1;

                if (fullname == full_name_label.Text)
                {
                    if (text_amount.Text == "")
                    {
                        MessageBox.Show("Enter the amount");
                    }
                    else {
                        string fname = firstname;
                        string lname = lastname;
                        string uname = username;
                        string uid = selecting;
                        int newbilnoz = newbilno;
                        string type = "Payment";
                        double amount = double.Parse(text_amount.Text);
                        string paiduid = uidlabal.Text;
                        string paiduname = unamezzz.Text;
                        DateTime dt = DateTime.Now;
                        string datenow = dt.ToString("yyyy-MM-dd");
                        string timenow = dt.ToString("HH:mm:ss");

                        ac.openconnection();
                        string query67 = "insert into salarybills(firstname,lastname,username,userid,billno,type,amount,paiduserid,paidusername,date,time)values('"+fname+"','"+lname+"','"+uname+"','"+uid+"','"+newbilnoz+"','"+type+"','"+amount+"','"+paiduid+"','"+paiduname+"','"+datenow+"','"+timenow+"')";
                        ac.command(query67).ExecuteNonQuery();
                        ac.closeconnection();

                        ac.openconnection();
                        string query68 = "update lastthings set salaryinvoice='" + newbilno + "' where salaryinvoice='" + oldbilno + "';";
                        ac.command(query68).ExecuteNonQuery();
                        ac.closeconnection();


                        combo_add_name_SelectedIndexChanged(sender, e);

                    }
                   
                }

                else {
                    MessageBox.Show("Choose empolyee again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

             }
        }

        private void text_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void text_rebillnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void text_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                butto_pay_Click(sender, e);
            }
        }

        private void button_recorrect_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection ab = new dbconnection();
             
                bool sname = false;

                if (combo_add_name.SelectedIndex > -1)
                {

                    sname = true;
                }

                bool correct = false;
                double oldsalary = 0;
                int renum = Int32.Parse(text_rebillnum.Text);
                ab.openconnection();
                string query68 = "select * from salarybills where billno='" + renum + "' and userid='" + combo_add_name.Text + "';";
                ab.command(query68);
                while (ab.readdata().Read()) {
                    correct = true;
                    
                }
                ab.closeconnection();

                if (text_rebillnum.Text == "")
                {
                    MessageBox.Show("Enter Transaction No");

                }
                else {
                    if (sname == true && correct == true) {
                        ab.openconnection();
                        string query69 = "select * from salarybills where billno='" + text_rebillnum.Text + "';";
                        string btype = "";
                        ab.command(query69);
                        while (ab.readdata().Read()) {
                            btype = ab.readdata().GetString("type");
                        }
                        ab.closeconnection();


                        dbconnection ac = new dbconnection();
                        bool re = false;
                        string query70 = "select * from salarybills where rebillno='" + text_rebillnum.Text + "';";
                        ac.openconnection();
                        ac.command(query70);

                        while (ac.readdata().Read()) {
                            re = true;
                        }
                        ac.closeconnection();



                        if (btype == "Re-Correction")
                        {
                            MessageBox.Show("You can't Re-Correction this Transaction");
                        }
                        else if (re == true)
                        {
                            MessageBox.Show("this transaction already has been Re - corrected");
                        }
                        else {
                            yesnofrm cc = new yesnofrm(10);
                            cc.Owner = this;
                            cc.warningtext = "Are You Sure To Re-Correct ?";
                            cc.Show();
                            this.Enabled = false;

                        }


                    }
                    else { 
                        MessageBox.Show("Bill no is not existing with this user or invalied bill number");
                        }
                }
            
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public void recorrectz() {
            try
            {
                dbconnection ab = new dbconnection();
                ab.openconnection();
                string query70 = "select * from lastthings ;";
                int oldbillno = 0;
                ab.command(query70);
                while (ab.readdata().Read())
                {
                    oldbillno = ab.readdata().GetInt32("salaryinvoice");
                }
                ab.closeconnection();


                string firstname = "";
                string lastname = "";
                string username = "";
               

                ab.openconnection();
                string query71 = "select * from useraccounts where userid='" + combo_add_name.Text + "';";
                ab.command(query71);
                while (ab.readdata().Read()) {
                    firstname = ab.readdata().GetString("firstname");
                    lastname = ab.readdata().GetString("lastname");
                    username = ab.readdata().GetString("usernames");
                }

                string fname = firstname;
                string lname = lastname;
                string uname = username;
                string uid = combo_add_name.Text;
                int newbillno = oldbillno + 1;
                string type = "Re-Correction";
                string renum = text_rebillnum.Text;
                string puid = uidlabal.Text;
                string puname = unamezzz.Text;
                DateTime dt = DateTime.Now;
                string datenow = dt.ToString("yyyy-MM-dd");
                string timenow = dt.ToString("HH:mm:ss");

                string query72 = "insert into salarybills (firstname,lastname,username,userid,billno,type,rebillno,paiduserid,paidusername,date,time)values('" + fname + "','" + lname + "','" + uname + "','" + uid + "','" + newbillno + "','" + type + "','" + renum + "','" + puid + "','" + puname + "','" + datenow + "','" + timenow + "');";
                ab.openconnection();
                ab.command(query72).ExecuteNonQuery();
                ab.closeconnection();

                ab.openconnection();
                string query68 = "update lastthings set salaryinvoice='" + newbillno + "' where salaryinvoice='" + oldbillno + "';";
                ab.command(query68).ExecuteNonQuery();
                ab.closeconnection();

               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_rebillnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button_recorrect_Click(sender, e);            }
        }

        private void text_stock_serchbox_TextChanged(object sender, EventArgs e)
        {
           string keyword = text_stock_serchbox.Text;

            if (keyword != null)
            {
                String query9 = "select billno as 'Transaction No',type as 'Type',amount as 'Paid Amount',rebillno as 'Recorrected Bill No',paiduserid as 'Paid User ID',paidusername as 'Paid User Name',date as 'Date',time as 'Time' from salarybills where userid='"+combo_add_name.Text+ "' and (billno like '%" + keyword + "%' or type like '%" + keyword + "%' or date like '%" + keyword + "%' or rebillno like '%" + keyword + "%' );";

                dbconnection dbs = new dbconnection();
                dbs.openconnection();

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbs.command(query9);
                DataTable dbtab = new DataTable();
                sda.Fill(dbtab);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = dbtab;
                dataGridView1.DataSource = bsourse;
                sda.Update(dbtab);


            }
            else
            {

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void text_nohour_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void text_nominutes_TextChanged(object sender, EventArgs e)
        {
            if (text_nominutes.Text == "") {
                text_nominutes.Text = "0";
            }
            

            int keymin = Int32.Parse(text_nominutes.Text);

            if (keymin > 60 ) {
                MessageBox.Show("minutes are wrong");
                           }
        }
    }
}
