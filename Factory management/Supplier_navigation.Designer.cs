namespace Factory_management
{
    partial class Supplier_navigation
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
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.edit_supplier = new DevComponents.DotNetBar.ButtonX();
            this.add_supplier = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX3.FocusCuesEnabled = false;
            this.buttonX3.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Image = global::Factory_management.Properties.Resources.shopping_cart_;
            this.buttonX3.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonX3.Location = new System.Drawing.Point(56, 154);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.buttonX3.Size = new System.Drawing.Size(202, 62);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "Material Orders";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX4.FocusCuesEnabled = false;
            this.buttonX4.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Image = global::Factory_management.Properties.Resources.report;
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonX4.Location = new System.Drawing.Point(56, 216);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 0, 25, 25);
            this.buttonX4.Size = new System.Drawing.Size(202, 62);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "Reports";
            // 
            // edit_supplier
            // 
            this.edit_supplier.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.edit_supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_supplier.FocusCuesEnabled = false;
            this.edit_supplier.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_supplier.Image = global::Factory_management.Properties.Resources.delivery_truck_edit;
            this.edit_supplier.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.edit_supplier.Location = new System.Drawing.Point(56, 92);
            this.edit_supplier.Name = "edit_supplier";
            this.edit_supplier.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.edit_supplier.Size = new System.Drawing.Size(202, 62);
            this.edit_supplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.edit_supplier.TabIndex = 5;
            this.edit_supplier.Text = "Edit Supplier";
            // 
            // add_supplier
            // 
            this.add_supplier.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add_supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_supplier.FocusCuesEnabled = false;
            this.add_supplier.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_supplier.Image = global::Factory_management.Properties.Resources.delivery_truck;
            this.add_supplier.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.add_supplier.Location = new System.Drawing.Point(56, 30);
            this.add_supplier.Name = "add_supplier";
            this.add_supplier.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 25, 0, 0);
            this.add_supplier.Size = new System.Drawing.Size(202, 62);
            this.add_supplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.add_supplier.TabIndex = 4;
            this.add_supplier.Text = "Add Supplier";
            // 
            // Supplier_navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 328);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.edit_supplier);
            this.Controls.Add(this.add_supplier);
            this.Name = "Supplier_navigation";
            this.Text = "Supplier_navigation";
            this.Load += new System.EventHandler(this.Supplier_navigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX edit_supplier;
        private DevComponents.DotNetBar.ButtonX add_supplier;
    }
}