namespace pharmacy
{
    partial class customer_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_window));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.text_uid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_date = new System.Windows.Forms.DateTimePicker();
            this.text_lastname = new System.Windows.Forms.TextBox();
            this.text_surname = new System.Windows.Forms.TextBox();
            this.text_nicnumber = new System.Windows.Forms.TextBox();
            this.text_addnum = new System.Windows.Forms.TextBox();
            this.text_addstreet = new System.Windows.Forms.TextBox();
            this.text_addtown = new System.Windows.Forms.TextBox();
            this.text_mnumber = new System.Windows.Forms.TextBox();
            this.text_firstname = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.closebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_clearall = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_createnew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.text_stock_serchbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_uid
            // 
            this.text_uid.Enabled = false;
            this.text_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_uid.Location = new System.Drawing.Point(215, 141);
            this.text_uid.Name = "text_uid";
            this.text_uid.Size = new System.Drawing.Size(136, 28);
            this.text_uid.TabIndex = 152;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 145;
            this.label11.Text = "Customer ID";
            // 
            // text_date
            // 
            this.text_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.text_date.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.text_date.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_date.CustomFormat = "yyyy-MM-dd";
            this.text_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.text_date.Location = new System.Drawing.Point(213, 356);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(152, 27);
            this.text_date.TabIndex = 144;
            this.text_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_date_KeyDown);
            // 
            // text_lastname
            // 
            this.text_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_lastname.Location = new System.Drawing.Point(213, 245);
            this.text_lastname.Name = "text_lastname";
            this.text_lastname.Size = new System.Drawing.Size(386, 28);
            this.text_lastname.TabIndex = 142;
            this.text_lastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_lastname_KeyDown);
            // 
            // text_surname
            // 
            this.text_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_surname.Location = new System.Drawing.Point(213, 302);
            this.text_surname.Name = "text_surname";
            this.text_surname.Size = new System.Drawing.Size(386, 28);
            this.text_surname.TabIndex = 141;
            this.text_surname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_surname_KeyDown);
            // 
            // text_nicnumber
            // 
            this.text_nicnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nicnumber.Location = new System.Drawing.Point(213, 409);
            this.text_nicnumber.Name = "text_nicnumber";
            this.text_nicnumber.Size = new System.Drawing.Size(386, 28);
            this.text_nicnumber.TabIndex = 140;
            this.text_nicnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_nicnumber_KeyDown);
            // 
            // text_addnum
            // 
            this.text_addnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_addnum.Location = new System.Drawing.Point(212, 539);
            this.text_addnum.Name = "text_addnum";
            this.text_addnum.Size = new System.Drawing.Size(386, 28);
            this.text_addnum.TabIndex = 139;
            this.text_addnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_addnum_KeyDown);
            // 
            // text_addstreet
            // 
            this.text_addstreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_addstreet.Location = new System.Drawing.Point(212, 573);
            this.text_addstreet.Name = "text_addstreet";
            this.text_addstreet.Size = new System.Drawing.Size(386, 28);
            this.text_addstreet.TabIndex = 138;
            this.text_addstreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_addstreet_KeyDown);
            // 
            // text_addtown
            // 
            this.text_addtown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_addtown.Location = new System.Drawing.Point(212, 607);
            this.text_addtown.Name = "text_addtown";
            this.text_addtown.Size = new System.Drawing.Size(386, 28);
            this.text_addtown.TabIndex = 137;
            this.text_addtown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_addtown_KeyDown);
            // 
            // text_mnumber
            // 
            this.text_mnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mnumber.Location = new System.Drawing.Point(212, 465);
            this.text_mnumber.Name = "text_mnumber";
            this.text_mnumber.Size = new System.Drawing.Size(386, 28);
            this.text_mnumber.TabIndex = 136;
            this.text_mnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_mnumber_KeyDown);
            // 
            // text_firstname
            // 
            this.text_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_firstname.Location = new System.Drawing.Point(213, 199);
            this.text_firstname.Name = "text_firstname";
            this.text_firstname.Size = new System.Drawing.Size(386, 28);
            this.text_firstname.TabIndex = 135;
            this.text_firstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_firstname_KeyDown);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 25);
            this.panel1.TabIndex = 121;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImage = global::pharmacy.Properties.Resources.minimise;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1462, 4);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(25, 18);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Customer";
            // 
            // closebutton
            // 
            this.closebutton.Activecolor = System.Drawing.Color.Transparent;
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.BackgroundImage = global::pharmacy.Properties.Resources.closebutton_white3;
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.BorderRadius = 0;
            this.closebutton.ButtonText = "";
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.DisabledColor = System.Drawing.Color.Gray;
            this.closebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.closebutton.Iconimage = null;
            this.closebutton.Iconimage_right = null;
            this.closebutton.Iconimage_right_Selected = null;
            this.closebutton.Iconimage_Selected = null;
            this.closebutton.IconMarginLeft = 0;
            this.closebutton.IconMarginRight = 0;
            this.closebutton.IconRightVisible = true;
            this.closebutton.IconRightZoom = 0D;
            this.closebutton.IconVisible = true;
            this.closebutton.IconZoom = 90D;
            this.closebutton.IsTab = false;
            this.closebutton.Location = new System.Drawing.Point(1512, 3);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closebutton.Name = "closebutton";
            this.closebutton.Normalcolor = System.Drawing.Color.Transparent;
            this.closebutton.OnHovercolor = System.Drawing.Color.Red;
            this.closebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.closebutton.selected = false;
            this.closebutton.Size = new System.Drawing.Size(24, 22);
            this.closebutton.TabIndex = 3;
            this.closebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closebutton.Textcolor = System.Drawing.Color.White;
            this.closebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(-1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 805);
            this.panel4.TabIndex = 123;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(1539, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 803);
            this.panel3.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1549, 45);
            this.panel2.TabIndex = 125;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.BackgroundImage = global::pharmacy.Properties.Resources.go_back_newzzzzz;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1250, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(279, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 805);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1549, 10);
            this.panel5.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "PERSONAL DETAILS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 134;
            this.label10.Text = "SurName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 133;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 132;
            this.label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 131;
            this.label7.Text = "NIC Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 130;
            this.label6.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 129;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 128;
            this.label3.Text = "First Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(15, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 31);
            this.panel6.TabIndex = 126;
            // 
            // button_clearall
            // 
            this.button_clearall.ActiveBorderThickness = 1;
            this.button_clearall.ActiveCornerRadius = 20;
            this.button_clearall.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_clearall.ActiveForecolor = System.Drawing.Color.White;
            this.button_clearall.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_clearall.BackColor = System.Drawing.SystemColors.Control;
            this.button_clearall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clearall.BackgroundImage")));
            this.button_clearall.ButtonText = "Clear All";
            this.button_clearall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clearall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearall.ForeColor = System.Drawing.Color.Navy;
            this.button_clearall.IdleBorderThickness = 1;
            this.button_clearall.IdleCornerRadius = 20;
            this.button_clearall.IdleFillColor = System.Drawing.Color.White;
            this.button_clearall.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_clearall.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_clearall.Location = new System.Drawing.Point(438, 677);
            this.button_clearall.Margin = new System.Windows.Forms.Padding(5);
            this.button_clearall.Name = "button_clearall";
            this.button_clearall.Size = new System.Drawing.Size(161, 51);
            this.button_clearall.TabIndex = 154;
            this.button_clearall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_clearall.Click += new System.EventHandler(this.button_clearall_Click);
            // 
            // button_createnew
            // 
            this.button_createnew.ActiveBorderThickness = 1;
            this.button_createnew.ActiveCornerRadius = 20;
            this.button_createnew.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_createnew.ActiveForecolor = System.Drawing.Color.White;
            this.button_createnew.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_createnew.BackColor = System.Drawing.SystemColors.Control;
            this.button_createnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_createnew.BackgroundImage")));
            this.button_createnew.ButtonText = "Create Account";
            this.button_createnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_createnew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createnew.ForeColor = System.Drawing.Color.Navy;
            this.button_createnew.IdleBorderThickness = 1;
            this.button_createnew.IdleCornerRadius = 20;
            this.button_createnew.IdleFillColor = System.Drawing.Color.White;
            this.button_createnew.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_createnew.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.button_createnew.Location = new System.Drawing.Point(213, 677);
            this.button_createnew.Margin = new System.Windows.Forms.Padding(5);
            this.button_createnew.Name = "button_createnew";
            this.button_createnew.Size = new System.Drawing.Size(215, 51);
            this.button_createnew.TabIndex = 153;
            this.button_createnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_createnew.Click += new System.EventHandler(this.button_createnew_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel11.Location = new System.Drawing.Point(644, 94);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(4, 665);
            this.panel11.TabIndex = 155;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(671, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(845, 588);
            this.dataGridView1.TabIndex = 156;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(671, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(413, 31);
            this.panel8.TabIndex = 167;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Russo One", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(32, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "CUSTOMERS";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BackgroundImage = global::pharmacy.Properties.Resources._32_322068_find_glass_magnifying_magnifying_glass_search_icon_search_icon_vector_png;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(1092, 87);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(44, 32);
            this.panel9.TabIndex = 169;
            // 
            // text_stock_serchbox
            // 
            this.text_stock_serchbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_stock_serchbox.Location = new System.Drawing.Point(1142, 88);
            this.text_stock_serchbox.Multiline = true;
            this.text_stock_serchbox.Name = "text_stock_serchbox";
            this.text_stock_serchbox.Size = new System.Drawing.Size(374, 32);
            this.text_stock_serchbox.TabIndex = 168;
            this.text_stock_serchbox.TextChanged += new System.EventHandler(this.text_stock_serchbox_TextChanged);
            // 
            // customer_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 815);
            this.ControlBox = false;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.text_stock_serchbox);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.button_clearall);
            this.Controls.Add(this.button_createnew);
            this.Controls.Add(this.text_uid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_date);
            this.Controls.Add(this.text_lastname);
            this.Controls.Add(this.text_surname);
            this.Controls.Add(this.text_nicnumber);
            this.Controls.Add(this.text_addnum);
            this.Controls.Add(this.text_addstreet);
            this.Controls.Add(this.text_addtown);
            this.Controls.Add(this.text_mnumber);
            this.Controls.Add(this.text_firstname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer_window";
            this.Load += new System.EventHandler(this.customer_window_Load);
            this.Shown += new System.EventHandler(this.customer_window_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 button_clearall;
        private Bunifu.Framework.UI.BunifuThinButton2 button_createnew;
        private System.Windows.Forms.TextBox text_uid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker text_date;
        private System.Windows.Forms.TextBox text_lastname;
        private System.Windows.Forms.TextBox text_surname;
        private System.Windows.Forms.TextBox text_nicnumber;
        private System.Windows.Forms.TextBox text_addnum;
        private System.Windows.Forms.TextBox text_addstreet;
        private System.Windows.Forms.TextBox text_addtown;
        private System.Windows.Forms.TextBox text_mnumber;
        private System.Windows.Forms.TextBox text_firstname;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton closebutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox text_stock_serchbox;
    }
}