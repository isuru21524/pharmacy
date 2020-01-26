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
    public partial class updateexitem_window : Form
    {
        public updateexitem_window()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            main_window mra = (main_window)this.Owner;
           
            mra.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closebutton_Click(sender, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateexitem_window_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_update_add_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void Fillcombo() {
            try
            {
                dbconnection ds = new dbconnection();

                string query9 = "select * from stock;";
                string query14 = "select * from suppliers;";
                ds.openconnection();
                ds.command(query9);

                while (ds.readdata().Read())
                {

                    string word = ds.readdata().GetString("productname");
                    combo_add_item.Items.Add(word);
                    combo_reduce_item.Items.Add(word);
                    combo_detail_item.Items.Add(word);
                }
                ds.closeconnection();

                ds.openconnection();
                ds.command(query14);

                while (ds.readdata().Read()) {
                    string keys = ds.readdata().GetString("suppliername");
                    combo_supplier.Items.Add(keys);

                }

                ds.closeconnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void combo_add_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecting = combo_add_item.Text;

            try
            {
                dbconnection dv = new dbconnection();
                string query10 = "select * from stock where productname='"+selecting+"';";
                dv.openconnection();
                dv.command(query10);

                int qty = 0;

                while (dv.readdata().Read())
                {
                    qty = dv.readdata().GetInt32("quantity");
                }

                
                add_availble.Text = qty.ToString();
                dv.closeconnection();

            
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void combo_reduce_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecting = combo_reduce_item.Text;

            try
            {
                dbconnection dv = new dbconnection();
                string query10 = "select * from stock where productname='" + selecting + "';";
                dv.openconnection();
                dv.command(query10);

                int qty = 0;

                while (dv.readdata().Read())
                {
                    qty = dv.readdata().GetInt32("quantity");
                }
               
             reduse_available.Text = qty.ToString();
                dv.closeconnection();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_add_item.Text == "" || text_qty_add.Text == "")
                {
                    MessageBox.Show("You Cannot Keep Blank Field");
                }
                else
                {
                    dbconnection cs = new dbconnection();

                    string product = combo_add_item.Text;
                    int newqty = Int32.Parse(text_qty_add.Text);
                    int existqty = 0;
                    string query12="select * from stock where productname='"+product+"';";

                    cs.openconnection();
                    cs.command(query12);

                    bool correct = false;

                    while (cs.readdata().Read()) {
                        existqty = cs.readdata().GetInt32("quantity");
                        correct = true;
                    }

                    cs.closeconnection();

                    if (correct == true) {
                        int qqty = existqty + newqty;




                        string query11 = "update stock set quantity='" + qqty + "' where productname='" + product + "';";
                        cs.openconnection();
                        cs.command(query11).ExecuteNonQuery();
                        cs.closeconnection();

                        add_availble.Text = qqty.ToString();
                        text_qty_add.Text = "";
                        combo_add_item.Focus();

                        string query63 = "select * from stock  where productname='" + product+ "';";                    cs.openconnection();
                        cs.command(query63);
                        double buyprice = 0;
                        string supname = "";
                        while (cs.readdata().Read()) {
                            buyprice = cs.readdata().GetDouble("buyprice");
                            supname = cs.readdata().GetString("suppliers");
                        }
                        cs.closeconnection();


                        double crebalance = 0;
                        cs.openconnection();
                        string query64 = "select * from suppliers where suppliername='" + supname + "';";
                        cs.command(query64);
                        while (cs.readdata().Read()) {
                            crebalance = cs.readdata().GetDouble("creditbalance");
                        }
                        cs.closeconnection();


                        double total = newqty * buyprice;
                        double newcrebalance = total + crebalance;
                        cs.openconnection();
                        string query65 = "update suppliers set creditbalance='" + newcrebalance + "' where suppliername='"+supname+"';";
                        cs.command(query65).ExecuteNonQuery();
                        cs.closeconnection();


                        


                        MessageBox.Show("Adding Item Is Successfull");
                    }
                    else
                    {
                        MessageBox.Show("This product is not exists in the stock");

                    }

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

               


            }

        private void add_availble_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_add_item_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void combo_add_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_qty_add.Focus();
            }
        }

        private void text_qty_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuThinButton21_Click(sender, e);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            try
            {
                if (combo_reduce_item.Text == "" || text_qty_reduse.Text=="" || reosonbox.Text=="")
                {
                    MessageBox.Show("You Cannot Keep Blank Field");
                    combo_reduce_item.Focus();
                }
                else
                {
                    dbconnection cs = new dbconnection();

                    string product = combo_reduce_item.Text;
                    int newqty = Int32.Parse(text_qty_reduse.Text);
                    int existqty = 0;
                    bool correct = false;

                    string query13 = "select * from stock where productname='" + product + "';";

                    cs.openconnection();
                    cs.command(query13);

                    while (cs.readdata().Read()) {
                        existqty = cs.readdata().GetInt32("quantity");
                        correct = true;
                    }


                    if (correct == true) {
                        if (newqty > existqty)
                        {
                            MessageBox.Show("There are not enough items to reduce");
                            text_qty_reduse.Focus();
                        }
                        else
                        {
                            int qqty = existqty - newqty;


                            string query11 = "update stock set quantity='" + qqty + "' where productname='" + product + "';";
                            cs.openconnection();
                            cs.command(query11).ExecuteNonQuery();
                            cs.closeconnection();

                            reduse_available.Text = qqty.ToString();
                            text_qty_reduse.Text = "";
                            reosonbox.Text = "";
                            combo_reduce_item.Focus();


                            string query63 = "select * from stock  where productname='" + product + "';"; cs.openconnection();
                            cs.command(query63);
                            double buyprice = 0;
                            string supname = "";
                            while (cs.readdata().Read())
                            {
                                buyprice = cs.readdata().GetDouble("buyprice");
                                supname = cs.readdata().GetString("suppliers");
                            }
                            cs.closeconnection();


                            double crebalance = 0;
                            cs.openconnection();
                            string query64 = "select * from suppliers where suppliername='" + supname + "';";
                            cs.command(query64);
                            while (cs.readdata().Read())
                            {
                                crebalance = cs.readdata().GetDouble("creditbalance");
                            }
                            cs.closeconnection();


                            double total = newqty * buyprice;
                            double newcrebalance = crebalance-total;
                            cs.openconnection();
                            string query65 = "update suppliers set creditbalance='" + newcrebalance + "' where suppliername='" + supname + "';";
                            cs.command(query65).ExecuteNonQuery();
                            cs.closeconnection();





                            MessageBox.Show("Redusing Item Is Successfull");

                        }
                    }
                    else
                    {
                        MessageBox.Show("This product is not exist in the stock");

                    }
                    

                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void combo_reduce_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_qty_reduse.Focus();
            }
        }

        private void text_qty_reduse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                reosonbox.Text = "";
                reosonbox.Focus();
            }
        }

        private void reosonbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                bunifuThinButton22_Click(sender, e);
            }
        }
 

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                string ppid = text_productid.Text;
                string newpname = text_pname.Text;
                double newbuyprice = double.Parse(text_buyprice.Text);
                double newsellprice = double.Parse(text_sellprice.Text);
                string newtype = combo_ptype.Text;
                string newsupplier = combo_supplier.Text;

                dbconnection gh = new dbconnection();
                gh.openconnection();
                string query17 = "select * from stock where productid='" + ppid + "';";
                string oldpname = "";
                gh.command(query17);

                while (gh.readdata().Read()) {
                    oldpname = gh.readdata().GetString("productname");
                }
                gh.closeconnection();

                bool bosupplier = false;


                if (combo_supplier.SelectedIndex > -1) {
                    bosupplier = true;
                }
                
               

                bool botype = false;

                if (combo_ptype.SelectedIndex>-1) {
                    botype = true;
                 
                }

                if (ppid == "")
                {
                    MessageBox.Show("You do not have selected a item");
                }
                else {

                    double x = Double.Parse(text_buyprice.Text);
                    double y = Double.Parse(text_sellprice.Text);
                    if (text_pname.Text == "" ||  x== 0 || y == 0 || combo_ptype.Text == "" || combo_supplier.Text == "")
                    {
                        MessageBox.Show("You can not keep blank fields");
                    }
                    else {
                        if ((botype == false || bosupplier == false) || (botype == false && bosupplier == false))
                        {
                            MessageBox.Show("The Supplier name or Type is not exist in the system");
                            

                        }
                        else
                        {

                            if (newpname == oldpname)
                            {
                               
                                string query18 = "update stock set productname='" + newpname + "',buyprice='" + newbuyprice + "',sellprice='" + newsellprice + "',type='" + newtype + "',suppliers='" + newsupplier + "' where productid='" + ppid + "';";

                                gh.openconnection();
                                gh.command(query18).ExecuteNonQuery();
                                gh.closeconnection();
                                combo_detail_item.Items.Clear();
                                combo_reduce_item.Items.Clear();
                                combo_add_item.Items.Clear();

                                Fillcombo();
                                MessageBox.Show("updating is sucessfull");
                            }
                            else
                            {
                                string query19 = "select * from stock where productname='" + newpname + "';";
                                gh.openconnection();
                                gh.command(query19);
                                bool correct = false;

                                while (gh.readdata().Read())
                                {
                                    correct = true;
                                }

                                if (correct == true)
                                {
                                    MessageBox.Show("the product name that you enterd is available in the system.try another product name");
                                }
                                else
                                {
                                    string query18 = "update stock set productname='" + newpname + "',buyprice='" + newbuyprice + "',sellprice='" + newsellprice + "',type='" + newtype + "',suppliers='" + newsupplier + "' where productid='" + ppid + "';";

                                    gh.openconnection();
                                    gh.command(query18).ExecuteNonQuery();
                                    gh.closeconnection();
                                    combo_detail_item.Items.Clear();
                                    combo_reduce_item.Items.Clear();
                                    combo_add_item.Items.Clear();

                                    Fillcombo();
                                    MessageBox.Show("updating is sucessfull");
                                }
                            }
                        }
                    }
                }


                
            }
            catch (Exception )
            {

                MessageBox.Show("You cannot keep blank fields");
            }

        }

        private void combo_detail_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string chooseitem = combo_detail_item.Text;
                string query15 = "select * from stock where productname='" + chooseitem + "';";
                dbconnection hh = new dbconnection();

                hh.openconnection();
                hh.command(query15);

                while (hh.readdata().Read())
                {
                    text_productid.Text = hh.readdata().GetInt32("productid").ToString();
                    text_pname.Text = hh.readdata().GetString("productname");
                    text_buyprice.Text = hh.readdata().GetDouble("buyprice").ToString();
                    text_sellprice.Text = hh.readdata().GetDouble("sellprice").ToString();
                    combo_ptype.Text = hh.readdata().GetString("type");
                    combo_supplier.Text = hh.readdata().GetString("suppliers");


                }
                hh.closeconnection();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void text_buyprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }

        private void text_sellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

        private void combo_detail_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_pname.Focus();
            }
        }

        private void text_pname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_buyprice.Focus();
            }
        }

        private void text_buyprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_sellprice.Focus();
            }
        }

        private void text_sellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_ptype.Focus();
            }
        }

        private void combo_ptype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_supplier.Focus();
            }
        }

        private void combo_supplier_KeyDown(object sender, KeyEventArgs e)
        {
           
                 if (e.KeyCode == Keys.Enter)
            {
                bunifuThinButton23_Click(sender, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            main_window am = (main_window)this.Owner;

            this.WindowState = FormWindowState.Minimized;

            am.bunifuFlatButton2_Click(sender, e);

        }
    }
    }


