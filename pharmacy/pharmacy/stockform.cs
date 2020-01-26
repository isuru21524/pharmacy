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
    public partial class stockform : Form
    {
        public stockform()
        {
            InitializeComponent();
           
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                main_window mw = (main_window)this.Owner;
                mw.Enabled = true;

                closebutton.Enabled = false;
                this.Close();
               
            }
            catch (Exception)
            {


                throw;
            }

        }

        private void maxbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void normalbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stockform_Load(object sender, EventArgs e)
        {
           dbconnection db = new dbconnection();

     

            String query8 = "select productid as 'Product_ID',productname as 'Product_Name',quantity as 'Quantity',buyprice as 'Buying_Price',sellprice as 'Selling_Price',suppliers as 'Supplier',type as 'Type' from pharmacy.stock;";
            db.openconnection();
            db.command(query8);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand= db.command(query8);
                DataTable dbtab = new DataTable();
                sda.Fill(dbtab);
                BindingSource bsourse = new BindingSource();

                bsourse.DataSource = dbtab;
                dataGridView1.DataSource = bsourse;
                sda.Update(dbtab);

                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


                



          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void stockform_Shown(object sender, EventArgs e)
        {
            text_stock_serchbox.Focus();
        }

        private void text_stock_serchbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string word = text_stock_serchbox.Text;
            
            
        }

        private void text_stock_serchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string keyword = text_stock_serchbox.Text;

                if (keyword != null)
                {
                    String query9 = "select productid as 'Product_ID',productname as 'Product_Name',quantity as 'Quantity',buyprice as 'Buying_Price',sellprice as 'Selling_Price',suppliers as 'Supplier',type as 'Type' from stock where productid  like '%" + keyword + "%' or productname like '%" + keyword + "%' or suppliers like '%"+keyword+"%';";

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
                else {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closebutton_Click(sender, e);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            main_window am = (main_window)this.Owner;

            this.WindowState = FormWindowState.Minimized;

            am.bunifuFlatButton2_Click(sender, e);
        }
    }
}
