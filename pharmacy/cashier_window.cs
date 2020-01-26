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
    public partial class cashier_window : Form
    {
        string ctext="0.00";
        string uname = "";
        int uid = 0;

        public cashier_window()
        {
            InitializeComponent();
        }
        public cashier_window(string x,int y)
        {
            InitializeComponent();
            uname = x;
            uid = y;

            uidlabal.Text = uid.ToString();

            unamezzz.Text = uname;
            
           

        }

        private void cashier_window_Load(object sender, EventArgs e)
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

            
            dbconnection ac = new dbconnection();

            try
            {
                string query40 = "select * from stock;";

                ac.openconnection();
                ac.command(query40);

                string word = "";

                while (ac.readdata().Read())
                {
                    word = ac.readdata().GetString("productname");
                    combo_choose_item.Items.Add(word);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            main_window cc = (main_window)this.Owner;
            cc.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            main_window cc = (main_window)this.Owner;
            cc.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            main_window cc = (main_window)this.Owner;
            cc.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            main_window am = (main_window)this.Owner;

            this.WindowState = FormWindowState.Minimized;

            am.bunifuFlatButton2_Click(sender, e);
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void text_qty_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (text_qty_add.Text == "0")
            {
                text_qty_add.Text = "";
            }
            else {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (discount_text.Text == "0") {
                discount_text.Text = "";
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }

        private void combo_choose_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconnection gh = new dbconnection();

            string selecting = combo_choose_item.Text;
            try
            {
                string query41 = "select * from stock where productname='" + selecting + "';";
                gh.openconnection();
                gh.command(query41);

                while (gh.readdata().Read())
                {
                    availble_qty.Text = gh.readdata().GetInt32("quantity").ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_qty_add_Enter(object sender, EventArgs e)
        {

        }

        private void text_qty_add_Leave(object sender, EventArgs e)
        {
            if (text_qty_add.Text == "" || text_qty_add.Text == "0") 
            {
                text_qty_add.Text = "0";
            }
            else {
               
                int y = Int32.Parse(availble_qty.Text);
                int x = Int32.Parse(text_qty_add.Text);

                if (y < x) {
                    MessageBox.Show("Invalied number of quantity");
                    
                }
            }
        }

        private void discount_text_Leave(object sender, EventArgs e)
        {
            if (discount_text.Text == "" || discount_text.Text=="0")
            {
                discount_text.Text = "0";
            }
            else {
                int dis = Int32.Parse(discount_text.Text);

                if(dis>100){
                    MessageBox.Show("invalied discount");
                  
                }
            }
        }

        private void total_Amount_label_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            combo_choose_item.Text = "";
            availble_qty.Text = "0";
            text_qty_add.Text = "0";
            discount_text.Text = "0";

            dataGridView1.Rows.Clear();

            total_Amount_label.Text = "0.00";
            return_amount.Text = "0.00";
            text_cash.Text = "0.00";
            balance_text.Text = "0.00";
            Total_item_text.Text = "0";

        }

        private void button_add_item_Click(object sender, EventArgs e)
        {
            try
            {
                bool correctpname = false;
                bool correctqty = false;
                bool correctdis = false;

                string pname = combo_choose_item.Text;
                dbconnection gg = new dbconnection();

                string query42 = "select * from stock where productname='" + pname + "';";
                gg.openconnection();
                gg.command(query42);

                while (gg.readdata().Read()) {
                    correctpname = true;
                }

                gg.closeconnection();

                /////////////////////////////////////

                int avqty = Int32.Parse(availble_qty.Text);
                int newqty = Int32.Parse(text_qty_add.Text);

                if (newqty <= avqty && newqty>0) {
                    correctqty = true;
                }

                /////////////////////////////////

                double dis = double.Parse(discount_text.Text);

                if (dis <= 100) {
                    correctdis = true;
                }

                if (correctpname == true && correctdis == true && correctqty == true)
                {
                    string query43 = "select * from stock where productname='" + pname + "';";
                    gg.openconnection();
                    gg.command(query43);

                    int pid = 0;
                    double sellprice = 0;

                    while (gg.readdata().Read())
                    {
                        pid = gg.readdata().GetInt32("productid");
                        sellprice = gg.readdata().GetDouble("sellprice");
                    }

                    int rownum = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rownum].Cells[0].Value = pid.ToString();
                    dataGridView1.Rows[rownum].Cells[1].Value = pname;
                    dataGridView1.Rows[rownum].Cells[2].Value = newqty.ToString();
                    dataGridView1.Rows[rownum].Cells[3].Value = sellprice.ToString();
                    dataGridView1.Rows[rownum].Cells[4].Value = dis.ToString();

                    double subtotal = (newqty * sellprice) - (newqty * sellprice * dis) / 100;

                    double newsub = Math.Round(subtotal, 2);

                    dataGridView1.Rows[rownum].Cells[5].Value =  newsub.ToString();

                    if (text_cash.Text == "")
                    {
                        double totalvalue = double.Parse(total_Amount_label.Text);

                        double newtotal = totalvalue + newsub;

                        total_Amount_label.Text = Math.Round(newtotal, 2).ToString();
                    }
                    else {
                        double totalvalue = double.Parse(total_Amount_label.Text);

                        double newtotal = totalvalue + newsub;

                        total_Amount_label.Text = Math.Round(newtotal, 2).ToString();

                        double newcash = double.Parse(text_cash.Text);
                        double returnvalue = double.Parse(return_amount.Text);
                        double balance = newcash - newtotal - returnvalue;

                        balance_text.Text = Math.Round(balance, 2).ToString();
                    }

                    int told = Int32.Parse(Total_item_text.Text);

                    Total_item_text.Text = (told + 1).ToString();

                    combo_choose_item.Text = "";
                    availble_qty.Text = "0";
                    text_qty_add.Text = "0";
                    discount_text.Text = "0";

                }

                else {
                    MessageBox.Show("invalied details");
                }




            }
            catch (Exception)
            {
                MessageBox.Show("check fields");               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selecitem = dataGridView1.SelectedRows.Count;

           
        }

        private void plusqty_Click(object sender, EventArgs e)
        {
            try
            {
                int selecitem = dataGridView1.SelectedRows.Count;

                if (selecitem == 1)
                {

                    string pnamez = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string query43 = "select * from stock where productname='" + pnamez + "';";

                    dbconnection ac = new dbconnection();
                    ac.openconnection();
                    ac.command(query43);
                    int sysqty = 0;

                    while (ac.readdata().Read())
                    {
                        sysqty = ac.readdata().GetInt32("quantity");
                    }

                    int oldqty = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    if (oldqty >= sysqty)
                    {
                        MessageBox.Show("You can not increas quantity");
                    }
                    else
                    {
                        int newold = oldqty + 1;

                        dataGridView1.CurrentRow.Cells[2].Value = newold.ToString();

                   /////////////////////////////////////////////////////////////////////

                        double oldsubtotal = double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        
                        double discount = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        double sellprice = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                        double newsubtotal = (sellprice * newold) - (sellprice * newold * discount)/100;

                        dataGridView1.CurrentRow.Cells[5].Value = newsubtotal.ToString();

                        total_Amount_label.Text = (double.Parse(total_Amount_label.Text) - oldsubtotal + newsubtotal).ToString();

                        if (text_cash.Text == "") {
                            balance_text.Text = "0.00";
                        }
                        else {
                            double total = double.Parse(total_Amount_label.Text);
                            double cash = double.Parse(text_cash.Text);
                            double returntotal = double.Parse(return_amount.Text);

                            balance_text.Text = (cash - total - returntotal).ToString();
                        }




                    }

                }
                else
                {
                    MessageBox.Show("One row should be selected to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void minusqty_Click(object sender, EventArgs e)
        {
            try
            {
                int selecitem = dataGridView1.SelectedRows.Count;
                if (selecitem == 1)
                {

                    string pnamez = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string query43 = "select * from stock where productname='" + pnamez + "';";

                    dbconnection ac = new dbconnection();
                    ac.openconnection();
                    ac.command(query43);
                    int sysqty = 0;

                    while (ac.readdata().Read())
                    {
                        sysqty = ac.readdata().GetInt32("quantity");
                    }

                    int oldqty = Int32.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    if (oldqty == 1)
                    {
                        MessageBox.Show("You can not increas quantity");
                    }
                    else
                    {
                        int newold = oldqty - 1;

                        dataGridView1.CurrentRow.Cells[2].Value = newold.ToString();

                        double oldsubtotal = double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());

                        double discount = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        double sellprice = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                        double newsubtotal = (sellprice * newold) - (sellprice * newold * discount) / 100;

                        dataGridView1.CurrentRow.Cells[5].Value = newsubtotal.ToString();

                        total_Amount_label.Text = (double.Parse(total_Amount_label.Text) - oldsubtotal + newsubtotal).ToString();

                        if (text_cash.Text == "")
                        {
                            balance_text.Text = "0.00";
                        }
                        else
                        {
                            double total = double.Parse(total_Amount_label.Text);
                            double cash = double.Parse(text_cash.Text);
                            double returntotal = double.Parse(return_amount.Text);

                            balance_text.Text = (cash - total - returntotal).ToString();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("One row should be selected to change quantity");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
           
            try
            {
                int selecrow = dataGridView1.SelectedRows.Count;

                if (dataGridView1.Rows.Count == 0)
                {

                    MessageBox.Show("There are no added item to delete");
                }

               else if (selecrow == 1)
                {
                    
                       

                    int numitem = Int32.Parse(Total_item_text.Text);

                    Total_item_text.Text = (numitem - 1).ToString();
               ////////////////////////////////////////////////////////////
                    double tamount = double.Parse(total_Amount_label.Text);
                    double subz = double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());

                    if (text_cash.Text == "" ) 
                    {
                        
                      total_Amount_label.Text = (tamount - subz).ToString();
                    }
                    else {
                        double cash = double.Parse(text_cash.Text);
                        double returnamount = double.Parse(return_amount.Text);

                        double balance = cash - returnamount - tamount+subz;
                        balance_text.Text = balance.ToString();

                        total_Amount_label.Text = (tamount - subz).ToString();




                    }

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }

                    if (dataGridView1.Rows.Count == 0) {
                        total_Amount_label.Text = "0.00";
                    }


                }
                else {
                    MessageBox.Show("One row should be selected to delete");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void text_cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text_cash.Text == "0.00" || text_cash.Text=="0" || text_cash.Text==".") {
                text_cash.Text = "";
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void text_cash_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (text_cash.Text == "")
                {
                    balance_text.Text = "0.00";
                    text_cash.Text = "0.00";
                }
                else
                {
                    double tamount = double.Parse(total_Amount_label.Text);
                    double cash = double.Parse(text_cash.Text);
                    double returnamount = double.Parse(return_amount.Text);

                    double balance = cash - returnamount - tamount;
                    balance_text.Text = balance.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cashier_window_Shown(object sender, EventArgs e)
        {
            combo_choose_item.Focus();
        }

        private void combo_choose_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_qty_add.Focus();
            }
        }

        private void text_qty_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                discount_text.Focus();
                
            }
        }

        private void discount_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                button_add_item_Click(sender, e);
                textBox1.Focus();
            }
        }

        private void hide_button_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.ToString() == "Enter") {
                combo_choose_item.Focus();
            }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                hide_button.Focus();
            }
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void hide_button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                combo_choose_item.Focus();
            }
        }

        private void button_add_item_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                combo_choose_item.Focus();
                discount_text.Text = "0";
            }
            if (e.KeyCode == Keys.Down) {
                text_cash.Focus();
                discount_text.Text = "0";
            }
        }

        private void combo_choose_item_Enter(object sender, EventArgs e)
        {
            discount_text.Text = "0";
        }

        private void button_cash_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Invoice is empty");
                text_cash.Text = ctext;
            }
          

            else if (text_cash.Text == "" || double.Parse(balance_text.Text) <= 0)
            {
              
                MessageBox.Show("Not enough money to pay the bill");
                text_cash.Text = ctext;
            }
            else {
                try
                {
                    dbconnection aa = new dbconnection();

                    aa.openconnection();
                    string query44 = "select * from lastthings;";
                    aa.command(query44);
                    int lastbillnumber = 0;

                    while (aa.readdata().Read()) {
                        lastbillnumber = aa.readdata().GetInt32("billnumber");
                    }
                    aa.closeconnection();
                    int newbillnumber = lastbillnumber + 1;
                    

                    DateTime dt = DateTime.Now;
                    string datenow=dt.ToString("yyyy-MM-dd");
                    string timenow = dt.ToString("hh:mm:ss");
                    string uid = uidlabal.Text;
                    string uname = unamezzz.Text;
                    double totalamount = double.Parse(total_Amount_label.Text);
                    double returnamount = double.Parse(return_amount.Text);
                    double cashamount = double.Parse(text_cash.Text);
                    double balance = double.Parse(balance_text.Text);
                    string selltype = "Cash";
                    

           



                    aa.openconnection();
                    for (int i = 0; i < dataGridView1.Rows.Count ; i++) {
                        string query45 = "insert into cashier(billnumber,itemname,quantity,sellprice,discount,subtotal,total,balance,cash,returnamount,date,time,userid,username,selltype) values('" + newbillnumber + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','"+Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) +"','"+double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) +"','"+ double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + "','"+ double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) + "','"+totalamount+"','"+balance+"','"+cashamount+"','"+returnamount+"','"+datenow+"','"+timenow+"','"+uid+"','"+uname+"','"+selltype+"');";

                        aa.command(query45).ExecuteNonQuery();

                    }
                    aa.closeconnection();

                    aa.openconnection();
                    string query46 = "update lastthings set billnumber='" + newbillnumber + "' where billnumber='"+lastbillnumber+"';";
                    aa.command(query46).ExecuteNonQuery();
                    aa.closeconnection();

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        aa.openconnection();
                        string query47 = "select * from stock where productname='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "';";
                        aa.command(query47);

                        int oldquantity = 0;
                        while (aa.readdata().Read())
                        {
                            oldquantity = aa.readdata().GetInt32("quantity");
                        }

                        int cashquantity = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                        int newquantity = oldquantity - cashquantity;

                        aa.closeconnection();

                        aa.openconnection();
                        string query48 = "update stock set quantity='" + newquantity + "' where productname='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "';";
                        aa.command(query48).ExecuteNonQuery();
                        aa.closeconnection();



                    }
                    

                    MessageBox.Show("Sold");
                    cashier_window_Load(sender, e);
                    button4_Click(sender, e);
                    combo_choose_item.Focus();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void text_cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctext = text_cash.Text;
                button_cash_Click(sender, e);
            }
        }

        private void text_cash_Leave(object sender, EventArgs e)
        {
            try
            {
                if (text_cash.Text == "")
                {
                    balance_text.Text = "0.00";
                }
                else
                {
                    double tamount = double.Parse(total_Amount_label.Text);
                    double cash = double.Parse(text_cash.Text);
                    double returnamount = double.Parse(return_amount.Text);

                    double balance = cash - returnamount - tamount;
                    balance_text.Text = balance.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_cash_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
