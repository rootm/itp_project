namespace Factory_management 
{
    partial class distributeAgentOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(distributeAgentOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.distribute = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.agentOrdergrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentOrder = new System.Windows.Forms.RadioButton();
            this.specialOrder = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentOrdergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderid
            // 
            this.orderid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderid.Location = new System.Drawing.Point(141, 411);
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Size = new System.Drawing.Size(211, 29);
            this.orderid.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(94, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Agent Order Distribution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Order Id :";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(943, 487);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(251, 38);
            this.clear.TabIndex = 44;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // distribute
            // 
            this.distribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.distribute.FlatAppearance.BorderSize = 0;
            this.distribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distribute.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distribute.ForeColor = System.Drawing.Color.White;
            this.distribute.Location = new System.Drawing.Point(686, 487);
            this.distribute.Name = "distribute";
            this.distribute.Size = new System.Drawing.Size(251, 38);
            this.distribute.TabIndex = 43;
            this.distribute.Text = "Distribute Orders";
            this.distribute.UseVisualStyleBackColor = false;
            this.distribute.Click += new System.EventHandler(this.distribute_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(943, 97);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(251, 38);
            this.view.TabIndex = 45;
            this.view.Text = "View Orders";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(775, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(868, 411);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(211, 29);
            this.quantity.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Product Id";
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(505, 411);
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Size = new System.Drawing.Size(211, 29);
            this.pid.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // agentOrdergrid
            // 
            this.agentOrdergrid.AllowUserToAddRows = false;
            this.agentOrdergrid.AllowUserToDeleteRows = false;
            this.agentOrdergrid.BackgroundColor = System.Drawing.Color.White;
            this.agentOrdergrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.agentOrdergrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.agentOrdergrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agentOrdergrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.agentOrdergrid.ColumnHeadersHeight = 32;
            this.agentOrdergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.agentOrdergrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.agentOrdergrid.Location = new System.Drawing.Point(47, 150);
            this.agentOrdergrid.Name = "agentOrdergrid";
            this.agentOrdergrid.ReadOnly = true;
            this.agentOrdergrid.RowHeadersVisible = false;
            this.agentOrdergrid.RowHeadersWidth = 50;
            this.agentOrdergrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.agentOrdergrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentOrdergrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.agentOrdergrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.agentOrdergrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.agentOrdergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agentOrdergrid.Size = new System.Drawing.Size(1147, 240);
            this.agentOrdergrid.TabIndex = 77;
            this.agentOrdergrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.agentOrdergrid_CellMouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // agentOrder
            // 
            this.agentOrder.AutoSize = true;
            this.agentOrder.Checked = true;
            this.agentOrder.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentOrder.Location = new System.Drawing.Point(595, 103);
            this.agentOrder.Name = "agentOrder";
            this.agentOrder.Size = new System.Drawing.Size(121, 26);
            this.agentOrder.TabIndex = 78;
            this.agentOrder.TabStop = true;
            this.agentOrder.Text = "Agent Order";
            this.agentOrder.UseVisualStyleBackColor = true;
            // 
            // specialOrder
            // 
            this.specialOrder.AutoSize = true;
            this.specialOrder.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialOrder.Location = new System.Drawing.Point(759, 103);
            this.specialOrder.Name = "specialOrder";
            this.specialOrder.Size = new System.Drawing.Size(138, 26);
            this.specialOrder.TabIndex = 79;
            this.specialOrder.Text = "Special Orders";
            this.specialOrder.UseVisualStyleBackColor = true;
            // 
            // distributeAgentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.specialOrder);
            this.Controls.Add(this.agentOrder);
            this.Controls.Add(this.agentOrdergrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.view);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.distribute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "distributeAgentOrders";
            this.Text = "OrderD";
            this.Load += new System.EventHandler(this.OrderD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentOrdergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox orderid;
        //private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button distribute;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView agentOrdergrid;
        private System.Windows.Forms.RadioButton agentOrder;
        private System.Windows.Forms.RadioButton specialOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}