namespace Factory_management 
{
    partial class agentOder_details
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.order_search = new System.Windows.Forms.Button();
            this.order_viewAll = new System.Windows.Forms.Button();
            this.cancel_order = new System.Windows.Forms.Button();
            this.approve_order = new System.Windows.Forms.Button();
            this.delivered_orders = new System.Windows.Forms.Button();
            this.pending_orders = new System.Windows.Forms.Button();
            this.add_order = new System.Windows.Forms.Button();
            this.view_stock = new System.Windows.Forms.Button();
            this.request_order = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 25);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(123, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = " Agent Order Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.shopping_cart_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // order_search
            // 
            this.order_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.order_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_search.FlatAppearance.BorderSize = 0;
            this.order_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_search.ForeColor = System.Drawing.Color.White;
            this.order_search.Location = new System.Drawing.Point(373, 174);
            this.order_search.Name = "order_search";
            this.order_search.Size = new System.Drawing.Size(227, 38);
            this.order_search.TabIndex = 163;
            this.order_search.Text = "Search";
            this.order_search.UseVisualStyleBackColor = false;
            this.order_search.Click += new System.EventHandler(this.order_search_Click);
            // 
            // order_viewAll
            // 
            this.order_viewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.order_viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_viewAll.FlatAppearance.BorderSize = 0;
            this.order_viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_viewAll.ForeColor = System.Drawing.Color.White;
            this.order_viewAll.Location = new System.Drawing.Point(638, 174);
            this.order_viewAll.Name = "order_viewAll";
            this.order_viewAll.Size = new System.Drawing.Size(227, 38);
            this.order_viewAll.TabIndex = 162;
            this.order_viewAll.Text = "View All";
            this.order_viewAll.UseVisualStyleBackColor = false;
            this.order_viewAll.Click += new System.EventHandler(this.order_viewAll_Click);
            // 
            // cancel_order
            // 
            this.cancel_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.cancel_order.FlatAppearance.BorderSize = 0;
            this.cancel_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_order.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_order.ForeColor = System.Drawing.Color.White;
            this.cancel_order.Location = new System.Drawing.Point(1053, 442);
            this.cancel_order.Name = "cancel_order";
            this.cancel_order.Size = new System.Drawing.Size(251, 38);
            this.cancel_order.TabIndex = 165;
            this.cancel_order.Text = "Decline Order";
            this.cancel_order.UseVisualStyleBackColor = false;
            this.cancel_order.Click += new System.EventHandler(this.cancel_order_Click);
            // 
            // approve_order
            // 
            this.approve_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.approve_order.FlatAppearance.BorderSize = 0;
            this.approve_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve_order.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve_order.ForeColor = System.Drawing.Color.White;
            this.approve_order.Location = new System.Drawing.Point(796, 442);
            this.approve_order.Name = "approve_order";
            this.approve_order.Size = new System.Drawing.Size(251, 38);
            this.approve_order.TabIndex = 164;
            this.approve_order.Text = "Approve Order";
            this.approve_order.UseVisualStyleBackColor = false;
            this.approve_order.Click += new System.EventHandler(this.approve_order_Click);
            // 
            // delivered_orders
            // 
            this.delivered_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.delivered_orders.FlatAppearance.BorderSize = 0;
            this.delivered_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivered_orders.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivered_orders.ForeColor = System.Drawing.Color.White;
            this.delivered_orders.Location = new System.Drawing.Point(1053, 266);
            this.delivered_orders.Name = "delivered_orders";
            this.delivered_orders.Size = new System.Drawing.Size(251, 38);
            this.delivered_orders.TabIndex = 167;
            this.delivered_orders.Text = "Delivered Orders";
            this.delivered_orders.UseVisualStyleBackColor = false;
            this.delivered_orders.Click += new System.EventHandler(this.delivered_orders_Click);
            // 
            // pending_orders
            // 
            this.pending_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.pending_orders.FlatAppearance.BorderSize = 0;
            this.pending_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pending_orders.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pending_orders.ForeColor = System.Drawing.Color.White;
            this.pending_orders.Location = new System.Drawing.Point(796, 266);
            this.pending_orders.Name = "pending_orders";
            this.pending_orders.Size = new System.Drawing.Size(251, 38);
            this.pending_orders.TabIndex = 166;
            this.pending_orders.Text = "Pending Orders";
            this.pending_orders.UseVisualStyleBackColor = false;
            this.pending_orders.Click += new System.EventHandler(this.pending_orders_Click);
            // 
            // add_order
            // 
            this.add_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.add_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_order.FlatAppearance.BorderSize = 0;
            this.add_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_order.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_order.ForeColor = System.Drawing.Color.White;
            this.add_order.Location = new System.Drawing.Point(72, 580);
            this.add_order.Name = "add_order";
            this.add_order.Size = new System.Drawing.Size(227, 38);
            this.add_order.TabIndex = 168;
            this.add_order.Text = "Add New Order";
            this.add_order.UseVisualStyleBackColor = false;
            this.add_order.Click += new System.EventHandler(this.add_order_Click);
            // 
            // view_stock
            // 
            this.view_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_stock.FlatAppearance.BorderSize = 0;
            this.view_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_stock.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_stock.ForeColor = System.Drawing.Color.White;
            this.view_stock.Location = new System.Drawing.Point(305, 580);
            this.view_stock.Name = "view_stock";
            this.view_stock.Size = new System.Drawing.Size(227, 38);
            this.view_stock.TabIndex = 169;
            this.view_stock.Text = "View Stock";
            this.view_stock.UseVisualStyleBackColor = false;
            this.view_stock.Click += new System.EventHandler(this.view_stock_Click);
            // 
            // request_order
            // 
            this.request_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.request_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.request_order.FlatAppearance.BorderSize = 0;
            this.request_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request_order.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_order.ForeColor = System.Drawing.Color.White;
            this.request_order.Location = new System.Drawing.Point(538, 580);
            this.request_order.Name = "request_order";
            this.request_order.Size = new System.Drawing.Size(227, 38);
            this.request_order.TabIndex = 170;
            this.request_order.Text = "Request Order";
            this.request_order.UseVisualStyleBackColor = false;
            this.request_order.Click += new System.EventHandler(this.request_order_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 32;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView2.Location = new System.Drawing.Point(72, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(705, 248);
            this.dataGridView2.TabIndex = 173;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Agent ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Order Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // agentOder_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.request_order);
            this.Controls.Add(this.view_stock);
            this.Controls.Add(this.add_order);
            this.Controls.Add(this.delivered_orders);
            this.Controls.Add(this.pending_orders);
            this.Controls.Add(this.cancel_order);
            this.Controls.Add(this.approve_order);
            this.Controls.Add(this.order_search);
            this.Controls.Add(this.order_viewAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "agentOder_details";
            this.Text = "Check Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button order_search;
        private System.Windows.Forms.Button order_viewAll;
        private System.Windows.Forms.Button cancel_order;
        private System.Windows.Forms.Button approve_order;
        private System.Windows.Forms.Button delivered_orders;
        private System.Windows.Forms.Button pending_orders;
        private System.Windows.Forms.Button add_order;
        private System.Windows.Forms.Button view_stock;
        private System.Windows.Forms.Button request_order;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

