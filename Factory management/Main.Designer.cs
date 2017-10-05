namespace Factory_management
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agent_menu = new System.Windows.Forms.Button();
            this.vehicle_menu = new System.Windows.Forms.Button();
            this.supplier_menu = new System.Windows.Forms.Button();
            this.stocks_menu = new System.Windows.Forms.Button();
            this.employee_menu = new System.Windows.Forms.Button();
            this.finance_menu = new System.Windows.Forms.Button();
            this.users_menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 676);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.agent_menu);
            this.panel2.Controls.Add(this.vehicle_menu);
            this.panel2.Controls.Add(this.supplier_menu);
            this.panel2.Controls.Add(this.stocks_menu);
            this.panel2.Controls.Add(this.employee_menu);
            this.panel2.Controls.Add(this.finance_menu);
            this.panel2.Controls.Add(this.users_menu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 676);
            this.panel2.TabIndex = 2;
            // 
            // agent_menu
            // 
            this.agent_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agent_menu.FlatAppearance.BorderSize = 0;
            this.agent_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agent_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent_menu.ForeColor = System.Drawing.Color.White;
            this.agent_menu.Image = global::Factory_management.Properties.Resources.group;
            this.agent_menu.Location = new System.Drawing.Point(1, 603);
            this.agent_menu.Name = "agent_menu";
            this.agent_menu.Size = new System.Drawing.Size(132, 71);
            this.agent_menu.TabIndex = 7;
            this.agent_menu.Text = "Agents";
            this.agent_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agent_menu.UseVisualStyleBackColor = true;
            this.agent_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.agent_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // vehicle_menu
            // 
            this.vehicle_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicle_menu.FlatAppearance.BorderSize = 0;
            this.vehicle_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicle_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_menu.ForeColor = System.Drawing.Color.White;
            this.vehicle_menu.Image = global::Factory_management.Properties.Resources.shipped;
            this.vehicle_menu.Location = new System.Drawing.Point(0, 521);
            this.vehicle_menu.Name = "vehicle_menu";
            this.vehicle_menu.Size = new System.Drawing.Size(132, 71);
            this.vehicle_menu.TabIndex = 6;
            this.vehicle_menu.Text = "Vehicles";
            this.vehicle_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vehicle_menu.UseVisualStyleBackColor = true;
            this.vehicle_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.vehicle_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // supplier_menu
            // 
            this.supplier_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplier_menu.FlatAppearance.BorderSize = 0;
            this.supplier_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_menu.ForeColor = System.Drawing.Color.White;
            this.supplier_menu.Image = global::Factory_management.Properties.Resources.supplier;
            this.supplier_menu.Location = new System.Drawing.Point(-2, 439);
            this.supplier_menu.Name = "supplier_menu";
            this.supplier_menu.Size = new System.Drawing.Size(136, 71);
            this.supplier_menu.TabIndex = 5;
            this.supplier_menu.Text = "Suppliers";
            this.supplier_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supplier_menu.UseVisualStyleBackColor = true;
            this.supplier_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.supplier_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // stocks_menu
            // 
            this.stocks_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stocks_menu.FlatAppearance.BorderSize = 0;
            this.stocks_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocks_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocks_menu.ForeColor = System.Drawing.Color.White;
            this.stocks_menu.Image = global::Factory_management.Properties.Resources.warehouse__1_;
            this.stocks_menu.Location = new System.Drawing.Point(0, 357);
            this.stocks_menu.Name = "stocks_menu";
            this.stocks_menu.Size = new System.Drawing.Size(132, 71);
            this.stocks_menu.TabIndex = 4;
            this.stocks_menu.Text = "Stocks";
            this.stocks_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stocks_menu.UseVisualStyleBackColor = true;
            this.stocks_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.stocks_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // employee_menu
            // 
            this.employee_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_menu.FlatAppearance.BorderSize = 0;
            this.employee_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_menu.ForeColor = System.Drawing.Color.White;
            this.employee_menu.Image = global::Factory_management.Properties.Resources.employee__1_;
            this.employee_menu.Location = new System.Drawing.Point(0, 275);
            this.employee_menu.Name = "employee_menu";
            this.employee_menu.Size = new System.Drawing.Size(132, 71);
            this.employee_menu.TabIndex = 3;
            this.employee_menu.Text = "Employee";
            this.employee_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.employee_menu.UseVisualStyleBackColor = true;
            this.employee_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.employee_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // finance_menu
            // 
            this.finance_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finance_menu.FlatAppearance.BorderSize = 0;
            this.finance_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finance_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finance_menu.ForeColor = System.Drawing.Color.White;
            this.finance_menu.Image = global::Factory_management.Properties.Resources.finance_ico;
            this.finance_menu.Location = new System.Drawing.Point(0, 193);
            this.finance_menu.Name = "finance_menu";
            this.finance_menu.Size = new System.Drawing.Size(132, 71);
            this.finance_menu.TabIndex = 2;
            this.finance_menu.Text = "Financial";
            this.finance_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.finance_menu.UseVisualStyleBackColor = true;
            this.finance_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.finance_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // users_menu
            // 
            this.users_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_menu.FlatAppearance.BorderSize = 0;
            this.users_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_menu.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_menu.ForeColor = System.Drawing.Color.White;
            this.users_menu.Image = global::Factory_management.Properties.Resources.avatarNew;
            this.users_menu.Location = new System.Drawing.Point(0, 111);
            this.users_menu.Name = "users_menu";
            this.users_menu.Size = new System.Drawing.Size(132, 71);
            this.users_menu.TabIndex = 0;
            this.users_menu.Text = "Users";
            this.users_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.users_menu.UseVisualStyleBackColor = true;
            this.users_menu.Click += new System.EventHandler(this.users_menu_Click);
            this.users_menu.MouseEnter += new System.EventHandler(this.users_menu_MouseHover);
            this.users_menu.MouseLeave += new System.EventHandler(this.agent_menu_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dumidu Books";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button users_menu;
        private System.Windows.Forms.Button stocks_menu;
        private System.Windows.Forms.Button employee_menu;
        private System.Windows.Forms.Button finance_menu;
        private System.Windows.Forms.Button vehicle_menu;
        private System.Windows.Forms.Button supplier_menu;
        private System.Windows.Forms.Button agent_menu;
    }
}