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
    public partial class newitem_window : Form
    {
        static int curntrowindex = 0;
        string abc = "";
        public newitem_window()
        {
            InitializeComponent();
            Fillcombo();
        }

        public void closebutton_Click(object sender, EventArgs e)
        {
            yesnofrm de;

            if (dataGridView1.Rows.Count == 0)
            {
                main_window mra = (main_window)this.Owner;

                mra.Enabled = true;
                closebutton.Enabled = false;
                this.Close();
            }
            else {
                de = new yesnofrm(4);
                de.Owner = this;
               
                de.warningtext = "Do you want to save list before leaving?";
                de.Show();
                this.Enabled = false;
            }
            
          
        }

        public void closeform() {
            main_window mra = (main_window)this.Owner;

             mra.Enabled = true;
            closebutton.Enabled = false;
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closebutton_Click(sender, e);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void newitem_window_Load(object sender, EventArgs e)
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

            dbconnection gh = new dbconnection();

            gh.openconnection();
            string query20 = "select * from lastthings;";
            gh.command(query20);
            int lastpid = 0;

            while (gh.readdata().Read()) {
                lastpid = gh.readdata().GetInt32("productid");
            }
            int sum = lastpid + 1;
            productid_label.Text = sum.ToString();
                

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool botype = false;
            bool bosupply = false;

            if (combo_supplier.SelectedIndex > -1) {
                bosupply = true;

            }
            if (combo_newtype.SelectedIndex > -1) {
                botype = true;
            }

            if (text_newproductname.Text == "" || text_newquantity.Text == "" || text_newbuyprice.Text == "" || text_newsellprice.Text == "" || combo_newtype.Text == "" || combo_supplier.Text == "")
            {
                MessageBox.Show("You can not keep blank fields");
            }
            else {
                if (botype == false || bosupply == false) {
                    MessageBox.Show("The Supplier name or Type is not exist in the system");
                }
                else {
                    if (abc== "doit")
                    {
                        dataGridView1.Rows[curntrowindex].Cells[0].Value = productid_label.Text;
                        dataGridView1.Rows[curntrowindex].Cells[1].Value = text_newproductname.Text;
                        dataGridView1.Rows[curntrowindex].Cells[2].Value = text_newquantity.Text;
                        dataGridView1.Rows[curntrowindex].Cells[3].Value = text_newbuyprice.Text;
                        dataGridView1.Rows[curntrowindex].Cells[4].Value = text_newsellprice.Text;
                        dataGridView1.Rows[curntrowindex].Cells[5].Value = combo_newtype.Text;
                        dataGridView1.Rows[curntrowindex].Cells[6].Value = combo_supplier.Text;

                        
                        text_newproductname.Text = "";
                        text_newquantity.Text = "";
                        text_newbuyprice.Text = "";
                        text_newsellprice.Text = "";
                        combo_newtype.Text = "";
                        combo_supplier.Text = "";

                        int rownum = dataGridView1.Rows.Count - 1;
                        string pids = dataGridView1.Rows[rownum].Cells[0].Value.ToString();
                        int pid = Int32.Parse(pids);
                        productid_label.Text = (pid + 1).ToString();

                        dataGridView1.Enabled = true;

                        text_newproductname.Focus();



                    }
                    else {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = productid_label.Text;
                        dataGridView1.Rows[n].Cells[1].Value = text_newproductname.Text;
                        dataGridView1.Rows[n].Cells[2].Value = text_newquantity.Text;
                        dataGridView1.Rows[n].Cells[3].Value = text_newbuyprice.Text;
                        dataGridView1.Rows[n].Cells[4].Value = text_newsellprice.Text;
                        dataGridView1.Rows[n].Cells[5].Value = combo_newtype.Text;
                        dataGridView1.Rows[n].Cells[6].Value = combo_supplier.Text;

                        text_newproductname.Text = "";
                        text_newquantity.Text = "";
                        text_newbuyprice.Text = "";
                        text_newsellprice.Text = "";
                        combo_newtype.Text = "";
                        combo_supplier.Text = "";




                        int rownum = dataGridView1.Rows.Count - 1;
                        string pids = dataGridView1.Rows[rownum].Cells[0].Value.ToString();
                        int pid = Int32.Parse(pids);
                        productid_label.Text = (pid + 1).ToString();

                        text_newproductname.Focus();

                    }


                }
               
            }
            abc = "";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            text_newproductname.Text = "";
            text_newquantity.Text = "";
            text_newbuyprice.Text = "";
            text_newsellprice.Text = "";
            combo_newtype.Text = "";
            combo_supplier.Text = "";

            text_newproductname.Focus();
        }
        void Fillcombo() {
            string query19 = "select * from suppliers;";

            dbconnection ab = new dbconnection();
            ab.openconnection();
            ab.command(query19);

            while (ab.readdata().Read()) {
                string word = ab.readdata().GetString("suppliername");
                combo_supplier.Items.Add(word);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            main_window am = (main_window)this.Owner;
           
            this.WindowState = FormWindowState.Minimized;
           
            am.bunifuFlatButton2_Click(sender, e);
           

            
        }

        private void text_newproductname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_newquantity.Focus();
            }
        }

        private void text_newquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_newbuyprice.Focus();
            }
        }

        private void text_newbuyprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_newsellprice.Focus();
            }
        }

        private void text_newsellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_newtype.Focus();
            }
        }

        private void combo_newtype_KeyDown(object sender, KeyEventArgs e)
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
                bunifuThinButton21_Click(sender,e);
            }
        }

        private void text_newbuyprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void text_newsellprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_newsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
        }

        private void text_newquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    newitem_window_Load(sender, e);
                }
                else 
                {

                    dbconnection ac = new dbconnection();

                    ac.openconnection();
                    string query21 = "select * from lastthings;";
                    ac.command(query21);
                    int pid = 0;

                    while (ac.readdata().Read())
                    {
                        pid = ac.readdata().GetInt32("productid");
                    }

                    int rownum = dataGridView1.Rows.Count - 1;

                    for (int i = 0; i < rownum+1; i++) {
                        pid = pid + 1;
                        string pids = pid.ToString();
                        dataGridView1.Rows[i].Cells[0].Value=pids;
                    }

                    int rowc = dataGridView1.Rows.Count-1;
                    string xyz = dataGridView1.Rows[rowc].Cells[0].Value.ToString();
                    int newpid = Int32.Parse(xyz) + 1;
                    productid_label.Text = newpid.ToString();

                    text_newproductname.Focus();



                    


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

            try
            {
                int selectrow = dataGridView1.SelectedRows.Count;

                if (selectrow > 1 && selectrow < 1)
                {
                    MessageBox.Show("You should select one row to  Edit");
                }
                else
                {
                    productid_label.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    text_newproductname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    text_newquantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    text_newbuyprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    text_newsellprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    combo_newtype.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    combo_supplier.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    abc = "doit";

                    dataGridView1.Enabled = false;
                    curntrowindex = dataGridView1.CurrentRow.Index;

                }
            } 
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        yesnofrm cc;
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            cc = new yesnofrm(3);
            cc.Owner = this;
            cc.FormClosed += new FormClosedEventHandler(cc_FormClosed);
            cc.warningtext = "Are You Sure To Save ?";
            cc.Show();
            this.Enabled = false;

        }
        void cc_FormClosed(object sender, FormClosedEventArgs e)
        {
            cc = null;

        }
        public void savedetails() {
            int allrow = dataGridView1.Rows.Count;

            dbconnection ac = new dbconnection();
            ac.openconnection();
            string query25 = "select * from lastthings;";
            ac.command(query25);
            int oldpid = 0;

            while (ac.readdata().Read()) {
                oldpid = ac.readdata().GetInt32("productid");
            }
            ac.closeconnection();

            for (int i = 0; i < allrow; i++) {

                int pid = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value
                    .ToString());
                string pname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                int pquantity = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                double pbprice = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                double psprice = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                string ptype = dataGridView1.Rows[i].Cells[5].Value.ToString();
                string psupplier = dataGridView1.Rows[i].Cells[6].Value.ToString();

                

                ac.openconnection();
                string query22 = "insert into stock values('" + pid + "','" + pname + "','"+pquantity+"','"+pbprice+"','"+psprice+"','"+ptype+"','"+psupplier+"');";
                ac.command(query22).ExecuteNonQuery();
                ac.closeconnection();

                double oldcrebalance = 0;
                ac.openconnection();
                string query66 = "select * from suppliers where suppliername='" + psupplier + "';";
                ac.command(query66);
                while (ac.readdata().Read()) {
                    oldcrebalance = ac.readdata().GetDouble("creditbalance");
                }
                ac.closeconnection();

                double total = pquantity * pbprice;
                double newcrebalance = total + oldcrebalance;
                ac.openconnection();
                string query67 = "update suppliers set creditbalance='"+newcrebalance+"' where suppliername='"+psupplier+"';";
                ac.command(query67).ExecuteNonQuery();
                ac.closeconnection();

                
            }
            MessageBox.Show("Saving successfull");

            int lastpid = Int32.Parse(dataGridView1.Rows[allrow - 1].Cells[0].Value.ToString());
            string query24 = "update lastthings set productid='" + lastpid + "' where productid='" + oldpid + "';";

            ac.openconnection();
            ac.command(query24).ExecuteNonQuery();
            ac.closeconnection();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dbconnection aa = new dbconnection();
            string query23 = "select * from lastthings;";
            aa.openconnection();
            aa.command(query23);

            int pid = 0;

            while (aa.readdata().Read()) {
                pid = aa.readdata().GetInt32("productid");
            }

            productid_label.Text = (pid + 1).ToString();
            text_newproductname.Focus();


        }
        public void cleardata() {
            dataGridView1.Rows.Clear();
        }
    }
}
