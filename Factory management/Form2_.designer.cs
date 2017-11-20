namespace Factory_management 
{
    partial class viewAgent_invoice
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.invoice_num = new System.Windows.Forms.Label();
            this.agent_id = new System.Windows.Forms.Label();
            this.agentName = new System.Windows.Forms.Label();
            this.agentAddress = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.Label();
            this.send_invoice = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_of_pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grand_total = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(386, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ag_Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(58, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ag_Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(386, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "OrderID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "AgentID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(707, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(118, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Agent Invoice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(501, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grand Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(55, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Invoice Details\r\n";
            // 
            // invoice_num
            // 
            this.invoice_num.AutoSize = true;
            this.invoice_num.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_num.Location = new System.Drawing.Point(169, 118);
            this.invoice_num.Name = "invoice_num";
            this.invoice_num.Size = new System.Drawing.Size(102, 22);
            this.invoice_num.TabIndex = 17;
            this.invoice_num.Text = "Invoice num";
            this.invoice_num.Click += new System.EventHandler(this.label11_Click);
            // 
            // agent_id
            // 
            this.agent_id.AutoSize = true;
            this.agent_id.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent_id.Location = new System.Drawing.Point(169, 155);
            this.agent_id.Name = "agent_id";
            this.agent_id.Size = new System.Drawing.Size(68, 22);
            this.agent_id.TabIndex = 20;
            this.agent_id.Text = "AgentId";
            this.agent_id.Click += new System.EventHandler(this.label14_Click);
            // 
            // agentName
            // 
            this.agentName.AutoSize = true;
            this.agentName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentName.Location = new System.Drawing.Point(169, 192);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(99, 22);
            this.agentName.TabIndex = 21;
            this.agentName.Text = "AgentName";
            this.agentName.Click += new System.EventHandler(this.label15_Click);
            // 
            // agentAddress
            // 
            this.agentAddress.AutoSize = true;
            this.agentAddress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentAddress.Location = new System.Drawing.Point(497, 118);
            this.agentAddress.Name = "agentAddress";
            this.agentAddress.Size = new System.Drawing.Size(116, 22);
            this.agentAddress.TabIndex = 22;
            this.agentAddress.Text = "AgentAddress";
            this.agentAddress.Click += new System.EventHandler(this.label16_Click);
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id.Location = new System.Drawing.Point(499, 155);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(69, 22);
            this.order_id.TabIndex = 23;
            this.order_id.Text = "OrderId";
            // 
            // send_invoice
            // 
            this.send_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.send_invoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_invoice.FlatAppearance.BorderSize = 0;
            this.send_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_invoice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_invoice.ForeColor = System.Drawing.Color.White;
            this.send_invoice.Location = new System.Drawing.Point(780, 529);
            this.send_invoice.Name = "send_invoice";
            this.send_invoice.Size = new System.Drawing.Size(227, 38);
            this.send_invoice.TabIndex = 162;
            this.send_invoice.Text = "Send Invoice";
            this.send_invoice.UseVisualStyleBackColor = false;
            this.send_invoice.Click += new System.EventHandler(this.send_invoice_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_type,
            this.no_of_pages,
            this.quantity,
            this.unit_price,
            this.total});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.Location = new System.Drawing.Point(60, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 214);
            this.dataGridView1.TabIndex = 172;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 150;
            // 
            // product_type
            // 
            this.product_type.HeaderText = "ProductType";
            this.product_type.Name = "product_type";
            this.product_type.ReadOnly = true;
            this.product_type.Width = 150;
            // 
            // no_of_pages
            // 
            this.no_of_pages.HeaderText = "Noumber Of Pages";
            this.no_of_pages.Name = "no_of_pages";
            this.no_of_pages.ReadOnly = true;
            this.no_of_pages.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // grand_total
            // 
            this.grand_total.AutoSize = true;
            this.grand_total.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grand_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grand_total.Location = new System.Drawing.Point(635, 537);
            this.grand_total.Name = "grand_total";
            this.grand_total.Size = new System.Drawing.Size(100, 22);
            this.grand_total.TabIndex = 173;
            this.grand_total.Text = "Grand Total";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 174;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.receipt;
            this.pictureBox1.Location = new System.Drawing.Point(21, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // viewAgent_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 607);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grand_total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.send_invoice);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.agentAddress);
            this.Controls.Add(this.agentName);
            this.Controls.Add(this.agent_id);
            this.Controls.Add(this.invoice_num);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewAgent_invoice";
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.Form2__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label invoice_num;
        private System.Windows.Forms.Label agent_id;
        private System.Windows.Forms.Label agentName;
        private System.Windows.Forms.Label agentAddress;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.Button send_invoice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label grand_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}