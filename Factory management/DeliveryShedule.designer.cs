namespace Factory_management
{
    partial class DeliveryShedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deliverytime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.deliverydate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.driverid = new System.Windows.Forms.TextBox();
            this.vehicleid = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.schedule_delivery = new System.Windows.Forms.Button();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverGrid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.driverName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderdate
            // 
            this.orderdate.CustomFormat = "yyyy-MM-dd";
            this.orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderdate.Location = new System.Drawing.Point(127, 103);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(160, 26);
            this.orderdate.TabIndex = 28;
            this.orderdate.Value = new System.DateTime(2017, 11, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(112, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Shedule Product Orders Delivery";
            // 
            // deliverytime
            // 
            this.deliverytime.CustomFormat = "HH:MM";
            this.deliverytime.Enabled = false;
            this.deliverytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverytime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliverytime.Location = new System.Drawing.Point(146, 371);
            this.deliverytime.Name = "deliverytime";
            this.deliverytime.ShowUpDown = true;
            this.deliverytime.Size = new System.Drawing.Size(160, 26);
            this.deliverytime.TabIndex = 30;
            this.deliverytime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Order Date";
            // 
            // deliverydate
            // 
            this.deliverydate.CustomFormat = "yyyy-MM-dd";
            this.deliverydate.Enabled = false;
            this.deliverydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliverydate.Location = new System.Drawing.Point(146, 337);
            this.deliverydate.Name = "deliverydate";
            this.deliverydate.Size = new System.Drawing.Size(160, 26);
            this.deliverydate.TabIndex = 35;
            this.deliverydate.ValueChanged += new System.EventHandler(this.deliverydate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(626, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select Driver";
            // 
            // driverid
            // 
            this.driverid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverid.Location = new System.Drawing.Point(1019, 405);
            this.driverid.Name = "driverid";
            this.driverid.ReadOnly = true;
            this.driverid.Size = new System.Drawing.Size(170, 29);
            this.driverid.TabIndex = 83;
            this.driverid.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // vehicleid
            // 
            this.vehicleid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleid.Location = new System.Drawing.Point(741, 452);
            this.vehicleid.Name = "vehicleid";
            this.vehicleid.ReadOnly = true;
            this.vehicleid.Size = new System.Drawing.Size(170, 29);
            this.vehicleid.TabIndex = 82;
            // 
            // orderid
            // 
            this.orderid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderid.Location = new System.Drawing.Point(741, 405);
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Size = new System.Drawing.Size(170, 29);
            this.orderid.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(626, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 79;
            this.label11.Text = "Vehicle Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Order Id";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(293, 99);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 38);
            this.search.TabIndex = 178;
            this.search.Text = "Search ";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(452, 99);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(152, 38);
            this.view.TabIndex = 179;
            this.view.Text = "View All";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // schedule_delivery
            // 
            this.schedule_delivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.schedule_delivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schedule_delivery.Enabled = false;
            this.schedule_delivery.FlatAppearance.BorderSize = 0;
            this.schedule_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedule_delivery.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_delivery.ForeColor = System.Drawing.Color.White;
            this.schedule_delivery.Location = new System.Drawing.Point(729, 562);
            this.schedule_delivery.Name = "schedule_delivery";
            this.schedule_delivery.Size = new System.Drawing.Size(227, 38);
            this.schedule_delivery.TabIndex = 180;
            this.schedule_delivery.Text = "Schedule Delivery";
            this.schedule_delivery.UseVisualStyleBackColor = false;
            this.schedule_delivery.Click += new System.EventHandler(this.schedule_delivery_Click);
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.ColumnHeadersHeight = 32;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column11,
            this.Column12});
            this.orderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.orderGrid.Location = new System.Drawing.Point(19, 143);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowHeadersVisible = false;
            this.orderGrid.RowHeadersWidth = 50;
            this.orderGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.orderGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.orderGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.orderGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(585, 180);
            this.orderGrid.TabIndex = 181;
            this.orderGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderGrid_CellMouseClick);
            this.orderGrid.SelectionChanged += new System.EventHandler(this.orderGrid_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Order ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Agent ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Agent Name";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Order Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // driverGrid
            // 
            this.driverGrid.AllowUserToAddRows = false;
            this.driverGrid.AllowUserToDeleteRows = false;
            this.driverGrid.BackgroundColor = System.Drawing.Color.White;
            this.driverGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.driverGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.driverGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driverGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.driverGrid.ColumnHeadersHeight = 32;
            this.driverGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.driverGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.driverGrid.Location = new System.Drawing.Point(630, 143);
            this.driverGrid.Name = "driverGrid";
            this.driverGrid.ReadOnly = true;
            this.driverGrid.RowHeadersVisible = false;
            this.driverGrid.RowHeadersWidth = 50;
            this.driverGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.driverGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.driverGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.driverGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.driverGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverGrid.Size = new System.Drawing.Size(559, 180);
            this.driverGrid.TabIndex = 182;
            this.driverGrid.SelectionChanged += new System.EventHandler(this.driverGrid_SelectionChanged);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Driver ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Driver\'s Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Telephone Number";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // vehicleGrid
            // 
            this.vehicleGrid.AllowUserToAddRows = false;
            this.vehicleGrid.AllowUserToDeleteRows = false;
            this.vehicleGrid.BackgroundColor = System.Drawing.Color.White;
            this.vehicleGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vehicleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vehicleGrid.ColumnHeadersHeight = 32;
            this.vehicleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column13});
            this.vehicleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleGrid.Location = new System.Drawing.Point(12, 408);
            this.vehicleGrid.Name = "vehicleGrid";
            this.vehicleGrid.ReadOnly = true;
            this.vehicleGrid.RowHeadersVisible = false;
            this.vehicleGrid.RowHeadersWidth = 50;
            this.vehicleGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.vehicleGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.vehicleGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.vehicleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleGrid.Size = new System.Drawing.Size(585, 192);
            this.vehicleGrid.TabIndex = 183;
            this.vehicleGrid.SelectionChanged += new System.EventHandler(this.vehicleGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "vehicle Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vehicle Reg. Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Model";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vehicle Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Available";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.trolley;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(962, 562);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(227, 38);
            this.Clear.TabIndex = 184;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(938, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 77;
            this.label9.Text = "Driver Id";
            // 
            // driverName
            // 
            this.driverName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverName.Location = new System.Drawing.Point(741, 502);
            this.driverName.Name = "driverName";
            this.driverName.ReadOnly = true;
            this.driverName.Size = new System.Drawing.Size(170, 29);
            this.driverName.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 185;
            this.label3.Text = "Driver Name";
            // 
            // DeliveryShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 617);
            this.Controls.Add(this.driverName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.vehicleGrid);
            this.Controls.Add(this.driverGrid);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.schedule_delivery);
            this.Controls.Add(this.view);
            this.Controls.Add(this.search);
            this.Controls.Add(this.driverid);
            this.Controls.Add(this.vehicleid);
            this.Controls.Add(this.orderid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliverydate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deliverytime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryShedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.DeliveryShedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker deliverytime;
       
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker deliverydate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox driverid;
        private System.Windows.Forms.TextBox vehicleid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button schedule_delivery;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.DataGridView driverGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView vehicleGrid;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox driverName;
        private System.Windows.Forms.Label label3;
    }
}