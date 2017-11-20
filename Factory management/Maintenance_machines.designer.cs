namespace Factory_management
{
    partial class Maintenance_machines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.machineNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invoice = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save_repair = new System.Windows.Forms.Button();
            this.receipt_description = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.sericeCenter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewAll = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.machineRepairGriid = new System.Windows.Forms.DataGridView();
            this.machine_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machine_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrenty_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineRepairGriid)).BeginInit();
            this.SuspendLayout();
            // 
            // machineNo
            // 
            this.machineNo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineNo.Location = new System.Drawing.Point(191, 104);
            this.machineNo.Margin = new System.Windows.Forms.Padding(2);
            this.machineNo.Name = "machineNo";
            this.machineNo.Size = new System.Drawing.Size(190, 29);
            this.machineNo.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(186, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 30);
            this.label6.TabIndex = 110;
            this.label6.Text = "Machine Repairs";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invoice);
            this.panel2.Controls.Add(this.cost);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.save_repair);
            this.panel2.Controls.Add(this.receipt_description);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.sericeCenter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(53, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 262);
            this.panel2.TabIndex = 113;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoice.FlatAppearance.BorderSize = 0;
            this.invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.ForeColor = System.Drawing.Color.White;
            this.invoice.Location = new System.Drawing.Point(454, 184);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(227, 38);
            this.invoice.TabIndex = 169;
            this.invoice.Text = "Invoice";
            this.invoice.UseVisualStyleBackColor = false;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(212, 91);
            this.cost.Margin = new System.Windows.Forms.Padding(2);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(184, 29);
            this.cost.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 167;
            this.label5.Text = "Cost";
            // 
            // save_repair
            // 
            this.save_repair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.save_repair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_repair.FlatAppearance.BorderSize = 0;
            this.save_repair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_repair.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_repair.ForeColor = System.Drawing.Color.White;
            this.save_repair.Location = new System.Drawing.Point(687, 184);
            this.save_repair.Name = "save_repair";
            this.save_repair.Size = new System.Drawing.Size(227, 38);
            this.save_repair.TabIndex = 166;
            this.save_repair.Text = "Save Repair Details";
            this.save_repair.UseVisualStyleBackColor = false;
            this.save_repair.Click += new System.EventHandler(this.save_repair_Click);
            // 
            // receipt_description
            // 
            this.receipt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_description.Location = new System.Drawing.Point(730, 97);
            this.receipt_description.Name = "receipt_description";
            this.receipt_description.Size = new System.Drawing.Size(184, 26);
            this.receipt_description.TabIndex = 6;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(730, 30);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(184, 29);
            this.date.TabIndex = 5;
            // 
            // sericeCenter
            // 
            this.sericeCenter.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sericeCenter.FormattingEnabled = true;
            this.sericeCenter.Location = new System.Drawing.Point(212, 32);
            this.sericeCenter.Name = "sericeCenter";
            this.sericeCenter.Size = new System.Drawing.Size(184, 30);
            this.sericeCenter.TabIndex = 4;
            this.sericeCenter.SelectedIndexChanged += new System.EventHandler(this.sericeCenter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repair Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Center";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Factory_management.Properties.Resources.repair;
            this.pictureBox3.Location = new System.Drawing.Point(53, 16);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 114;
            this.label4.Text = "Machine No";
            // 
            // viewAll
            // 
            this.viewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAll.FlatAppearance.BorderSize = 0;
            this.viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.ForeColor = System.Drawing.Color.White;
            this.viewAll.Location = new System.Drawing.Point(767, 95);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(227, 38);
            this.viewAll.TabIndex = 164;
            this.viewAll.Text = "View All";
            this.viewAll.UseVisualStyleBackColor = false;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(530, 95);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(227, 38);
            this.search.TabIndex = 165;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // machineRepairGriid
            // 
            this.machineRepairGriid.AllowUserToAddRows = false;
            this.machineRepairGriid.AllowUserToDeleteRows = false;
            this.machineRepairGriid.BackgroundColor = System.Drawing.Color.White;
            this.machineRepairGriid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.machineRepairGriid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.machineRepairGriid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.machineRepairGriid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.machineRepairGriid.ColumnHeadersHeight = 32;
            this.machineRepairGriid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machine_no,
            this.machine_type,
            this.purchase_date,
            this.warrenty_date,
            this.price,
            this.company,
            this.address,
            this.telephone});
            this.machineRepairGriid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.machineRepairGriid.Location = new System.Drawing.Point(53, 184);
            this.machineRepairGriid.Name = "machineRepairGriid";
            this.machineRepairGriid.ReadOnly = true;
            this.machineRepairGriid.RowHeadersVisible = false;
            this.machineRepairGriid.RowHeadersWidth = 50;
            this.machineRepairGriid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.machineRepairGriid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineRepairGriid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.machineRepairGriid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.machineRepairGriid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.machineRepairGriid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.machineRepairGriid.Size = new System.Drawing.Size(1206, 138);
            this.machineRepairGriid.TabIndex = 168;
            this.machineRepairGriid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellContentClick_1);
            this.machineRepairGriid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.machineRepairGriid_CellMouseClick);
            // 
            // machine_no
            // 
            this.machine_no.HeaderText = "Machine Number";
            this.machine_no.Name = "machine_no";
            this.machine_no.ReadOnly = true;
            this.machine_no.Width = 150;
            // 
            // machine_type
            // 
            this.machine_type.HeaderText = "Machine Type";
            this.machine_type.Name = "machine_type";
            this.machine_type.ReadOnly = true;
            this.machine_type.Width = 150;
            // 
            // purchase_date
            // 
            this.purchase_date.HeaderText = "Purchase Date";
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            this.purchase_date.Width = 150;
            // 
            // warrenty_date
            // 
            this.warrenty_date.HeaderText = "Warrenty Date";
            this.warrenty_date.Name = "warrenty_date";
            this.warrenty_date.ReadOnly = true;
            this.warrenty_date.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            this.company.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone Number";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Width = 150;
            // 
            // Maintenance_machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.machineRepairGriid);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.machineNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance_machines";
            this.Text = "Maintenance_machines";
            this.Load += new System.EventHandler(this.Maintenance_machines_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineRepairGriid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox machineNo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox receipt_description;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox sericeCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save_repair;
        private System.Windows.Forms.DataGridView machineRepairGriid;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn machine_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrenty_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button invoice;
    }
}