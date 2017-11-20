namespace Factory_management
{
    partial class Transport_schedule
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
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.TextBox();
            this.purpose = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.vehicleId = new System.Windows.Forms.Label();
            this.driverId = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverGrid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shedule_transport = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(603, 403);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 22);
            this.label19.TabIndex = 136;
            this.label19.Text = "Transportation Purpose";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label24.Location = new System.Drawing.Point(23, 367);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 22);
            this.label24.TabIndex = 135;
            this.label24.Text = "Select Driver";
            // 
            // destination
            // 
            this.destination.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(838, 471);
            this.destination.Multiline = true;
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(247, 48);
            this.destination.TabIndex = 133;
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose.Location = new System.Drawing.Point(838, 400);
            this.purpose.Multiline = true;
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(247, 51);
            this.purpose.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(603, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 22);
            this.label12.TabIndex = 131;
            this.label12.Text = "Destination Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(603, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 22);
            this.label13.TabIndex = 129;
            this.label13.Text = "Drive ID       :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(603, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 22);
            this.label16.TabIndex = 126;
            this.label16.Text = "Vehicle ID   :";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(139, 109);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(160, 29);
            this.date.TabIndex = 124;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(329, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 22);
            this.label17.TabIndex = 123;
            this.label17.Text = "Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 22);
            this.label18.TabIndex = 122;
            this.label18.Text = "Travel Date";
            // 
            // time
            // 
            this.time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.CustomFormat = "HH:MM";
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(392, 109);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(160, 29);
            this.time.TabIndex = 125;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(255, 328);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 20);
            this.label20.TabIndex = 115;
            // 
            // vehicleId
            // 
            this.vehicleId.AutoSize = true;
            this.vehicleId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleId.Location = new System.Drawing.Point(717, 171);
            this.vehicleId.Name = "vehicleId";
            this.vehicleId.Size = new System.Drawing.Size(0, 22);
            this.vehicleId.TabIndex = 185;
            // 
            // driverId
            // 
            this.driverId.AutoSize = true;
            this.driverId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverId.Location = new System.Drawing.Point(717, 206);
            this.driverId.Name = "driverId";
            this.driverId.Size = new System.Drawing.Size(0, 22);
            this.driverId.TabIndex = 186;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Factory_management.Properties.Resources.auto;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(121, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 191;
            this.label1.Text = "Schedule General Transportation";
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
            this.Column6,
            this.Column5,
            this.Column13});
            this.vehicleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleGrid.Location = new System.Drawing.Point(27, 151);
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
            this.vehicleGrid.Size = new System.Drawing.Size(555, 192);
            this.vehicleGrid.TabIndex = 193;
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
            // Column6
            // 
            this.Column6.HeaderText = "Vehicle Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Model";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.driverGrid.Location = new System.Drawing.Point(27, 403);
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
            this.driverGrid.Size = new System.Drawing.Size(555, 180);
            this.driverGrid.TabIndex = 192;
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
            // shedule_transport
            // 
            this.shedule_transport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.shedule_transport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shedule_transport.FlatAppearance.BorderSize = 0;
            this.shedule_transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shedule_transport.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shedule_transport.ForeColor = System.Drawing.Color.White;
            this.shedule_transport.Location = new System.Drawing.Point(607, 545);
            this.shedule_transport.Name = "shedule_transport";
            this.shedule_transport.Size = new System.Drawing.Size(237, 38);
            this.shedule_transport.TabIndex = 194;
            this.shedule_transport.Text = "Shedule Transport";
            this.shedule_transport.UseVisualStyleBackColor = false;
            this.shedule_transport.Click += new System.EventHandler(this.shedule_transport_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(852, 545);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(237, 38);
            this.clear.TabIndex = 195;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Transport_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 585);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.shedule_transport);
            this.Controls.Add(this.vehicleGrid);
            this.Controls.Add(this.driverGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverId);
            this.Controls.Add(this.vehicleId);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transport_schedule";
            this.Text = "edit_transport_schedule";
            this.Load += new System.EventHandler(this.edit_transport_schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox purpose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label vehicleId;
        private System.Windows.Forms.Label driverId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vehicleGrid;
        private System.Windows.Forms.DataGridView driverGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button shedule_transport;
        private System.Windows.Forms.Button clear;
    }
}