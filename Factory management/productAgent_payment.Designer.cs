﻿namespace Factory_management
{
    partial class productAgent_payment
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
            this.payDate = new System.Windows.Forms.DateTimePicker();
            this.Search = new DevComponents.DotNetBar.ButtonX();
            this.orderPayment_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAmount_label = new System.Windows.Forms.Label();
            this.invoiceAmount_lable = new System.Windows.Forms.Label();
            this.agentName_lable = new System.Windows.Forms.Label();
            this.orderId_lable = new System.Windows.Forms.Label();
            this.ViewAll = new DevComponents.DotNetBar.ButtonX();
            this.confirm_button = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentSlip_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentSlip_pictureBox = new System.Windows.Forms.PictureBox();
            this.paySlip_button = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.orderPayment_grid)).BeginInit();
            this.paymentSlip_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSlip_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Date";
            // 
            // payDate
            // 
            this.payDate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payDate.Location = new System.Drawing.Point(189, 112);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(200, 29);
            this.payDate.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Search.FocusCuesEnabled = false;
            this.Search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1070, 68);
            this.Search.Name = "Search";
            this.Search.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15, 0, 15, 0);
            this.Search.Size = new System.Drawing.Size(118, 39);
            this.Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Search.Symbol = "";
            this.Search.SymbolColor = System.Drawing.Color.Black;
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // orderPayment_grid
            // 
            this.orderPayment_grid.AllowUserToAddRows = false;
            this.orderPayment_grid.AllowUserToDeleteRows = false;
            this.orderPayment_grid.BackgroundColor = System.Drawing.Color.White;
            this.orderPayment_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderPayment_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderPayment_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderPayment_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderPayment_grid.ColumnHeadersHeight = 32;
            this.orderPayment_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderPayment_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.orderPayment_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.orderPayment_grid.Location = new System.Drawing.Point(70, 155);
            this.orderPayment_grid.Name = "orderPayment_grid";
            this.orderPayment_grid.ReadOnly = true;
            this.orderPayment_grid.RowHeadersVisible = false;
            this.orderPayment_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPayment_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderPayment_grid.Size = new System.Drawing.Size(906, 241);
            this.orderPayment_grid.TabIndex = 4;
            this.orderPayment_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderPayment_grid_CellMouseClick);
            this.orderPayment_grid.SelectionChanged += new System.EventHandler(this.orderPayment_grid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Payment ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Agent ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Agent Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Payment Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Paid Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Invoice Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // paidAmount_label
            // 
            this.paidAmount_label.AutoSize = true;
            this.paidAmount_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmount_label.Location = new System.Drawing.Point(66, 522);
            this.paidAmount_label.Name = "paidAmount_label";
            this.paidAmount_label.Size = new System.Drawing.Size(168, 22);
            this.paidAmount_label.TabIndex = 7;
            this.paidAmount_label.Text = "Paid Amount              :";
            // 
            // invoiceAmount_lable
            // 
            this.invoiceAmount_lable.AutoSize = true;
            this.invoiceAmount_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAmount_lable.Location = new System.Drawing.Point(66, 483);
            this.invoiceAmount_lable.Name = "invoiceAmount_lable";
            this.invoiceAmount_lable.Size = new System.Drawing.Size(168, 22);
            this.invoiceAmount_lable.TabIndex = 8;
            this.invoiceAmount_lable.Text = "Invoice Amount         :";
            // 
            // agentName_lable
            // 
            this.agentName_lable.AutoSize = true;
            this.agentName_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentName_lable.Location = new System.Drawing.Point(66, 446);
            this.agentName_lable.Name = "agentName_lable";
            this.agentName_lable.Size = new System.Drawing.Size(167, 22);
            this.agentName_lable.TabIndex = 9;
            this.agentName_lable.Text = "Agent Name               :";
            // 
            // orderId_lable
            // 
            this.orderId_lable.AutoSize = true;
            this.orderId_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId_lable.Location = new System.Drawing.Point(66, 412);
            this.orderId_lable.Name = "orderId_lable";
            this.orderId_lable.Size = new System.Drawing.Size(167, 22);
            this.orderId_lable.TabIndex = 10;
            this.orderId_lable.Text = "Order ID                      :";
            // 
            // ViewAll
            // 
            this.ViewAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ViewAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ViewAll.FocusCuesEnabled = false;
            this.ViewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAll.ImageTextSpacing = 5;
            this.ViewAll.Location = new System.Drawing.Point(1074, 23);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 15, 0, 15);
            this.ViewAll.Size = new System.Drawing.Size(117, 39);
            this.ViewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ViewAll.SymbolColor = System.Drawing.Color.Black;
            this.ViewAll.TabIndex = 12;
            this.ViewAll.Text = "View All";
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.confirm_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.confirm_button.Enabled = false;
            this.confirm_button.FocusCuesEnabled = false;
            this.confirm_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(1043, 181);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 15, 0, 15);
            this.confirm_button.Size = new System.Drawing.Size(174, 51);
            this.confirm_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.confirm_button.TabIndex = 14;
            this.confirm_button.Text = "Confirm Payment";
            this.confirm_button.Visible = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(94, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agent Orders Payment Confirmation";
            // 
            // paymentSlip_panel
            // 
            this.paymentSlip_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.paymentSlip_panel.Controls.Add(this.paymentSlip_pictureBox);
            this.paymentSlip_panel.Location = new System.Drawing.Point(157, 64);
            this.paymentSlip_panel.Name = "paymentSlip_panel";
            this.paymentSlip_panel.Size = new System.Drawing.Size(601, 13);
            this.paymentSlip_panel.TabIndex = 16;
            this.paymentSlip_panel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(590, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 38);
            this.button2.TabIndex = 43;
            this.button2.Text = "View All";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(416, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 42;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(725, 569);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 38);
            this.button3.TabIndex = 45;
            this.button3.Text = "Decline Transaction";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(468, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 38);
            this.button4.TabIndex = 44;
            this.button4.Text = "Approve Transaction";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(778, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 38);
            this.button5.TabIndex = 46;
            this.button5.Text = "Payment Slip";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.agent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // paymentSlip_pictureBox
            // 
            this.paymentSlip_pictureBox.BackColor = System.Drawing.Color.White;
            this.paymentSlip_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentSlip_pictureBox.Location = new System.Drawing.Point(39, 48);
            this.paymentSlip_pictureBox.Name = "paymentSlip_pictureBox";
            this.paymentSlip_pictureBox.Size = new System.Drawing.Size(525, 307);
            this.paymentSlip_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paymentSlip_pictureBox.TabIndex = 0;
            this.paymentSlip_pictureBox.TabStop = false;
            // 
            // paySlip_button
            // 
            this.paySlip_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.paySlip_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.paySlip_button.Enabled = false;
            this.paySlip_button.FocusCuesEnabled = false;
            this.paySlip_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySlip_button.Image = global::Factory_management.Properties.Resources.bill;
            this.paySlip_button.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.paySlip_button.Location = new System.Drawing.Point(1011, 124);
            this.paySlip_button.Name = "paySlip_button";
            this.paySlip_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15, 0, 15, 0);
            this.paySlip_button.Size = new System.Drawing.Size(164, 51);
            this.paySlip_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.paySlip_button.TabIndex = 13;
            this.paySlip_button.Text = "Payment Slip";
            this.paySlip_button.Visible = false;
            this.paySlip_button.Click += new System.EventHandler(this.paySlip_button_Click);
            // 
            // productAgent_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 629);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paymentSlip_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.paySlip_button);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.orderId_lable);
            this.Controls.Add(this.agentName_lable);
            this.Controls.Add(this.invoiceAmount_lable);
            this.Controls.Add(this.paidAmount_label);
            this.Controls.Add(this.orderPayment_grid);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.payDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productAgent_payment";
            this.Text = "productAgent_payment";
            this.Load += new System.EventHandler(this.productAgent_payment_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productAgent_payment_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.orderPayment_grid)).EndInit();
            this.paymentSlip_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSlip_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker payDate;
        private DevComponents.DotNetBar.ButtonX Search;
        private System.Windows.Forms.DataGridView orderPayment_grid;
        private System.Windows.Forms.Label paidAmount_label;
        private System.Windows.Forms.Label invoiceAmount_lable;
        private System.Windows.Forms.Label agentName_lable;
        private System.Windows.Forms.Label orderId_lable;
        private DevComponents.DotNetBar.ButtonX ViewAll;
        private DevComponents.DotNetBar.ButtonX paySlip_button;
        private DevComponents.DotNetBar.ButtonX confirm_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paymentSlip_panel;
        private System.Windows.Forms.PictureBox paymentSlip_pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}