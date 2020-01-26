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
    public partial class main_window : Form
    {
        dbconnection db = new dbconnection();
        static  int butnumber = 2;
        static int stock_butnumber=2;
        static int supnumber = 2;
        static int uaccountnumber = 2;
        static int reportnumber = 2;
        static int cashnum = 2;
        static string abc = "";
        static int pidpid = 0;

        static int lastsupnumber = 0;
        backpanel cd = new backpanel();
        int uid;
        string uname = "";
        string ffname = "";
      
        public main_window()
        {
            InitializeComponent();
            
            cd.Show();
            this.Owner = cd;

            user_setting.SendToBack();

            buttonscroll.Hide();
            setingbar.Hide();
           




        }
        public main_window(int id,string type,string fname)
        {
            InitializeComponent();
            

            cd.Show();
            this.Owner = cd;

            uid = id;
            uidlabal.Text = uid.ToString();

            ffname = fname;
            lfname.Text = ffname;

            user_setting.SendToBack();
            buttonscroll.Hide();
            setingbar.Hide();




        }

       


        yesnofrm ob;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (ob == null)
            {
                ob = new yesnofrm(1);
                ob.Owner = this;
                ob.FormClosed += new FormClosedEventHandler(ob_FormClosed);
                ob.warningtext = "Are you sure.Do You Want to Logout?";
                ob.Show();
                this.Enabled = false;
            }
            else
                ob.Activate();
             
           
        }

        void ob_FormClosed(object sender, FormClosedEventArgs e)
        {
            ob = null;

        }

        


        public void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            cd.WindowState = FormWindowState.Minimized;
        }
       
        

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void maxbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mainl_logout_button_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1_Click(sender, e);
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {

            try
            {
                if ((butnumber % 2) == 0)
                {


                    String query1 = "select * from useraccounts where userid='" + uid + "';";

                    db.openconnection();
                    db.command(query1);

                    string firstname = "";
                    string lastname = "";
                    string surname = "";
                    // string uname = "";  meka udata damma ;
                    string nid = "";
                    string mobile = "";
                    string addnum = "";
                    string addstreet = "";
                    string addtown = "";
                    DateTime dob = new DateTime();






                    while (db.readdata().Read())
                    {


                        firstname = db.readdata().GetString("firstname");
                        lastname = db.readdata().GetString("lastname");
                        surname = db.readdata().GetString("surname");
                        dob = db.readdata().GetDateTime("dob");
                        nid = db.readdata().GetString("nationalid");
                        mobile = db.readdata().GetString("mobile");
                        addnum = db.readdata().GetString("addressnum");
                        addstreet = db.readdata().GetString("addressstreet");
                        addtown = db.readdata().GetString("addresstown");
                        uname = db.readdata().GetString("usernames");




                    }


                    bsurname.Text = surname;
                    fir_and_las_name.Text = firstname + " " + lastname;

                    bmobinum.Text = mobile;
                    bnidnum.Text = nid;
                    baddrnum.Text = "No " + addnum + ",";
                    baddrstreeet.Text = addstreet + ",";
                    baddrtown.Text = addtown;
                    bdob.Text = dob.ToString("yyyy/MM/dd");
                    tusername.Text = uname;

                    this.toldpas.isPassword = true;
                    this.tnewpas.isPassword = true;
                    this.trenewpass.isPassword = true;

                    setingbar.Show();

                    supplier_panel.Hide();
                    stock_panel.Hide();
                    useraccount_panel.Hide();
                    cashier_panel.Hide();
                    user_setting.BringToFront();
                    
                    user_setting.Show();
                   

                   setingbar.Width=47;
                    setingbar.Top = settingbutton.Bottom;
                    buttonscroll.Hide();
                    

                }
                else
                {
                    user_setting.SendToBack();
                    setingbar.Hide();
                    toldpas.Text = "";
                    tnewpas.Text = "";
                    trenewpass.Text = "";
                   
                }
                butnumber += 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            db.closeconnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void main_cashier_button_Click(object sender, EventArgs e)
        {


            if (cashnum % 2 == 0)
            {
                buttonscroll.Show();
                buttonscroll.Height = main_cashier_button.Height;
                buttonscroll.Top = main_cashier_button.Top;

                user_setting.BringToFront();
                stock_panel.Show();
                supplier_panel.Show();
                useraccount_panel.Show();
                report_panel.Hide();
                cashier_panel.Show();
            }
            else {
                useraccount_panel.Hide();
                buttonscroll.Hide();
                setingbar.Hide();
                user_setting.SendToBack();
            }
            cashnum += 1;
        }

       public void main_usacc_button_Click(object sender, EventArgs e)
        {
            try
            {
                if ((uaccountnumber % 2) == 0)
                {

                    buttonscroll.Show();
                    buttonscroll.Height = main_usacc_button.Height;
                    buttonscroll.Top = main_usacc_button.Top;

                    setingbar.Hide();

                    user_setting.BringToFront();
                    stock_panel.Show();
                    supplier_panel.Show();
                    report_panel.Hide();
                    cashier_panel.Hide();
                    useraccount_panel.Show();


                    dbconnection db = new dbconnection();

                    string query30 = "select userid as 'User ID', firstname as 'First Name',lastname as 'Last Name',type as 'Type' from pharmacy.useraccounts;";
                    db.openconnection();
                    db.command(query30);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = db.command(query30);
                    DataTable dbtab = new DataTable();
                    sda.Fill(dbtab);
                    BindingSource bsourse = new BindingSource();

                    bsourse.DataSource = dbtab;
                    dataGridView2.DataSource = bsourse;
                    sda.Update(dbtab);

                    db.closeconnection();


                    dataGridView2.BorderStyle = BorderStyle.None;
                    dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                    dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                    dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                    dataGridView2.BackgroundColor = Color.White;

                    dataGridView2.EnableHeadersVisualStyles = false;
                    dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                    dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dataGridView2.Enabled = true;

                }
                else {
                    stock_panel.Hide();
                    buttonscroll.Hide();
                    setingbar.Hide();
                    user_setting.SendToBack();
                }
            }
            catch (Exception)
            {


                throw;
            }
            uaccountnumber += 1;


        }

        public void dataview() {
            dbconnection db = new dbconnection();

            string query30 = "select userid as 'User ID', firstname as 'First Name',lastname as 'Last Name',type as 'Type' from pharmacy.useraccounts;";
            db.openconnection();
            db.command(query30);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = db.command(query30);
            DataTable dbtab = new DataTable();
            sda.Fill(dbtab);
            BindingSource bsourse = new BindingSource();

            bsourse.DataSource = dbtab;
            dataGridView2.DataSource = bsourse;
            sda.Update(dbtab);

            db.closeconnection();


            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.Enabled = true;
        }

        private void main_stock_button_Click(object sender, EventArgs e)
        {
           

            try
            {
                if ((stock_butnumber % 2) == 0)
                {
                    buttonscroll.Show();
                    buttonscroll.Height = main_stock_button.Height;
                    buttonscroll.Top = main_stock_button.Top;

                    setingbar.Hide();

                    user_setting.BringToFront();
                    useraccount_panel.Hide();
                    supplier_panel.Hide();
                    cashier_panel.Hide();
                    report_panel.Hide();
                    stock_panel.Show();
                }
                else {

                    stock_panel.Hide();
                    buttonscroll.Hide();
                    setingbar.Hide();
                    user_setting.SendToBack();


                  
                
                }
            }
            catch (Exception)
            {

                throw;
            }
            stock_butnumber += 1;
        }

    public void main_sup_button_Click(object sender, EventArgs e)
        {
            try
            {
                


                if ((supnumber % 2) == 0)
                {
                    buttonscroll.Show();
                    buttonscroll.Height = main_sup_button.Height;
                    buttonscroll.Top = main_sup_button.Top;


                    setingbar.Hide();
                    user_setting.BringToFront();
                    useraccount_panel.Hide();
                    cashier_panel.Hide();
                    report_panel.Hide();
                    stock_panel.Show();
                    supplier_panel.Show();

                    clearlabel();


                    text_suppliername.Focus();

                    button_supplieradd.Hide();
                    dataGridView1.Enabled = true;
                    supplierdatagrid();

                   
                    

                }
                else {
                    buttonscroll.Hide();
                    setingbar.Hide();
                    
                    user_setting.SendToBack();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            supnumber += 1;
           
        }
        public void supplierdatagrid() {

            try
            {

                dbconnection ab = new dbconnection();
                string query25 = "select supplierid as 'Supplier ID',suppliername as 'Supplier Name',supplieraddress as 'Address', suppliertel as 'Tel/Mobile', supplieremail as 'E-mail Adrress' from pharmacy.suppliers ;";

                ab.openconnection();
                ab.command(query25);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = ab.command(query25);
                DataTable abc = new DataTable();
                sda.Fill(abc);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = abc;
                dataGridView1.DataSource = bsourse;
                sda.Update(abc);


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

                ab.closeconnection();

                ab.openconnection();
                string query26 = "select * from lastthings;";
                ab.command(query26);

             
                while (ab.readdata().Read())
                {
                   
                    pidpid = ab.readdata().GetInt32("supplierid");

                }

                label_supplierid.Text = (pidpid + 1).ToString ();
                ab.closeconnection();

                
                
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void main_report_button_Click(object sender, EventArgs e)
        {
            try
            {
                if ((reportnumber % 2) == 0)
                {
                    buttonscroll.Show();
                    buttonscroll.Height = main_report_button.Height;
                    buttonscroll.Top = main_report_button.Top;

                    user_setting.BringToFront();
                    stock_panel.Show();
                    supplier_panel.Show();
                    useraccount_panel.Show();

                    cashier_panel.Show();
                    report_panel.Show();
                }
                else {
                    useraccount_panel.Hide();
                    buttonscroll.Hide();
                    setingbar.Hide();
                    user_setting.SendToBack();
                }
                reportnumber += 1;
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
           
        }

        private void user_setting_Paint(object sender, PaintEventArgs e)  
        {

        }

        yesnofrm cc;
        private void bsettingchange_Click(object sender, EventArgs e)
        {

            if (tnewpas.Text.Length > 7 || (tnewpas.Text=="" && trenewpass.Text==""))
            {
                string usname = tusername.Text;
                string oldpas = toldpas.Text;
                string newpas = tnewpas.Text;
                string renewpas = trenewpass.Text;

                if (cc == null)
                {
                    cc = new yesnofrm(2, uid, usname, oldpas, newpas, renewpas, uname);
                    cc.Owner = this;
                    cc.FormClosed += new FormClosedEventHandler(cc_FormClosed);
                    cc.warningtext = "Are You Sure To Save Settings?";
                    cc.Show();
                    this.Enabled = false;
                }
                else
                    cc.Activate();
            }
           
            else {
                MessageBox.Show("Password must be contained atleast 8 characters");
            }
        }
        void cc_FormClosed(object sender, FormClosedEventArgs e)
        {
            cc = null;

        }

        private void bsettingcancel_Click(object sender, EventArgs e)
        {
            string query6 = "select * from useraccounts where userid='" + uid + "';";
            db.openconnection();
            db.command(query6);

            string uname="";

            while(db.readdata().Read())
            {
                uname = db.readdata().GetString("usernames");
            }
            tusername.Text = uname;
            toldpas.Text = "";
            tnewpas.Text = "";
            trenewpass.Text = "";

            
        }

        private void toldpas_Enter(object sender, EventArgs e)
        {
            this.toldpas.isPassword = true;
        }

        private void tnewpas_Enter(object sender, EventArgs e)
        {
            this.tnewpas.isPassword = true;
        }

        private void trenewpass_Enter(object sender, EventArgs e)
        {
            this.trenewpass.isPassword = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            buttonscroll.Hide();
            setingbar.Hide();

        }

        private void stock_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            stockform sf = new stockform();
            sf.Owner = this;
            sf.Show();
            this.Enabled = false;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            updateexitem_window uw = new updateexitem_window();
            uw.Owner = this;
            uw.Show();
            this.Enabled = false;

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            newitem_window uw = new newitem_window();
            uw.Owner = this;
            uw.Show();
            this.Enabled = false;
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_newquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplier_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection gg = new dbconnection();

                if (text_suppliername.Text == "" || text_supplieraddress.Text == "" || text_suppliertel.Text == "" || text_suppliereamail.Text == "")
                {
                    MessageBox.Show("You Can not keep Blnak Fields");
                }
                else {

                    if (abc == "doit")
                    {
                        if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == text_suppliername.Text)
                        {

                            string query27 = "update suppliers set suppliername='" + text_suppliername.Text + "',supplieraddress='" + text_supplieraddress.Text + "',suppliertel='" + text_suppliertel.Text + "',supplieremail='" + text_suppliereamail.Text + "' where supplierid='" + label_supplierid.Text + "';";



                      

                            gg.openconnection();
                            gg.command(query27).ExecuteNonQuery();
                            gg.closeconnection();

                            dataGridView1.Enabled = true;

                            supplierdatagrid();

                            int rownewnum = dataGridView1.Rows.Count - 1;
                            int newpidedit = Int32.Parse(dataGridView1.Rows[rownewnum].Cells[0].Value.ToString());

                            label_supplierid.Text = (newpidedit + 1).ToString();

                            clearlabel();

                            abc = "";

                            text_suppliername.Focus();
                        }
                        else {
                            string query29 = "select * from suppliers where suppliername='" + text_suppliername.Text + "';";
                            gg.openconnection();
                            gg.command(query29);

                            bool correct = false;

                            while (gg.readdata().Read()) {
                                correct = true;
                            }
                            gg.closeconnection();
                            if (correct == true)
                            {
                                MessageBox.Show("The supplier name that you entered is existing in the system.try another one");
                            }
                          
                            else {
                                string query27 = "update suppliers set suppliername='" + text_suppliername.Text + "',supplieraddress='" + text_supplieraddress.Text + "',suppliertel='" + text_suppliertel.Text + "',supplieremail='" + text_suppliereamail.Text + "' where supplierid='" + label_supplierid.Text + "';";





                                gg.openconnection();
                                gg.command(query27).ExecuteNonQuery();
                                gg.closeconnection();

                                dataGridView1.Enabled = true;

                                supplierdatagrid();

                                int rownewnum = dataGridView1.Rows.Count - 1;
                                int newpidedit = Int32.Parse(dataGridView1.Rows[rownewnum].Cells[0].Value.ToString());

                                label_supplierid.Text = (newpidedit + 1).ToString();
                                clearlabel();
                                abc = "";
                                text_suppliername.Focus();
                            }

                            
                        }
                        

                    }
                    else {
                        string query29 = "select * from suppliers where suppliername='" + text_suppliername.Text + "';";
                        gg.openconnection();
                        gg.command(query29);

                        bool correct = false;

                        while (gg.readdata().Read())
                        {
                            correct = true;
                        }
                        gg.closeconnection();
                        if (correct == true)
                        {
                            MessageBox.Show("This supplier name is existing in the system. try another name");
                        }
                        else {
                            double cb = 0;
                            string query30 = "insert into suppliers(supplierid,suppliername,supplieraddress,suppliertel,supplieremail,creditbalance)values('"+label_supplierid.Text+"','" + text_suppliername.Text + "', '" + text_supplieraddress.Text + "','" + text_suppliertel.Text + "',  '" + text_suppliereamail.Text + "','"+cb+"' ); ";

                            gg.openconnection();
                            gg.command(query30).ExecuteNonQuery();
                            gg.closeconnection();
                            Console.WriteLine("part 1");
                            string query32 = "update lastthings set supplierid='" + Int32.Parse(label_supplierid.Text).ToString() + "' where supplierid='" + pidpid + "';";
                           

                            gg.openconnection();
                            gg.command(query32).ExecuteNonQuery();
                            Console.WriteLine("part 2");
                            gg.closeconnection();

                            label_supplierid.Text = (Int32.Parse(label_supplierid.Text) + 1).ToString();

                            
                            supplierdatagrid();
                            text_suppliername.Focus();

                        }


                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void butto_supplieredit_Click(object sender, EventArgs e)
        {
            try
            {
                int rowselect = dataGridView1.SelectedRows.Count;

                if (rowselect > 1)
                {
                    MessageBox.Show("You Should select one row to edit");

                }
                else if(rowselect==0){
                    MessageBox.Show("There are no suplier details for edit");
                }
                else {
                    label_supplierid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    text_suppliername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    text_supplieraddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    text_suppliertel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    text_suppliereamail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    abc = "doit";

                    dataGridView1.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_supplierdelete_Click(object sender, EventArgs e)
        {

        }
        public void clearlabel() {
            text_supplieraddress.Text = "";
            text_suppliereamail.Text = "";
            text_suppliername.Text = "";
            text_suppliertel.Text = "";
        }

        private void text_suppliername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_supplieraddress.Focus();
            }
        }

        private void text_supplieraddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_suppliertel.Focus();
            }
        }

        private void text_suppliertel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_suppliereamail.Focus();
            }
        }

        private void text_suppliereamail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addshowbutton_Click(sender, e);

             
            }
        }
        yesnofrm hg;
        private void addshowbutton_Click(object sender, EventArgs e)
        {
            if (ob == null)
            {
                hg = new yesnofrm(5);
                hg.Owner = this;
                hg.FormClosed += new FormClosedEventHandler(hg_FormClosed);
                hg.warningtext = "Do You want to save supplier details?";
                hg.Show();
                this.Enabled = false;
            }
            else
                ob.Activate();

        }
        void hg_FormClosed(object sender, FormClosedEventArgs e)
        {
            ob = null;

        }

        private void label32_Click_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void UA_editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int selecrow = dataGridView2.SelectedRows.Count;

                if (selecrow > 1 || selecrow < 1)
                {
                    MessageBox.Show("You should select one row to edit");
                }
                else
                {

                    string uidz = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    dataGridView2.Enabled = false;

                    dbconnection db = new dbconnection();
                    string query31 = "select * from useraccounts where userid='" + uidz + "';";
                    db.openconnection();
                    db.command(query31);

                    int uaid = 0;
                    string  uaname = "";
                    string uatype = "";
                    string uafirstname = "";
                    string ualastname = "";
                    string uasurename = "";
                    string uanicnumber = "";
                    DateTime uadob = new DateTime();
                    string uamnumber = "";
                    string uaaddrenum = "";
                    string uaaddrstreet = "";
                    string uaaddretown = "";

                    while (db.readdata().Read()) {
                        uaid = db.readdata().GetInt32("userid");
                        uaname = db.readdata().GetString("usernames");
                        uatype = db.readdata().GetString("type");
                        uafirstname = db.readdata().GetString("firstname");
                        ualastname = db.readdata().GetString("lastname");
                        uasurename = db.readdata().GetString("surname");
                        uanicnumber = db.readdata().GetString("nationalid");
                        uadob = db.readdata().GetDateTime("dob");
                        uamnumber = db.readdata().GetString("mobile");
                        uaaddrenum = db.readdata().GetString("addressnum");
                        uaaddrstreet = db.readdata().GetString("addressstreet");
                        uaaddretown = db.readdata().GetString("addresstown");
                    }

                    UA_userid.Text = uaid.ToString();
                    UA_username.Text = uaname;
                    UA_type.Text = uatype;
                    UA_firstname.Text = uafirstname;
                    UA_lastname.Text = ualastname;
                    UA_surname.Text = uasurename;
                    UA_nic.Text = uanicnumber;
                    UA_date.Text = uadob.ToString("yyyy/MM/dd");
                    UA_mobnumber.Text = uamnumber;
                    UA_addressnum.Text = uaaddrenum;
                    UA_addressstreet.Text = uaaddrstreet;
                    UA_addresstown.Text = uaaddretown;

                    db.closeconnection();


                    UA_type.Focus();

                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        yesnofrm ee;
        private void UA_savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool botype = false;
                bool bofill = true;
              


                if (UA_type.Text=="MainAdmin" || UA_type.Text=="Admin" || UA_type.Text=="User" ) {
                    botype = true;
                }
                if (UA_firstname.Text=="" || UA_lastname.Text=="" || UA_surname.Text=="" || UA_nic.Text=="" || UA_date.Text=="" || UA_mobnumber.Text=="" || UA_addressnum.Text=="" || UA_addressstreet.Text=="" || UA_addresstown.Text=="") {
                    bofill = false;
                }
                
                
                if (botype == true && bofill == true )
                {
                    ee = new yesnofrm(6);
                    ee.Owner = this;
                    ee.FormClosed += new FormClosedEventHandler(ee_FormClosed);
                    ee.warningtext = "Are You Sure To Save ?";
                    ee.Show();
                    this.Enabled = false;
                }

                else {
                    MessageBox.Show("You cannot keep blank fields");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        void ee_FormClosed(object sender, FormClosedEventArgs e)
        {
            ee = null;

        }

        public void useraccountsave() {
            dbconnection ab = new dbconnection();
            try
            {
                string query32 = "update useraccounts set type='" + UA_type.Text + "',firstname='" + UA_firstname.Text + "',lastname='" + UA_lastname.Text + "',surname='" + UA_surname.Text + "',nationalid='" + UA_nic.Text + "',dob='" + UA_date.Text + "',mobile='" + UA_mobnumber.Text + "',addressnum='" + UA_addressnum.Text + "',addressstreet='" + UA_addressstreet.Text + "',addresstown='" + UA_addresstown.Text + "' where userid='" + UA_userid.Text + "';";

                ab.openconnection();
                ab.command(query32).ExecuteNonQuery();
                ab.closeconnection();

                dbconnection db = new dbconnection();

                string query30 = "select userid as 'User ID', firstname as 'First Name',lastname as 'Last Name',type as 'Type' from pharmacy.useraccounts;";
                db.openconnection();
                db.command(query30);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = db.command(query30);
                DataTable dbtab = new DataTable();
                sda.Fill(dbtab);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = dbtab;
                dataGridView2.DataSource = bsourse;
                sda.Update(dbtab);

                db.closeconnection();


                dataGridView2.BorderStyle = BorderStyle.None;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView2.BackgroundColor = Color.White;

                dataGridView2.EnableHeadersVisualStyles = false;
                dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView2.Enabled = true;

                MessageBox.Show("Saving succesfull!");


            }
            catch (Exception ex)
            {

         MessageBox.Show(ex.ToString());
            }
        }

        private void UA_newuserbutton_Click(object sender, EventArgs e)
        {
            newuserform sf = new newuserform();
            sf.Owner = this;
            sf.Show();
            this.Enabled = false;
        }

        private void UA_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                UA_firstname.Focus();
            }
        }

        private void UA_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_lastname.Focus();
            }
        }

        private void UA_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_surname.Focus();
            }
        }

        private void UA_surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_nic.Focus();
            }
        }

        private void UA_nic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_date.Focus();
            }
        }

        private void UA_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_mobnumber.Focus();
            }
        }

        private void UA_mobnumber_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                UA_addressnum.Focus();
            }
        }

        private void UA_addressnum_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                UA_addressstreet.Focus();
            }
        }

        private void UA_addressstreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_addresstown.Focus();
            }
        }

        private void UA_addresstown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UA_savebutton_Click(sender, e);
            }
        }

        public void cash_button_Click(object sender, EventArgs e)
        {
            cashier_window ab = new cashier_window(ffname,uid);
            ab.Owner = this;
            ab.Show();
            this.Enabled = false;

        }

        private void cashier_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lfname_Click(object sender, EventArgs e)
        {

        }

        private void watch1_Load(object sender, EventArgs e)
        {

        }

        private void sup_paymen_button_Click(object sender, EventArgs e)
        {
            supplier_payment_form ab = new supplier_payment_form(uid,ffname);
            ab.Owner = this;
            ab.Show();
            this.Enabled = false;

        }

        private void salary_payment_button_Click(object sender, EventArgs e)
        {
            salarypayment_window ab = new salarypayment_window(uid, ffname);
            ab.Owner = this;
            ab.Show();
            this.Enabled = false;
        }

        private void cashier_report_Click(object sender, EventArgs e)
        {

            cashier_report_window ab = new cashier_report_window();
            ab.Owner = this;
            ab.Show();
            this.Enabled = false;
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
           

            customer_window ab = new customer_window();
            ab.Owner = this;
            ab.Show();
            this.Enabled = false;
        }

        private void supplier_report_Click(object sender, EventArgs e)
        {

        }
    }
}
