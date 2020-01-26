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
    public partial class cashier_report_window : Form
    {
        public cashier_report_window()
        {
            InitializeComponent();
            fillcombo();

            text_cash_balance.Text = "0";
            text_visa_balance.Text = "0";
            text_total_balance.Text = "0";
        }

        private void cashier_report_window_Load(object sender, EventArgs e)
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

        private void button_recorrect_Click(object sender, EventArgs e)
        {
            bool sname = false;

            if (combo_add_name.SelectedIndex > -1) {
                sname = true;
            }

            bool reportexist = false;
           
            try
            {
                if (sname == true)
                {
                    dbconnection ac = new dbconnection();
                    ac.openconnection();
                    string query73 = "select * from cashier where userid='" + combo_add_name.Text + "' and date='" + UA_date.Text + "';";
                    ac.command(query73);
                    while (ac.readdata().Read()) {
                        reportexist = true;
                    }
                    ac.closeconnection();

                    if (reportexist == true)
                    {
                        ac.openconnection();
                        string query74 = "select billnumber as 'Transaction No',itemname as 'Item',quantity as 'Quantity',sellprice as 'Sells Price',discount as 'Discount',subtotal as 'Sub Total',total as 'Total',cash as 'Cash',visa as 'Visa',balance as 'Balance',returnamount as 'Return Amount',time as 'Time',username as 'User Name', selltype as 'Sells Type' from cashier where userid='" + combo_add_name.Text+"' and date='"+UA_date.Text+"';";

                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = ac.command(query74);
                        DataTable abc = new DataTable();
                        sda.Fill(abc);
                        BindingSource bsourse = new BindingSource();

                        bsourse.DataSource = abc;
                        dataGridView1.DataSource = bsourse;
                        sda.Update(abc);

                        ac.closeconnection();

                        ac.openconnection();
                        string type = "cash";
                        string query75 = "select sum(subtotal) from cashier where userid='" + combo_add_name.Text + "' and date='" + UA_date.Text + "' and selltype='"+type+"' ;";
                        
                        double mySum = Convert.ToDouble(ac.command(query75).ExecuteScalar());
                        text_cash_balance.Text = mySum.ToString();
                        text_total_balance.Text = text_cash_balance.Text;
                        ac.closeconnection();


                        dbconnection db = new dbconnection();
                        bool visa = false;
                        db.openconnection();
                        string tp = "visa";
                        string query77 = "select * from cashier where userid='"+combo_add_name.Text+"' and date='"+UA_date.Text+"' and selltype='" + tp + "';";
                        db.command(query77);
                        while (db.readdata().Read()) {
                            visa = true;
                        }
                        db.closeconnection();



                        if (visa == true) {
                            ac.openconnection();
                            string type1 = "visa";
                            string query76 = "select sum(subtotal) from cashier where userid='" + combo_add_name.Text + "' and date='" + UA_date.Text + "' and selltype='" + type1 + "' ;";
                           
                            double mySum1 = Convert.ToDouble(ac.command(query76).ExecuteScalar());
                            text_visa_balance.Text = mySum1.ToString();
                            ac.closeconnection();

                            text_total_balance.Text = (mySum + mySum1).ToString();
                        }



                    }
                    else {
                        MessageBox.Show("there are no records of this user for this date");
                        dataGridView1.Rows.Clear();
                    }
                }
                else {
                    MessageBox.Show("select user to open report");
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
        }

        private void text_stock_serchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = text_stock_serchbox.Text;

                if (keyword != null)
                {
                    String query9 = "select billnumber as 'Transaction No',itemname as 'Item' ,quantity as 'Quantity',sellprice as 'Sells Price',discount as 'Discount',subtotal as 'Sub Total',total as 'Total',cash as 'Cash',balance as 'Balance',returnamount as 'Return Amount',time as 'Time',username as 'User Name',selltype as 'Sells Type' from cashier where userid='" + combo_add_name.Text + "' and date='" + UA_date.Text + "' and billnumber like '%" + keyword + "%' ;";

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
