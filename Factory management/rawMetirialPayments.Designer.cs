namespace Factory_management
{
    partial class rawMetirialPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label19 = new System.Windows.Forms.Label();
            this.materialType = new System.Windows.Forms.ComboBox();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.meterialOrder_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_lable = new System.Windows.Forms.Label();
            this.unitPrice_label = new System.Windows.Forms.Label();
            this.supplierName_label = new System.Windows.Forms.Label();
            this.supplierAccount_label = new System.Windows.Forms.Label();
            this.supplierID_label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.viewAll = new System.Windows.Forms.Button();
            this.decline = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.meterialOrder_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label19.Location = new System.Drawing.Point(94, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(320, 28);
            this.label19.TabIndex = 32;
            this.label19.Text = "Approve Raw Material Orders";
            // 
            // materialType
            // 
            this.materialType.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialType.FormattingEnabled = true;
            this.materialType.Items.AddRange(new object[] {
            "Any"});
            this.materialType.Location = new System.Drawing.Point(548, 93);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(184, 28);
            this.materialType.TabIndex = 29;
            // 
            // orderDate
            // 
            this.orderDate.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate.Location = new System.Drawing.Point(174, 91);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(209, 28);
            this.orderDate.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(65, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 20);
            this.label21.TabIndex = 27;
            this.label21.Text = "Order Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(439, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 20);
            this.label22.TabIndex = 26;
            this.label22.Text = "Material Type";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.label23.Location = new System.Drawing.Point(65, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 22);
            this.label23.TabIndex = 25;
            this.label23.Text = "Orders";
            // 
            // meterialOrder_grid
            // 
            this.meterialOrder_grid.AllowUserToAddRows = false;
            this.meterialOrder_grid.AllowUserToDeleteRows = false;
            this.meterialOrder_grid.BackgroundColor = System.Drawing.Color.White;
            this.meterialOrder_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meterialOrder_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.meterialOrder_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.meterialOrder_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.meterialOrder_grid.ColumnHeadersHeight = 32;
            this.meterialOrder_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.meterialOrder_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.meterialOrder_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.meterialOrder_grid.Location = new System.Drawing.Point(69, 155);
            this.meterialOrder_grid.Name = "meterialOrder_grid";
            this.meterialOrder_grid.ReadOnly = true;
            this.meterialOrder_grid.RowHeadersVisible = false;
            this.meterialOrder_grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.meterialOrder_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterialOrder_grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.meterialOrder_grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.meterialOrder_grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.meterialOrder_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.meterialOrder_grid.Size = new System.Drawing.Size(1022, 210);
            this.meterialOrder_grid.TabIndex = 24;
            //this.meterialOrder_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.meterialOrder_grid_CellMouseClick);
            this.meterialOrder_grid.SelectionChanged += new System.EventHandler(this.meterialOrder_grid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OrderID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Material";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Order Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "SupplierID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Supplier";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Unit Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // total_lable
            // 
            this.total_lable.AutoSize = true;
            this.total_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lable.Location = new System.Drawing.Point(671, 458);
            this.total_lable.Name = "total_lable";
            this.total_lable.Size = new System.Drawing.Size(148, 22);
            this.total_lable.TabIndex = 38;
            this.total_lable.Text = "Grand Total           :";
            // 
            // unitPrice_label
            // 
            this.unitPrice_label.AutoSize = true;
            this.unitPrice_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_label.Location = new System.Drawing.Point(668, 415);
            this.unitPrice_label.Name = "unitPrice_label";
            this.unitPrice_label.Size = new System.Drawing.Size(150, 22);
            this.unitPrice_label.TabIndex = 37;
            this.unitPrice_label.Text = "Unit Price (LKR)     :";
            // 
            // supplierName_label
            // 
            this.supplierName_label.AutoSize = true;
            this.supplierName_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierName_label.Location = new System.Drawing.Point(65, 458);
            this.supplierName_label.Name = "supplierName_label";
            this.supplierName_label.Size = new System.Drawing.Size(154, 22);
            this.supplierName_label.TabIndex = 36;
            this.supplierName_label.Text = "Supplier Name      : ";
            // 
            // supplierAccount_label
            // 
            this.supplierAccount_label.AutoSize = true;
            this.supplierAccount_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierAccount_label.Location = new System.Drawing.Point(65, 501);
            this.supplierAccount_label.Name = "supplierAccount_label";
            this.supplierAccount_label.Size = new System.Drawing.Size(151, 22);
            this.supplierAccount_label.TabIndex = 35;
            this.supplierAccount_label.Text = "Supplier Account  :";
            // 
            // supplierID_label
            // 
            this.supplierID_label.AutoSize = true;
            this.supplierID_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierID_label.Location = new System.Drawing.Point(65, 415);
            this.supplierID_label.Name = "supplierID_label";
            this.supplierID_label.Size = new System.Drawing.Size(149, 22);
            this.supplierID_label.TabIndex = 34;
            this.supplierID_label.Text = "Supplier ID             :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.label20.Location = new System.Drawing.Point(65, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 22);
            this.label20.TabIndex = 33;
            this.label20.Text = "Material Supplier";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(779, 86);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(145, 38);
            this.search.TabIndex = 40;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // viewAll
            // 
            this.viewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAll.FlatAppearance.BorderSize = 0;
            this.viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.ForeColor = System.Drawing.Color.White;
            this.viewAll.Location = new System.Drawing.Point(927, 86);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(145, 38);
            this.viewAll.TabIndex = 41;
            this.viewAll.Text = "View All";
            this.viewAll.UseVisualStyleBackColor = false;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // decline
            // 
            this.decline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.decline.FlatAppearance.BorderSize = 0;
            this.decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decline.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decline.ForeColor = System.Drawing.Color.White;
            this.decline.Location = new System.Drawing.Point(840, 541);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(251, 38);
            this.decline.TabIndex = 43;
            this.decline.Text = "Decline Transaction";
            this.decline.UseVisualStyleBackColor = false;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.approve.FlatAppearance.BorderSize = 0;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Location = new System.Drawing.Point(583, 541);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(251, 38);
            this.approve.TabIndex = 42;
            this.approve.Text = "Approve Transaction";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.stock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // rawMetirialPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 662);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.search);
            this.Controls.Add(this.total_lable);
            this.Controls.Add(this.unitPrice_label);
            this.Controls.Add(this.supplierName_label);
            this.Controls.Add(this.supplierAccount_label);
            this.Controls.Add(this.supplierID_label);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.meterialOrder_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rawMetirialPayments";
            this.Text = "rawMetirialPayments";
            this.Load += new System.EventHandler(this.rawMetirialPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meterialOrder_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox materialType;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView meterialOrder_grid;
        private System.Windows.Forms.Label total_lable;
        private System.Windows.Forms.Label unitPrice_label;
        private System.Windows.Forms.Label supplierName_label;
        private System.Windows.Forms.Label supplierAccount_label;
        private System.Windows.Forms.Label supplierID_label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}