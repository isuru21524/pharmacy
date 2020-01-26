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
    public partial class yesnofrm : Form
    {
       
    
       

        public yesnofrm()
        {
            InitializeComponent();
            cancelbutton.Hide();
           
        }
 //main frame close button
        int y = 0;
        public yesnofrm(int x)
        {
            InitializeComponent();
            y = x;
            cancelbutton.Hide();

            if (y == 4)
            {
                cancelbutton.Show();
            }
            else {
                cancelbutton.Hide();
            }

        }
// setting page
        int n = 0;
        string susername;
        string soldpas;
        string snewpas;
        string srenewpad;
        string olduname;
        int uid;

        public yesnofrm(int a,int z, string b, string c, string d, string e,string s)
        {
            InitializeComponent();
            cancelbutton.Hide();
            n = a;
            susername = b;
            soldpas = c;
            snewpas = d;
            srenewpad = e;
            uid = z;
            olduname = s;

           


        }






        private void yesnofrm_Load(object sender, EventArgs e)
        {
           
        }
 //yess butttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt
        public void yesbutton_Click(object sender, EventArgs e)
        {

            if (y == 1)
            {
                //main frame close
                try
                {
                    main_window frm = (main_window)this.Owner;


                    yesbutton.Enabled = false;
                    frm.Close();

                    this.Close();
                    login_window abc = new login_window();


                    abc.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }




            }

            else if (n == 2)
            {
                //setting page save
                try
                {
                    dbconnection xy = new dbconnection();

                    main_window arm = (main_window)this.Owner;

                    string query3 = "select * from useraccounts where usernames='" + susername + "';";
                    string query4 = "select * from useraccounts where password='" + soldpas + "' and userid='" + uid + "';";

                    //get old user namesis
                    xy.openconnection();
                    xy.command(query3);
                    bool olduseris = false;
                    while (xy.readdata().Read())
                    {
                        olduseris = true;
                    }
                    xy.closeconnection();


                    //get old password
                    xy.openconnection();
                    xy.command(query4);
                    bool oldpasis = false;
                    while (xy.readdata().Read())
                    {
                        oldpasis = true;
                    }
                    xy.closeconnection();



                    //use old user name......................................
                    if (susername == olduname)
                    {
                        if ((oldpasis == true) && (snewpas != soldpas) && (snewpas == srenewpad) && (snewpas != ""))
                        {
                            //write correct cod

                            string query5 = "update useraccounts set usernames='" + susername + "',password='" + snewpas + "' where userid='" + uid + "';";

                            xy.openconnection();
                            xy.command(query5).ExecuteNonQuery();
                            xy.closeconnection();

                            MessageBox.Show("The Changing setting is succesfull");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();


                        }
                        else if ((oldpasis == true) && (snewpas != soldpas) && (snewpas != srenewpad))
                        {
                            MessageBox.Show("The new passwords are not matching!!! Type them correctly");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();
                        }
                        else if ((oldpasis == true) && (soldpas != snewpas) && ((snewpas == "") || (srenewpad) == ""))
                        {
                            MessageBox.Show("You cannot keep Blank password fields");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();
                        }
                        else if (oldpasis == false)
                        {
                            MessageBox.Show("The old Password is wrong!!!");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Fill the Fields Correctly");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();
                        }
                    }

                    else if (susername != olduname)
                    {
                        if (olduseris == false)
                        {
                            if ((oldpasis == true) && (snewpas != soldpas) && (snewpas == srenewpad) && (snewpas != ""))
                            {
                                //write correct code
                                string query5 = "update useraccounts set usernames='" + susername + "',password='" + snewpas + "' where userid='" + uid + "';";

                                xy.openconnection();
                                xy.command(query5).ExecuteNonQuery();
                                xy.closeconnection();

                                MessageBox.Show("The Changing setting is succesfull");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();
                            }
                            else if ((oldpasis == true) && (snewpas == "") && (srenewpad == ""))
                            {
                                string query7 = "update useraccounts set usernames='" + susername + "' where userid='" + uid + "';";
                                xy.openconnection();
                                xy.command(query7).ExecuteNonQuery();
                                xy.closeconnection();

                                MessageBox.Show("UserName Changing is successfull");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();

                            }
                            else if ((oldpasis == true) && (snewpas != soldpas) && (snewpas != srenewpad))
                            {
                                MessageBox.Show("The new passwords are not matching!!! Type them correctly");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();
                            }
                            else if ((oldpasis == true) && (soldpas != snewpas) && ((snewpas == "") || (srenewpad) == ""))
                            {
                                MessageBox.Show("You cannot keep Blank password fields");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();
                            }
                            else if (oldpasis == false)
                            {
                                MessageBox.Show("The old Password is wrong!!!");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Fill the Fields Correctly");
                                arm.Enabled = true;
                                yesbutton.Enabled = false;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The UserName that  you enterd is available. Type another user name");
                            arm.Enabled = true;
                            yesbutton.Enabled = false;
                            this.Close();
                        }
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
            else if (y == 3)
            {
                try
                {
                    newitem_window ab = (newitem_window)this.Owner;
                    ab.Enabled = true;
                    ab.savedetails();
                    yesbutton.Enabled = false;
                    ab.cleardata();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            else if (y == 4)
            {
                try
                {
                    newitem_window frm = (newitem_window)this.Owner;
                    yesbutton.Enabled = false;
                    frm.savedetails();

                    frm.Enabled = true;
                    frm.closeform();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (y == 5)
            {
                try
                {
                    main_window ff = (main_window)this.Owner;
                    yesbutton.Enabled = false;
                    ff.bunifuThinButton23_Click(sender, e);
                    ff.Enabled = true;
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            else if (y == 6)
            {
                try
                {
                    main_window gg = (main_window)this.Owner;
                    yesbutton.Enabled = false;

                    gg.Enabled = true;
                    gg.useraccountsave();
                    this.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            }

            else if (y == 7)
            {
                newuserform gb = (newuserform)this.Owner;
                yesbutton.Enabled = false;

                gb.Enabled = true;
                gb.savedata();
                this.Close();

            }

            else if (y == 8)
            {
                supplier_payment_form gb = (supplier_payment_form)this.Owner;
                yesbutton.Enabled = false;

                gb.Enabled = true;
                gb.bunifuThinButton21_Click(sender, e);
                gb.combo_choose_supplier_SelectedIndexChanged(sender, e);
                this.Close();
            }

            else if (y == 9)
            {
                supplier_payment_form gb = (supplier_payment_form)this.Owner;
                yesbutton.Enabled = false;

                gb.Enabled = true;
                gb.recorrectionz();
                gb.combo_choose_supplier_SelectedIndexChanged(sender, e);
                this.Close();
            }

            else if (y == 10) {
                salarypayment_window gb = (salarypayment_window)this.Owner;
                yesbutton.Enabled = false;

                gb.Enabled = true;
                gb.recorrectz();
                gb.combo_add_name_SelectedIndexChanged(sender, e);
                this.Close();
            }



        }

//nobuttonnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
        public void nobutton_Click(object sender, EventArgs e)
        {


            try
            {
                if (y == 1)
                {

                    main_window frm = (main_window)this.Owner;
                    frm.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (n == 2)
                {
                    main_window arm = (main_window)this.Owner;
                    arm.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 3)
                {
                    newitem_window ab = (newitem_window)this.Owner;
                    ab.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 4)
                {
                    newitem_window ab = (newitem_window)this.Owner;
                    ab.Enabled = true;
                    ab.closeform();
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 5)
                {
                    main_window ff = (main_window)this.Owner;
                    ff.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 6)
                {
                    main_window gg = (main_window)this.Owner;
                    gg.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 7)
                {
                    newuserform gb = (newuserform)this.Owner;
                    gb.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }
                else if (y == 8)
                {
                    supplier_payment_form gb = (supplier_payment_form)this.Owner;
                    gb.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }

                else if (y == 9)
                {
                    supplier_payment_form gb = (supplier_payment_form)this.Owner;
                    gb.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }

                else if (y == 10) {
                    salarypayment_window gb = (salarypayment_window)this.Owner;
                    gb.Enabled = true;
                    nobutton.Enabled = false;
                    this.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        

        private void textyesnobox_Click(object sender, EventArgs e)
        {

        }
        public string warningtext {
            get {
                return textyesnobox.Text;
            }
            set {
                textyesnobox.Text = value;
            }
        }
       
        private void cancelbutton_Click(object sender, EventArgs e)
        {
           
        }
       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }
        /////////// cancel button///////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void yesbutton_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void yesnofrm_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
