namespace Factory_management
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
            this.oderId_lable = new System.Windows.Forms.Label();
            this.ViewAll = new DevComponents.DotNetBar.ButtonX();
            this.paySlip_button = new DevComponents.DotNetBar.ButtonX();
            this.confirm_button = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderPayment_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Date";
            // 
            // payDate
            // 
            this.payDate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payDate.Location = new System.Drawing.Point(151, 86);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(200, 29);
            this.payDate.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(377, 81);
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
            this.orderPayment_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderPayment_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.orderPayment_grid.Location = new System.Drawing.Point(32, 129);
            this.orderPayment_grid.Name = "orderPayment_grid";
            this.orderPayment_grid.ReadOnly = true;
            this.orderPayment_grid.Size = new System.Drawing.Size(578, 203);
            this.orderPayment_grid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Payment ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Payment Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Paid Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Invoice Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // paidAmount_label
            // 
            this.paidAmount_label.AutoSize = true;
            this.paidAmount_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmount_label.Location = new System.Drawing.Point(28, 464);
            this.paidAmount_label.Name = "paidAmount_label";
            this.paidAmount_label.Size = new System.Drawing.Size(168, 22);
            this.paidAmount_label.TabIndex = 7;
            this.paidAmount_label.Text = "Paid Amount              :";
            // 
            // invoiceAmount_lable
            // 
            this.invoiceAmount_lable.AutoSize = true;
            this.invoiceAmount_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAmount_lable.Location = new System.Drawing.Point(28, 425);
            this.invoiceAmount_lable.Name = "invoiceAmount_lable";
            this.invoiceAmount_lable.Size = new System.Drawing.Size(168, 22);
            this.invoiceAmount_lable.TabIndex = 8;
            this.invoiceAmount_lable.Text = "Invoice Amount         :";
            // 
            // agentName_lable
            // 
            this.agentName_lable.AutoSize = true;
            this.agentName_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentName_lable.Location = new System.Drawing.Point(28, 388);
            this.agentName_lable.Name = "agentName_lable";
            this.agentName_lable.Size = new System.Drawing.Size(167, 22);
            this.agentName_lable.TabIndex = 9;
            this.agentName_lable.Text = "Agent Name               :";
            // 
            // oderId_lable
            // 
            this.oderId_lable.AutoSize = true;
            this.oderId_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oderId_lable.Location = new System.Drawing.Point(28, 354);
            this.oderId_lable.Name = "oderId_lable";
            this.oderId_lable.Size = new System.Drawing.Size(167, 22);
            this.oderId_lable.TabIndex = 10;
            this.oderId_lable.Text = "Order ID                      :";
            // 
            // ViewAll
            // 
            this.ViewAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ViewAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ViewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAll.ImageTextSpacing = 5;
            this.ViewAll.Location = new System.Drawing.Point(493, 81);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 15, 0, 15);
            this.ViewAll.Size = new System.Drawing.Size(117, 39);
            this.ViewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ViewAll.SymbolColor = System.Drawing.Color.Black;
            this.ViewAll.TabIndex = 12;
            this.ViewAll.Text = "View All";
            // 
            // paySlip_button
            // 
            this.paySlip_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.paySlip_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.paySlip_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySlip_button.Image = global::Factory_management.Properties.Resources.bill;
            this.paySlip_button.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.paySlip_button.Location = new System.Drawing.Point(258, 511);
            this.paySlip_button.Name = "paySlip_button";
            this.paySlip_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15, 0, 15, 0);
            this.paySlip_button.Size = new System.Drawing.Size(164, 51);
            this.paySlip_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.paySlip_button.TabIndex = 13;
            this.paySlip_button.Text = "Payment Slip";
            // 
            // confirm_button
            // 
            this.confirm_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.confirm_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.confirm_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(422, 511);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 15, 0, 15);
            this.confirm_button.Size = new System.Drawing.Size(174, 51);
            this.confirm_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.confirm_button.TabIndex = 14;
            this.confirm_button.Text = "Confirm Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Agent Orders Payment Confirmation";
            // 
            // productAgent_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 578);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.paySlip_button);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.oderId_lable);
            this.Controls.Add(this.agentName_lable);
            this.Controls.Add(this.invoiceAmount_lable);
            this.Controls.Add(this.paidAmount_label);
            this.Controls.Add(this.orderPayment_grid);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.payDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "productAgent_payment";
            this.Text = "productAgent_payment";
            this.Load += new System.EventHandler(this.productAgent_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderPayment_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker payDate;
        private DevComponents.DotNetBar.ButtonX Search;
        private System.Windows.Forms.DataGridView orderPayment_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label paidAmount_label;
        private System.Windows.Forms.Label invoiceAmount_lable;
        private System.Windows.Forms.Label agentName_lable;
        private System.Windows.Forms.Label oderId_lable;
        private DevComponents.DotNetBar.ButtonX ViewAll;
        private DevComponents.DotNetBar.ButtonX paySlip_button;
        private DevComponents.DotNetBar.ButtonX confirm_button;
        private System.Windows.Forms.Label label2;
    }
}