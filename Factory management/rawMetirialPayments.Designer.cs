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
            this.label19 = new System.Windows.Forms.Label();
            this.viewAll = new DevComponents.DotNetBar.ButtonX();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.materialType = new System.Windows.Forms.ComboBox();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.meterialOrder_grid = new System.Windows.Forms.DataGridView();
            this.total_lable = new System.Windows.Forms.Label();
            this.unitPrice_label = new System.Windows.Forms.Label();
            this.supplierName_label = new System.Windows.Forms.Label();
            this.supplierAccount_label = new System.Windows.Forms.Label();
            this.supplierID_label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.aproveButton = new DevComponents.DotNetBar.ButtonX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.meterialOrder_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(320, 28);
            this.label19.TabIndex = 32;
            this.label19.Text = "Approve Raw Material Orders";
            // 
            // viewAll
            // 
            this.viewAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.viewAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAll.FocusCuesEnabled = false;
            this.viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.ImageTextSpacing = 5;
            this.viewAll.Location = new System.Drawing.Point(503, 66);
            this.viewAll.Name = "viewAll";
            this.viewAll.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 20, 0, 20);
            this.viewAll.Size = new System.Drawing.Size(127, 59);
            this.viewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.viewAll.Symbol = "";
            this.viewAll.SymbolColor = System.Drawing.Color.Black;
            this.viewAll.TabIndex = 31;
            this.viewAll.Text = "View All";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FocusCuesEnabled = false;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(388, 66);
            this.search.Name = "search";
            this.search.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 0, 20, 0);
            this.search.Size = new System.Drawing.Size(115, 59);
            this.search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.search.Symbol = "";
            this.search.SymbolColor = System.Drawing.Color.Black;
            this.search.TabIndex = 30;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // materialType
            // 
            this.materialType.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialType.FormattingEnabled = true;
            this.materialType.Items.AddRange(new object[] {
            "Any"});
            this.materialType.Location = new System.Drawing.Point(151, 104);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(200, 30);
            this.materialType.TabIndex = 29;
            // 
            // orderDate
            // 
            this.orderDate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(151, 66);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 29);
            this.orderDate.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 22);
            this.label21.TabIndex = 27;
            this.label21.Text = "Order Date";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(23, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 22);
            this.label22.TabIndex = 26;
            this.label22.Text = "Material Type";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(23, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 22);
            this.label23.TabIndex = 25;
            this.label23.Text = "Orders";
            // 
            // meterialOrder_grid
            // 
            this.meterialOrder_grid.AllowUserToAddRows = false;
            this.meterialOrder_grid.AllowUserToDeleteRows = false;
            this.meterialOrder_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meterialOrder_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.meterialOrder_grid.Location = new System.Drawing.Point(26, 178);
            this.meterialOrder_grid.Name = "meterialOrder_grid";
            this.meterialOrder_grid.ReadOnly = true;
            this.meterialOrder_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.meterialOrder_grid.Size = new System.Drawing.Size(604, 150);
            this.meterialOrder_grid.TabIndex = 24;
            this.meterialOrder_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.meterialOrder_grid_CellMouseClick);
            // 
            // total_lable
            // 
            this.total_lable.AutoSize = true;
            this.total_lable.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lable.Location = new System.Drawing.Point(27, 539);
            this.total_lable.Name = "total_lable";
            this.total_lable.Size = new System.Drawing.Size(148, 22);
            this.total_lable.TabIndex = 38;
            this.total_lable.Text = "Grand Total           :";
            // 
            // unitPrice_label
            // 
            this.unitPrice_label.AutoSize = true;
            this.unitPrice_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_label.Location = new System.Drawing.Point(24, 496);
            this.unitPrice_label.Name = "unitPrice_label";
            this.unitPrice_label.Size = new System.Drawing.Size(150, 22);
            this.unitPrice_label.TabIndex = 37;
            this.unitPrice_label.Text = "Unit Price (LKR)     :";
            // 
            // supplierName_label
            // 
            this.supplierName_label.AutoSize = true;
            this.supplierName_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierName_label.Location = new System.Drawing.Point(23, 415);
            this.supplierName_label.Name = "supplierName_label";
            this.supplierName_label.Size = new System.Drawing.Size(154, 22);
            this.supplierName_label.TabIndex = 36;
            this.supplierName_label.Text = "Supplier Name      : ";
            // 
            // supplierAccount_label
            // 
            this.supplierAccount_label.AutoSize = true;
            this.supplierAccount_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierAccount_label.Location = new System.Drawing.Point(24, 455);
            this.supplierAccount_label.Name = "supplierAccount_label";
            this.supplierAccount_label.Size = new System.Drawing.Size(147, 22);
            this.supplierAccount_label.TabIndex = 35;
            this.supplierAccount_label.Text = "Supplier Account :";
            // 
            // supplierID_label
            // 
            this.supplierID_label.AutoSize = true;
            this.supplierID_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierID_label.Location = new System.Drawing.Point(23, 377);
            this.supplierID_label.Name = "supplierID_label";
            this.supplierID_label.Size = new System.Drawing.Size(149, 22);
            this.supplierID_label.TabIndex = 34;
            this.supplierID_label.Text = "Supplier ID             :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 343);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 22);
            this.label20.TabIndex = 33;
            this.label20.Text = "Material Supplier";
            // 
            // aproveButton
            // 
            this.aproveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.aproveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.aproveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aproveButton.FocusCuesEnabled = false;
            this.aproveButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aproveButton.Image = global::Factory_management.Properties.Resources.shopping_cart_;
            this.aproveButton.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.aproveButton.ImageTextSpacing = 10;
            this.aproveButton.Location = new System.Drawing.Point(417, 579);
            this.aproveButton.Name = "aproveButton";
            this.aproveButton.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.aproveButton.Size = new System.Drawing.Size(213, 59);
            this.aproveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.aproveButton.TabIndex = 39;
            this.aproveButton.Text = "Approve Order";
            this.aproveButton.Click += new System.EventHandler(this.aproveButton_Click);
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
            // 
            // rawMetirialPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 662);
            this.ControlBox = false;
            this.Controls.Add(this.aproveButton);
            this.Controls.Add(this.total_lable);
            this.Controls.Add(this.unitPrice_label);
            this.Controls.Add(this.supplierName_label);
            this.Controls.Add(this.supplierAccount_label);
            this.Controls.Add(this.supplierID_label);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.search);
            this.Controls.Add(this.materialType);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.meterialOrder_grid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rawMetirialPayments";
            this.Text = "rawMetirialPayments";
            this.Load += new System.EventHandler(this.rawMetirialPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meterialOrder_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private DevComponents.DotNetBar.ButtonX viewAll;
        private DevComponents.DotNetBar.ButtonX search;
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
        private DevComponents.DotNetBar.ButtonX aproveButton;
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