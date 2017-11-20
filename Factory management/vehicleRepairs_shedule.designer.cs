namespace Factory_management
{
    partial class vehicleRepairs_shedule
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
            this.label33 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceCenter = new System.Windows.Forms.ComboBox();
            this.vehicleRepairGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save_repair_details = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRepairGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label33.Location = new System.Drawing.Point(111, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(157, 28);
            this.label33.TabIndex = 139;
            this.label33.Text = "Repair Details";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(202, 450);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(208, 29);
            this.date.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 142;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 149;
            this.label3.Text = "Service Center";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // serviceCenter
            // 
            this.serviceCenter.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCenter.FormattingEnabled = true;
            this.serviceCenter.Location = new System.Drawing.Point(202, 391);
            this.serviceCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceCenter.Name = "serviceCenter";
            this.serviceCenter.Size = new System.Drawing.Size(208, 30);
            this.serviceCenter.TabIndex = 150;
            // 
            // vehicleRepairGrid
            // 
            this.vehicleRepairGrid.AllowUserToAddRows = false;
            this.vehicleRepairGrid.AllowUserToDeleteRows = false;
            this.vehicleRepairGrid.BackgroundColor = System.Drawing.Color.White;
            this.vehicleRepairGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicleRepairGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vehicleRepairGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicleRepairGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vehicleRepairGrid.ColumnHeadersHeight = 40;
            this.vehicleRepairGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.vehicleRepairGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleRepairGrid.Location = new System.Drawing.Point(37, 151);
            this.vehicleRepairGrid.Name = "vehicleRepairGrid";
            this.vehicleRepairGrid.ReadOnly = true;
            this.vehicleRepairGrid.RowHeadersVisible = false;
            this.vehicleRepairGrid.RowHeadersWidth = 50;
            this.vehicleRepairGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.vehicleRepairGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleRepairGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.vehicleRepairGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.vehicleRepairGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.vehicleRepairGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleRepairGrid.Size = new System.Drawing.Size(939, 193);
            this.vehicleRepairGrid.TabIndex = 151;
            this.vehicleRepairGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vehicleRepairGrid_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Repair ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vehicle ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Repair Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cost";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Repair Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Service Center";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.machine__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // save_repair_details
            // 
            this.save_repair_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.save_repair_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_repair_details.FlatAppearance.BorderSize = 0;
            this.save_repair_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_repair_details.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_repair_details.ForeColor = System.Drawing.Color.White;
            this.save_repair_details.Location = new System.Drawing.Point(507, 507);
            this.save_repair_details.Name = "save_repair_details";
            this.save_repair_details.Size = new System.Drawing.Size(227, 38);
            this.save_repair_details.TabIndex = 165;
            this.save_repair_details.Text = "Save Repair Details";
            this.save_repair_details.UseVisualStyleBackColor = false;
            this.save_repair_details.Click += new System.EventHandler(this.save_repair_details_Click);
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(202, 512);
            this.cost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(208, 29);
            this.cost.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 515);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 166;
            this.label1.Text = "Cost";
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoice.FlatAppearance.BorderSize = 0;
            this.invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.ForeColor = System.Drawing.Color.White;
            this.invoice.Location = new System.Drawing.Point(749, 507);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(227, 38);
            this.invoice.TabIndex = 169;
            this.invoice.Text = "Invoice";
            this.invoice.UseVisualStyleBackColor = false;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // vehicleRepairs_shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 605);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_repair_details);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vehicleRepairGrid);
            this.Controls.Add(this.serviceCenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label33);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehicleRepairs_shedule";
            this.Text = "vehicleRepairs_shedule";
            this.Load += new System.EventHandler(this.vehicleRepairs_shedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRepairGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serviceCenter;
        private System.Windows.Forms.DataGridView vehicleRepairGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save_repair_details;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}