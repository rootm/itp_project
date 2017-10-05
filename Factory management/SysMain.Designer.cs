namespace Factory_management
{
    partial class SysMain
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
            this.side_menu = new System.Windows.Forms.Panel();
            this.supplier_button = new DevComponents.DotNetBar.ButtonX();
            this.vehicle_button = new DevComponents.DotNetBar.ButtonX();
            this.emp_button = new DevComponents.DotNetBar.ButtonX();
            this.agent_button = new DevComponents.DotNetBar.ButtonX();
            this.stock_button = new DevComponents.DotNetBar.ButtonX();
            this.finance_button = new DevComponents.DotNetBar.ButtonX();
            this.user_button = new DevComponents.DotNetBar.ButtonX();
            this.side_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_menu
            // 
            this.side_menu.BackColor = System.Drawing.Color.DarkGray;
            this.side_menu.Controls.Add(this.supplier_button);
            this.side_menu.Controls.Add(this.vehicle_button);
            this.side_menu.Controls.Add(this.emp_button);
            this.side_menu.Controls.Add(this.agent_button);
            this.side_menu.Controls.Add(this.stock_button);
            this.side_menu.Controls.Add(this.finance_button);
            this.side_menu.Controls.Add(this.user_button);
            this.side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_menu.Location = new System.Drawing.Point(0, 0);
            this.side_menu.Margin = new System.Windows.Forms.Padding(0);
            this.side_menu.Name = "side_menu";
            this.side_menu.Size = new System.Drawing.Size(193, 661);
            this.side_menu.TabIndex = 1;
            this.side_menu.Visible = false;
            this.side_menu.MouseLeave += new System.EventHandler(this.side_menu_MouseLeave);
            // 
            // supplier_button
            // 
            this.supplier_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.supplier_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.supplier_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_button.FocusCuesEnabled = false;
            this.supplier_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_button.Image = global::Factory_management.Properties.Resources.packing;
            this.supplier_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.supplier_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.supplier_button.Location = new System.Drawing.Point(1, 504);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.supplier_button.Size = new System.Drawing.Size(165, 84);
            this.supplier_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.supplier_button.TabIndex = 6;
            this.supplier_button.Text = "Supplier Management";
            this.supplier_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            this.supplier_button.MouseLeave += new System.EventHandler(this.side_menu_MouseLeave);
            // 
            // vehicle_button
            // 
            this.vehicle_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.vehicle_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.vehicle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicle_button.FocusCuesEnabled = false;
            this.vehicle_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_button.Image = global::Factory_management.Properties.Resources.vehicles__1_;
            this.vehicle_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.vehicle_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.vehicle_button.Location = new System.Drawing.Point(1, 420);
            this.vehicle_button.Name = "vehicle_button";
            this.vehicle_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.vehicle_button.Size = new System.Drawing.Size(165, 84);
            this.vehicle_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vehicle_button.TabIndex = 5;
            this.vehicle_button.Text = "Vehicle Management";
            this.vehicle_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // emp_button
            // 
            this.emp_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.emp_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.emp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_button.FocusCuesEnabled = false;
            this.emp_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_button.Image = global::Factory_management.Properties.Resources.employee;
            this.emp_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.emp_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.emp_button.Location = new System.Drawing.Point(1, 336);
            this.emp_button.Name = "emp_button";
            this.emp_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.emp_button.Size = new System.Drawing.Size(165, 84);
            this.emp_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.emp_button.TabIndex = 4;
            this.emp_button.Text = "Employee Management";
            this.emp_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // agent_button
            // 
            this.agent_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.agent_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.agent_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agent_button.FocusCuesEnabled = false;
            this.agent_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent_button.Image = global::Factory_management.Properties.Resources.agent;
            this.agent_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.agent_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.agent_button.Location = new System.Drawing.Point(1, 252);
            this.agent_button.Name = "agent_button";
            this.agent_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.agent_button.Size = new System.Drawing.Size(165, 84);
            this.agent_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.agent_button.TabIndex = 3;
            this.agent_button.Text = "Agent Management";
            this.agent_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // stock_button
            // 
            this.stock_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.stock_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.stock_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stock_button.FocusCuesEnabled = false;
            this.stock_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_button.Image = global::Factory_management.Properties.Resources.stock;
            this.stock_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.stock_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.stock_button.Location = new System.Drawing.Point(1, 168);
            this.stock_button.Name = "stock_button";
            this.stock_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.stock_button.Size = new System.Drawing.Size(165, 84);
            this.stock_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.stock_button.TabIndex = 2;
            this.stock_button.Text = "Stock Management";
            this.stock_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // finance_button
            // 
            this.finance_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finance_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.finance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finance_button.FocusCuesEnabled = false;
            this.finance_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finance_button.Image = global::Factory_management.Properties.Resources.finance;
            this.finance_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.finance_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.finance_button.Location = new System.Drawing.Point(1, 84);
            this.finance_button.Name = "finance_button";
            this.finance_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.finance_button.Size = new System.Drawing.Size(165, 84);
            this.finance_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.finance_button.TabIndex = 1;
            this.finance_button.Text = "Financial Management";
            this.finance_button.Click += new System.EventHandler(this.finance_button_Click);
            this.finance_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // user_button
            // 
            this.user_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.user_button.BackColor = System.Drawing.SystemColors.Control;
            this.user_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_button.FocusCuesEnabled = false;
            this.user_button.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_button.Image = global::Factory_management.Properties.Resources.users;
            this.user_button.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.user_button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.user_button.Location = new System.Drawing.Point(1, 0);
            this.user_button.Name = "user_button";
            this.user_button.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.user_button.Size = new System.Drawing.Size(165, 84);
            this.user_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.user_button.TabIndex = 0;
            this.user_button.Text = "Users";
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            this.user_button.MouseEnter += new System.EventHandler(this.side_menu_MouseEnter);
            // 
            // SysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.side_menu);
            this.IsMdiContainer = true;
            this.Name = "SysMain";
            this.Text = "SysMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SysMain_Load);
            this.side_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel side_menu;
        private DevComponents.DotNetBar.ButtonX stock_button;
        private DevComponents.DotNetBar.ButtonX agent_button;
        private DevComponents.DotNetBar.ButtonX emp_button;
        private DevComponents.DotNetBar.ButtonX vehicle_button;
        private DevComponents.DotNetBar.ButtonX supplier_button;
        internal DevComponents.DotNetBar.ButtonX finance_button;
        internal DevComponents.DotNetBar.ButtonX user_button;
    }
}



