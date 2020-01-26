namespace pharmacy
{
    partial class cashier_report_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier_report_window));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_stock_serchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_add_name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UA_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button_recorrect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.text_cash_balance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_visa_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.text_total_balance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1549, 55);
            this.panel2.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.BackgroundImage = global::pharmacy.Properties.Resources.back_button;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1246, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(294, 52);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::pharmacy.Properties.Resources._32_322068_find_glass_magnifying_magnifying_glass_search_icon_search_icon_vector_png;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(1037, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 32);
            this.panel3.TabIndex = 1;
            // 
            // text_stock_serchbox
            // 
            this.text_stock_serchbox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_stock_serchbox.Location = new System.Drawing.Point(1089, 105);
            this.text_stock_serchbox.Multiline = true;
            this.text_stock_serchbox.Name = "text_stock_serchbox";
            this.text_stock_serchbox.Size = new System.Drawing.Size(430, 32);
            this.text_stock_serchbox.TabIndex = 0;
            this.text_stock_serchbox.TextChanged += new System.EventHandler(this.text_stock_serchbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 29);
            this.panel1.TabIndex = 2;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1463, 2);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(25, 23);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.closebutton.Location = new System.Drawing.Point(1516, 5);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closebutton.Name = "closebutton";
            this.closebutton.Normalcolor = System.Drawing.Color.Transparent;
            this.closebutton.OnHovercolor = System.Drawing.Color.Red;
            this.closebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.closebutton.selected = false;
            this.closebutton.Size = new System.Drawing.Size(24, 22);
            this.closebutton.TabIndex = 10;
            this.closebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closebutton.Textcolor = System.Drawing.Color.White;
            this.closebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Report";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1539, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 783);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(0, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 789);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 805);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1549, 10);
            this.panel6.TabIndex = 16;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(533, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(986, 464);
            this.dataGridView1.TabIndex = 71;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel11.Location = new System.Drawing.Point(487, 103);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(4, 665);
            this.panel11.TabIndex = 86;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(533, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(413, 31);
            this.panel7.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Transactions";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(40, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(413, 31);
            this.panel8.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Date And User";
            // 
            // combo_add_name
            // 
            this.combo_add_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_add_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.combo_add_name.FormattingEnabled = true;
            this.combo_add_name.Location = new System.Drawing.Point(46, 240);
            this.combo_add_name.Name = "combo_add_name";
            this.combo_add_name.Size = new System.Drawing.Size(413, 30);
            this.combo_add_name.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 90;
            this.label7.Text = "User";
            // 
            // UA_date
            // 
            this.UA_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UA_date.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.UA_date.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UA_date.CustomFormat = "yyyy-MM-dd";
            this.UA_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UA_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UA_date.Location = new System.Drawing.Point(46, 351);
            this.UA_date.Name = "UA_date";
            this.UA_date.Size = new System.Drawing.Size(152, 27);
            this.UA_date.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 108;
            this.label4.Text = "Date";
            // 
            // button_recorrect
            // 
            this.button_recorrect.ActiveBorderThickness = 1;
            this.button_recorrect.ActiveCornerRadius = 20;
            this.button_recorrect.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.button_recorrect.ActiveForecolor = System.Drawing.Color.White;
            this.button_recorrect.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.button_recorrect.BackColor = System.Drawing.Color.White;
            this.button_recorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_recorrect.BackgroundImage")));
            this.button_recorrect.ButtonText = "Go to Report";
            this.button_recorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_recorrect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recorrect.ForeColor = System.Drawing.Color.Navy;
            this.button_recorrect.IdleBorderThickness = 1;
            this.button_recorrect.IdleCornerRadius = 20;
            this.button_recorrect.IdleFillColor = System.Drawing.Color.White;
            this.button_recorrect.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.button_recorrect.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.button_recorrect.Location = new System.Drawing.Point(119, 426);
            this.button_recorrect.Margin = new System.Windows.Forms.Padding(5);
            this.button_recorrect.Name = "button_recorrect";
            this.button_recorrect.Size = new System.Drawing.Size(217, 51);
            this.button_recorrect.TabIndex = 109;
            this.button_recorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_recorrect.Click += new System.EventHandler(this.button_recorrect_Click);
            // 
            // text_cash_balance
            // 
            this.text_cash_balance.Enabled = false;
            this.text_cash_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cash_balance.Location = new System.Drawing.Point(686, 671);
            this.text_cash_balance.Name = "text_cash_balance";
            this.text_cash_balance.Size = new System.Drawing.Size(260, 28);
            this.text_cash_balance.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(530, 673);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 23);
            this.label12.TabIndex = 110;
            this.label12.Text = "Cash Balance";
            // 
            // text_visa_balance
            // 
            this.text_visa_balance.Enabled = false;
            this.text_visa_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_visa_balance.Location = new System.Drawing.Point(1149, 672);
            this.text_visa_balance.Name = "text_visa_balance";
            this.text_visa_balance.Size = new System.Drawing.Size(260, 28);
            this.text_visa_balance.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(993, 674);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "Visa Balance";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(534, 626);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(413, 31);
            this.panel9.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Russo One", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Balance";
            // 
            // text_total_balance
            // 
            this.text_total_balance.Enabled = false;
            this.text_total_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_total_balance.Location = new System.Drawing.Point(1149, 733);
            this.text_total_balance.Name = "text_total_balance";
            this.text_total_balance.Size = new System.Drawing.Size(260, 28);
            this.text_total_balance.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(993, 735);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 23);
            this.label8.TabIndex = 115;
            this.label8.Text = "Total Balance";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cashier_report_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1549, 815);
            this.ControlBox = false;
            this.Controls.Add(this.text_total_balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.text_visa_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_cash_balance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_recorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UA_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_add_name);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.text_stock_serchbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cashier_report_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashier_report_window";
            this.Load += new System.EventHandler(this.cashier_report_window_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_stock_serchbox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_add_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker UA_date;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 button_recorrect;
        private System.Windows.Forms.TextBox text_cash_balance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_visa_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_total_balance;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}