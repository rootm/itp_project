namespace Factory_management
{
    partial class edit_scheduled_product_orders_delivery
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
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.vehicleGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverGrid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheduleGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverid = new System.Windows.Forms.TextBox();
            this.vehicleid = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deliverydate = new System.Windows.Forms.DateTimePicker();
            this.deliverytime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deliveryId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(119, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(409, 28);
            this.label21.TabIndex = 192;
            this.label21.Text = "Edit Sheduled Product Orders Delivery";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Factory_management.Properties.Resources.trolley;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 200;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label17.Location = new System.Drawing.Point(661, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 22);
            this.label17.TabIndex = 207;
            this.label17.Text = "Select Driver";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(935, 549);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(227, 38);
            this.update.TabIndex = 222;
            this.update.Text = "Update Schedule";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(702, 549);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(227, 38);
            this.delete.TabIndex = 223;
            this.delete.Text = "Delete Schedule";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // vehicleGrid
            // 
            this.vehicleGrid.AllowUserToAddRows = false;
            this.vehicleGrid.AllowUserToDeleteRows = false;
            this.vehicleGrid.BackgroundColor = System.Drawing.Color.White;
            this.vehicleGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vehicleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vehicleGrid.ColumnHeadersHeight = 32;
            this.vehicleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column13});
            this.vehicleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleGrid.Location = new System.Drawing.Point(42, 405);
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
            this.vehicleGrid.Size = new System.Drawing.Size(585, 182);
            this.vehicleGrid.TabIndex = 237;
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
            this.driverGrid.Location = new System.Drawing.Point(653, 161);
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
            this.driverGrid.Size = new System.Drawing.Size(518, 180);
            this.driverGrid.TabIndex = 236;
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
            // sheduleGrid
            // 
            this.sheduleGrid.AllowUserToAddRows = false;
            this.sheduleGrid.AllowUserToDeleteRows = false;
            this.sheduleGrid.BackgroundColor = System.Drawing.Color.White;
            this.sheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sheduleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sheduleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sheduleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sheduleGrid.ColumnHeadersHeight = 32;
            this.sheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.date,
            this.Column3,
            this.Column10,
            this.Column11,
            this.Column12});
            this.sheduleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.sheduleGrid.Location = new System.Drawing.Point(42, 161);
            this.sheduleGrid.Name = "sheduleGrid";
            this.sheduleGrid.ReadOnly = true;
            this.sheduleGrid.RowHeadersVisible = false;
            this.sheduleGrid.RowHeadersWidth = 50;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheduleGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.sheduleGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.sheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sheduleGrid.Size = new System.Drawing.Size(585, 180);
            this.sheduleGrid.TabIndex = 235;
            this.sheduleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellContentClick);
            this.sheduleGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderGrid_CellMouseClick);
            this.sheduleGrid.SelectionChanged += new System.EventHandler(this.sheduleGrid_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delivery Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Order Id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Vehicle Id";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Driver Id";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // driverid
            // 
            this.driverid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverid.Location = new System.Drawing.Point(768, 496);
            this.driverid.Name = "driverid";
            this.driverid.ReadOnly = true;
            this.driverid.Size = new System.Drawing.Size(170, 29);
            this.driverid.TabIndex = 234;
            // 
            // vehicleid
            // 
            this.vehicleid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleid.Location = new System.Drawing.Point(768, 452);
            this.vehicleid.Name = "vehicleid";
            this.vehicleid.ReadOnly = true;
            this.vehicleid.Size = new System.Drawing.Size(170, 29);
            this.vehicleid.TabIndex = 233;
            // 
            // orderid
            // 
            this.orderid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderid.Location = new System.Drawing.Point(768, 405);
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Size = new System.Drawing.Size(170, 29);
            this.orderid.TabIndex = 232;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(666, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 231;
            this.label11.Text = "Vehicle Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(666, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 230;
            this.label9.Text = "Driver Id";
            // 
            // deliverydate
            // 
            this.deliverydate.CustomFormat = "yyyy-MM-dd";
            this.deliverydate.Enabled = false;
            this.deliverydate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliverydate.Location = new System.Drawing.Point(155, 358);
            this.deliverydate.Name = "deliverydate";
            this.deliverydate.Size = new System.Drawing.Size(160, 29);
            this.deliverydate.TabIndex = 228;
            this.deliverydate.ValueChanged += new System.EventHandler(this.deliverydate_ValueChanged);
            // 
            // deliverytime
            // 
            this.deliverytime.CustomFormat = "HH:MM";
            this.deliverytime.Enabled = false;
            this.deliverytime.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverytime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliverytime.Location = new System.Drawing.Point(416, 358);
            this.deliverytime.Name = "deliverytime";
            this.deliverytime.ShowUpDown = true;
            this.deliverytime.Size = new System.Drawing.Size(160, 29);
            this.deliverytime.TabIndex = 227;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 226;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 225;
            this.label5.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 229;
            this.label8.Text = "Order Id";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(1584, 591);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(227, 38);
            this.Clear.TabIndex = 243;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(478, 97);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(152, 38);
            this.view.TabIndex = 242;
            this.view.Text = "View All";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(319, 97);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 38);
            this.search.TabIndex = 241;
            this.search.Text = "Search ";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 240;
            this.label7.Text = "Delivery Id";
            // 
            // deliveryId
            // 
            this.deliveryId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryId.Location = new System.Drawing.Point(133, 103);
            this.deliveryId.Name = "deliveryId";
            this.deliveryId.Size = new System.Drawing.Size(170, 29);
            this.deliveryId.TabIndex = 244;
            // 
            // edit_scheduled_product_orders_delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 601);
            this.Controls.Add(this.deliveryId);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.view);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vehicleGrid);
            this.Controls.Add(this.driverGrid);
            this.Controls.Add(this.sheduleGrid);
            this.Controls.Add(this.driverid);
            this.Controls.Add(this.vehicleid);
            this.Controls.Add(this.orderid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deliverydate);
            this.Controls.Add(this.deliverytime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_scheduled_product_orders_delivery";
            this.Text = "edit_scheduled_product_orders_delivery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView vehicleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView driverGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView sheduleGrid;
        private System.Windows.Forms.TextBox driverid;
        private System.Windows.Forms.TextBox vehicleid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker deliverydate;
        private System.Windows.Forms.DateTimePicker deliverytime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deliveryId;
    }
}