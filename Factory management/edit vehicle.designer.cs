namespace Factory_management
{
    partial class edit_vehicle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.vid = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.engno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.purprice = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.insno = new System.Windows.Forms.TextBox();
            this.inscompany = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.regnoSearch = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.delete_vehicle = new System.Windows.Forms.Button();
            this.attach_book = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.view_all = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.regno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(740, 422);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(216, 29);
            this.amount.TabIndex = 172;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 171;
            this.label11.Text = "Vehicle Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label14.Location = new System.Drawing.Point(35, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 22);
            this.label14.TabIndex = 166;
            this.label14.Text = "Vehicle Details";
            // 
            // pdate
            // 
            this.pdate.CustomFormat = "yyyy-MM-dd";
            this.pdate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pdate.Location = new System.Drawing.Point(236, 543);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(215, 29);
            this.pdate.TabIndex = 156;
            this.pdate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // vid
            // 
            this.vid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vid.Location = new System.Drawing.Point(236, 340);
            this.vid.Name = "vid";
            this.vid.Size = new System.Drawing.Size(215, 29);
            this.vid.TabIndex = 154;
            this.vid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(236, 422);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(215, 29);
            this.type.TabIndex = 153;
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(236, 463);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(215, 29);
            this.model.TabIndex = 152;
            // 
            // engno
            // 
            this.engno.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engno.Location = new System.Drawing.Point(236, 504);
            this.engno.Name = "engno";
            this.engno.Size = new System.Drawing.Size(215, 29);
            this.engno.TabIndex = 151;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 507);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 22);
            this.label16.TabIndex = 148;
            this.label16.Text = "Engine Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(35, 548);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 22);
            this.label17.TabIndex = 147;
            this.label17.Text = "Purchase Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(35, 589);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 22);
            this.label18.TabIndex = 146;
            this.label18.Text = "Price (LKR)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(35, 425);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 22);
            this.label19.TabIndex = 145;
            this.label19.Text = "Vehicle Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(35, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 22);
            this.label20.TabIndex = 144;
            this.label20.Text = "Vehicle Reg.Number";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(35, 466);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 22);
            this.label21.TabIndex = 143;
            this.label21.Text = "Model";
            // 
            // enddate
            // 
            this.enddate.CustomFormat = "yyyy-MM-dd";
            this.enddate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate.Location = new System.Drawing.Point(740, 463);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(216, 29);
            this.enddate.TabIndex = 164;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(525, 466);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 22);
            this.label27.TabIndex = 163;
            this.label27.Text = "Ending Date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(525, 343);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(152, 22);
            this.label28.TabIndex = 162;
            this.label28.Text = "Insurance Number";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(525, 425);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 22);
            this.label29.TabIndex = 161;
            this.label29.Text = "Amount";
            // 
            // purprice
            // 
            this.purprice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purprice.Location = new System.Drawing.Point(236, 586);
            this.purprice.Name = "purprice";
            this.purprice.Size = new System.Drawing.Size(215, 29);
            this.purprice.TabIndex = 160;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(525, 384);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(161, 22);
            this.label32.TabIndex = 159;
            this.label32.Text = "Insurance Company";
            // 
            // insno
            // 
            this.insno.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insno.Location = new System.Drawing.Point(740, 340);
            this.insno.Name = "insno";
            this.insno.Size = new System.Drawing.Size(216, 29);
            this.insno.TabIndex = 157;
            // 
            // inscompany
            // 
            this.inscompany.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscompany.Location = new System.Drawing.Point(740, 381);
            this.inscompany.Name = "inscompany";
            this.inscompany.Size = new System.Drawing.Size(216, 29);
            this.inscompany.TabIndex = 155;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label33.Location = new System.Drawing.Point(525, 305);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(150, 22);
            this.label33.TabIndex = 150;
            this.label33.Text = "Insurance Details";
            // 
            // regnoSearch
            // 
            this.regnoSearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regnoSearch.Location = new System.Drawing.Point(543, 69);
            this.regnoSearch.Name = "regnoSearch";
            this.regnoSearch.Size = new System.Drawing.Size(168, 29);
            this.regnoSearch.TabIndex = 138;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(962, 573);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(239, 38);
            this.Clear.TabIndex = 174;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // delete_vehicle
            // 
            this.delete_vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.delete_vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_vehicle.FlatAppearance.BorderSize = 0;
            this.delete_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_vehicle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_vehicle.ForeColor = System.Drawing.Color.White;
            this.delete_vehicle.Location = new System.Drawing.Point(729, 573);
            this.delete_vehicle.Name = "delete_vehicle";
            this.delete_vehicle.Size = new System.Drawing.Size(227, 38);
            this.delete_vehicle.TabIndex = 175;
            this.delete_vehicle.Text = "Delete Vehicles";
            this.delete_vehicle.UseVisualStyleBackColor = false;
            this.delete_vehicle.Click += new System.EventHandler(this.button1_Click);
            // 
            // attach_book
            // 
            this.attach_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.attach_book.FlatAppearance.BorderSize = 0;
            this.attach_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attach_book.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_book.ForeColor = System.Drawing.Color.White;
            this.attach_book.Location = new System.Drawing.Point(729, 519);
            this.attach_book.Name = "attach_book";
            this.attach_book.Size = new System.Drawing.Size(227, 38);
            this.attach_book.TabIndex = 176;
            this.attach_book.Text = "Attach Book";
            this.attach_book.UseVisualStyleBackColor = false;
            this.attach_book.Click += new System.EventHandler(this.attach_book_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(741, 61);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(227, 38);
            this.search.TabIndex = 177;
            this.search.Text = "Search Vehicle";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_all
            // 
            this.view_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_all.FlatAppearance.BorderSize = 0;
            this.view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_all.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.White;
            this.view_all.Location = new System.Drawing.Point(974, 61);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(227, 38);
            this.view_all.TabIndex = 178;
            this.view_all.Text = "View All";
            this.view_all.UseVisualStyleBackColor = false;
            this.view_all.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.price,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.Location = new System.Drawing.Point(39, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 173);
            this.dataGridView1.TabIndex = 179;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Vehicle Id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vehicle Reg.Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vehicle Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Model";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Engine Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Purchase Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Price (LKR)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Insurance Number";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Insurance Company";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ending Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "book";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.auto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(136, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 28);
            this.label10.TabIndex = 181;
            this.label10.Text = "Edit Vehicle Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(962, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 38);
            this.button1.TabIndex = 182;
            this.button1.Text = "View Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(987, 323);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(190, 175);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 183;
            this.pic.TabStop = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(529, 573);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(194, 38);
            this.update.TabIndex = 184;
            this.update.Text = "Update Vehicles";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // regno
            // 
            this.regno.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regno.Location = new System.Drawing.Point(236, 384);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(215, 29);
            this.regno.TabIndex = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 186;
            this.label1.Text = "Vehicle Reg.Number";
            // 
            // edit_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.search);
            this.Controls.Add(this.attach_book);
            this.Controls.Add(this.delete_vehicle);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pdate);
            this.Controls.Add(this.vid);
            this.Controls.Add(this.type);
            this.Controls.Add(this.model);
            this.Controls.Add(this.engno);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.purprice);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.insno);
            this.Controls.Add(this.inscompany);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.regnoSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_vehicle";
            this.Text = "edit_vehicle";
            this.Load += new System.EventHandler(this.edit_vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.TextBox vid;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox engno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox purprice;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox insno;
        private System.Windows.Forms.TextBox inscompany;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox regnoSearch;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button delete_vehicle;
        private System.Windows.Forms.Button attach_book;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button view_all;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}