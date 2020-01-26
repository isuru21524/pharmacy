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
    public partial class customer_window : Form
    {
        public customer_window()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void customer_window_Load(object sender, EventArgs e)
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

            try
            {
                dbconnection db = new dbconnection();
                db.openconnection();
                string query75 = "select * from lastthings;";
                db.command(query75);
                int cusid = 0;
                while (db.readdata().Read()) {
                    cusid = db.readdata().GetInt32("cusid");
                }
                db.closeconnection();
                text_uid.Text = (cusid + 1).ToString();

                string query77 = "select customerid as 'Customer ID',firstname as 'First Name',lastname as 'Last Name',surname as 'Sure Name',dob as 'Date of Birth',nic as 'NIC No',mobile as 'Mobile',address1 as 'Address line1',address2 as 'Address line2',address3 as 'Address line3' from customer;";


                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = db.command(query77);
                DataTable abc = new DataTable();
                sda.Fill(abc);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = abc;
                dataGridView1.DataSource = bsourse;
                sda.Update(abc);


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
                int uidz = Int32.Parse(text_uid.Text);
                string fname = text_firstname.Text;
                string lname = text_lastname.Text;
                string surname = text_surname.Text;
                string date = text_date.Text;
                string nic = text_nicnumber.Text;
                string mobile = text_mnumber.Text;
                string add1 = text_addnum.Text;
                string add2 = text_addstreet.Text;
                string add3 = text_addtown.Text;


                dbconnection db = new dbconnection();
                string query76 = "insert into customer values('" + uidz + "','" + fname + "','" + lname + "','" + surname + "','" + date + "','" + nic + "','" + mobile + "','" + add1 + "','" + add2 + "','" + add3 + "');";
                db.openconnection();
                db.command(query76).ExecuteNonQuery();
                db.closeconnection();

                int oldid = 0;
                oldid = uidz - 1;

                db.openconnection();
                string query77 = "update lastthings set cusid='" + uidz + "' where cusid='" + oldid + "';";
                db.command(query77).ExecuteNonQuery();
                db.closeconnection();

                customer_window_Load(sender, e);


                text_uid.Clear();
                text_firstname.Clear();
                text_lastname.Clear();
                text_surname.Clear();
             
                text_nicnumber.Clear();
                 text_mnumber.Clear();
                text_addnum.Clear();
                 text_addstreet.Clear();
                text_addtown.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button_clearall_Click(object sender, EventArgs e)
        {
            text_uid.Clear();
            text_firstname.Clear();
            text_lastname.Clear();
            text_surname.Clear();

            text_nicnumber.Clear();
            text_mnumber.Clear();
            text_addnum.Clear();
            text_addstreet.Clear();
            text_addtown.Clear();
        }

        private void customer_window_Shown(object sender, EventArgs e)
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

        private void text_mnumber_KeyDown(object sender, KeyEventArgs e)
        {
            text_addnum.Focus();
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
                button_createnew_Click(sender, e);
            }
        }

        private void text_stock_serchbox_TextChanged(object sender, EventArgs e)
        {
            string keyword = text_stock_serchbox.Text;

            if (keyword != null)
            {
                String query9 = "select customerid as 'Customer ID',firstname as 'First Name',lastname as 'Last Name',surname as 'Sure Name',dob as 'Date of Birth',nic as 'NIC No',mobile as 'Mobile',address1 as 'Address line1',address2 as 'Address line2',address3 as 'Address line3' from customer where customerid like '%"+keyword+"%' or firstname like '%" + keyword+"%' or lastname like '%" + keyword+ "%' or surname like '%" + keyword+"%'  ;";
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
    }
}
