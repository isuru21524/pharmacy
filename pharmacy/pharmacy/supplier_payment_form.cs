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
    public partial class supplier_payment_form : Form
    {
        public supplier_payment_form()
        {
            InitializeComponent();
            fillcombo();
            bunifuThinButton21.Hide();
        }
        int uidz = 0;
        string unamez = "";
        public supplier_payment_form(int uid,string uname)
        {
            InitializeComponent();
            fillcombo();
            uidz = uid;
            unamez = uname;

            uidlabal.Text = uidz.ToString();
            unamezzz.Text = unamez;

            bunifuThinButton21.Hide();
        }

        string paytype = "";

        public void combo_choose_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                string selecting = combo_choose_supplier.Text;

                dbconnection ab = new dbconnection();

                string query48="select billno as 'Transaction No',type as 'Type',paymenttype as 'Payment Type', paidamount as 'Paid Amount',rebillno as 'Recorrected Bill No',userid as 'User ID',username as 'User Name',date as 'Date',time as 'Time' from pharmacy.supplierbills where suppliername='"+ selecting + "' ;";

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

                ab.openconnection();
                string query49 = "select * from suppliers where suppliername='" + selecting + "';";
                double oldamount = 0;
                int supid = 0;

                ab.command(query49);

                while (ab.readdata().Read()) {
                    oldamount = ab.readdata().GetDouble("creditbalance");
                    supid = ab.readdata().GetInt32("supplierid");
                }

                text_supid.Text = supid.ToString();
                text_cred_balance.Text = oldamount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
        }

        private void supplier_payment_form_Load(object sender, EventArgs e)
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
            string query48 = "select * from suppliers;";
            dbconnection ab = new dbconnection();
                ab.openconnection();
            ab.command(query48);

            string word = "";


            while (ab.readdata().Read()) {
                word = ab.readdata().GetString("suppliername");

                combo_choose_supplier.Items.Add(word);
            }

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_pay_Click(object sender, EventArgs e)
        {

            bool type = false;
            string selecting = combo_choose_supplier.Text;

            if (paytype == "Cash" || paytype == "Cheque" || paytype == "Cash and Cheque")
            {
                type = true;
            }

            bool sname = false;

            if (combo_choose_supplier.SelectedIndex > -1)
            {
                sname = true;
            }

            try
            {
                if (type == true && sname == true && text_payment.Text != "")
                {
                    yesnofrm cc = new yesnofrm(8);
                    cc.Owner = this;
                    cc.warningtext = "Are You Sure To Pay ?";
                    cc.Show();
                    this.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Check the supplier name , payment type or Amount");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "Cash";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "Cheque";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            paytype = "Cash and Cheque";
        }

        private void text_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void text_payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button_pay_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        public void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection ac = new dbconnection();
                double oldamount = 0;
                string selecting = combo_choose_supplier.Text;
                string query49 = "select * from  suppliers where suppliername='" + selecting + "'; ";
                ac.openconnection();
                ac.command(query49);

                while (ac.readdata().Read())
                {
                    oldamount = ac.readdata().GetDouble("creditbalance");
                }
                ac.closeconnection();

                double payment = double.Parse(text_payment.Text);

                double newcreditbalance = oldamount - payment;
                text_cred_balance.Text = newcreditbalance.ToString();

                ac.openconnection();
                string query50 = "update suppliers set creditbalance='" + newcreditbalance + "' where suppliername='" + selecting + "';";
                ac.command(query50).ExecuteNonQuery();
                ac.closeconnection();

                int oldbillnumber = 0;
                ac.openconnection();
                string query51 = "select * from lastthings;";
                ac.command(query51);
                while (ac.readdata().Read())
                {
                    oldbillnumber = ac.readdata().GetInt32("supplierinvoice");
                }
                ac.closeconnection();


                string supname = combo_choose_supplier.Text;
                int newbillnumber = oldbillnumber + 1;
                string typez = "Payment";
                string paymenttype = paytype;
                double paidamount = double.Parse(text_payment.Text);
                string userid = uidlabal.Text;
                string username = unamezzz.Text;
                DateTime dt = DateTime.Now;
                string datenow = dt.ToString("yyyy-MM-dd");
                string timenow = dt.ToString("HH:mm:ss");

                ac.openconnection();
                string query52 = "insert into supplierbills(suppliername,billno,type,paymenttype,paidamount,userid,username,date,time)values('" + supname + "','" + newbillnumber + "','" + typez + "','" + paymenttype + "','" + paidamount + "','" + userid + "','" + username + "','" + datenow + "','" + timenow + "');";
                ac.command(query52).ExecuteNonQuery();


                string query53 = "update lastthings set supplierinvoice='" + newbillnumber + "' where supplierinvoice='" + oldbillnumber + "';";
                ac.command(query53).ExecuteNonQuery();
                ac.closeconnection();


                combo_choose_supplier_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void button_recorrect_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection db = new dbconnection();

                bool sname = false;

                if (combo_choose_supplier.SelectedIndex > -1)
                {
                    sname = true;
                }

                bool billnumber = false;
                int billnums = Int32.Parse(text_rebillnum.Text);
                db.openconnection();
                string query54 = "select * from supplierbills where suppliername='" + combo_choose_supplier.Text + "' and billno='" + billnums + "';";
                db.command(query54);
                while (db.readdata().Read()) {
                    billnumber = true;
                }
                db.closeconnection();

                int rebno = Int32.Parse(text_rebillnum.Text);
                string btype = "";
                db.openconnection();
                string query61 = "select * from supplierbills where billno='" + rebno + "';";
                db.command(query61);
                while (db.readdata().Read())
                {
                    btype = db.readdata().GetString("type");
                }
                db.closeconnection();

                bool re = false;
                db.openconnection();
                string query62 = "select * from supplierbills where rebillno='" + Int32.Parse(text_rebillnum.Text) + "';";
                db.command(query62);
                while (db.readdata().Read()) {
                    re = true;
                }



                if (sname == true && billnumber == true)
                {
                    if (btype == "Re-Correction")
                    {
                        MessageBox.Show("You can't Re-Correction this Transaction");
                    }
                    else if (re==true) {
                        MessageBox.Show("this transaction already has been Re-corrected");
                    }
                    else {
                        yesnofrm cc = new yesnofrm(9);
                        cc.Owner = this;
                        cc.warningtext = "Are You Sure To Re-Correct ?";
                        cc.Show();
                        this.Enabled = false;


                    }
                }
                

                else
                {
                    MessageBox.Show("Bill no is not existing with this supplier or invalied bill number");
                }

                
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void recorrectionz() {
            try
            {
                dbconnection db = new dbconnection();

                int rebilno = Int32.Parse(text_rebillnum.Text);

                string query55 = "select * from supplierbills where billno='" + rebilno + "';";
                db.openconnection();
                db.command(query55);

                double oldamount = 0;
                while (db.readdata().Read()) {
                    oldamount = db.readdata().GetDouble("paidamount");
                }
                db.closeconnection();


                
                db.openconnection();
                string query56 = "select * from suppliers where suppliername='" + combo_choose_supplier.Text + "';";
                db.command(query56);

                double supplieramount = 0;
                while (db.readdata().Read()) {
                    supplieramount = db.readdata().GetDouble("creditbalance");
                }
                db.closeconnection();

                db.openconnection();

                double newamount = supplieramount + oldamount;
                string query57 = "update suppliers set creditbalance='" + newamount + "' where suppliername='" + combo_choose_supplier.Text + "';";
                db.command(query57).ExecuteNonQuery();
                db.closeconnection();

                int oldbillnum = 0;
                db.openconnection();
                string query58 = "select * from lastthings ;";
                db.command(query58);
                while (db.readdata().Read()) {
                    oldbillnum = db.readdata().GetInt32("supplierinvoice");
                }
                db.closeconnection();


                string supname = combo_choose_supplier.Text;
                int newbillnum = oldbillnum + 1;
                string typezz = "Re-Correction";
                int rebilnoz = Int32.Parse(text_rebillnum.Text);
                string userid = uidlabal.Text;
                string uname = unamezzz.Text;
                DateTime dt = DateTime.Now;
                string datenow = dt.ToString("yyyy-MM-dd");
                string timenow = dt.ToString("HH:mm:ss");


                db.openconnection();
                string query59 = "insert into supplierbills(suppliername,billno,type,rebillno,userid,username,date,time)values('" + supname + "','" + newbillnum + "','" + typezz + "','" + rebilnoz + "','" + userid + "','" + uname + "','" + datenow + "','" + timenow + "') ;";
                db.command(query59).ExecuteNonQuery();
                db.closeconnection();

                db.openconnection();
                string query60 = "update lastthings set supplierinvoice='" + newbillnum + "' where supplierinvoice='"+oldbillnum+"';";
                db.command(query60).ExecuteNonQuery();
                db.closeconnection();
               






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_rebillnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_recorrect_Click(sender, e);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closebutton_Click(sender, e);
        }

        private void text_stock_serchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = text_stock_serchbox.Text;

                if (keyword != null)
                {
                    String query9 = "select billno as 'Transaction No',type as 'Type',paymenttype as 'Payment Type',paidamount as 'Paid Amount',rebillno as 'Re-Corrected Bill No',userid as 'User ID',username as 'User Name',date as 'Date',time as 'Time' from supplierbills where suppliername='" + combo_choose_supplier.Text + "' and (billno  like '%" + keyword + "%' or rebillno like '%" + keyword + "%' or type like '%" + keyword + "%' or paymenttype like '%" + keyword + "%' or date like '%" + keyword + "%');";

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
