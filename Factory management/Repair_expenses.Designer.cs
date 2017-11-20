namespace Factory_management
{
    partial class Repair_expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repairDetails_grid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.numMachine = new System.Windows.Forms.Label();
            this.numVehicles = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.declineButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.repairCost_label = new System.Windows.Forms.Label();
            this.serviceCenter_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repairDetails_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(100, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "View Repair Expense Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(476, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Expenses Details";
            // 
            // repairDetails_grid
            // 
            this.repairDetails_grid.AllowUserToAddRows = false;
            this.repairDetails_grid.AllowUserToDeleteRows = false;
            this.repairDetails_grid.BackgroundColor = System.Drawing.Color.White;
            this.repairDetails_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.repairDetails_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.repairDetails_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repairDetails_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.repairDetails_grid.ColumnHeadersHeight = 32;
            this.repairDetails_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.repairDetails_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.repairDetails_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.repairDetails_grid.Location = new System.Drawing.Point(480, 107);
            this.repairDetails_grid.Name = "repairDetails_grid";
            this.repairDetails_grid.ReadOnly = true;
            this.repairDetails_grid.RowHeadersVisible = false;
            this.repairDetails_grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.repairDetails_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDetails_grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.repairDetails_grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.repairDetails_grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.repairDetails_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.repairDetails_grid.Size = new System.Drawing.Size(647, 236);
            this.repairDetails_grid.TabIndex = 12;
            this.repairDetails_grid.SelectionChanged += new System.EventHandler(this.repairDetails_grid_SelectionChanged);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Repair ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Machine ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Machine Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Repair Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 175;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.repair1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.numMachine);
            this.panel4.Controls.Add(this.numVehicles);
            this.panel4.Location = new System.Drawing.Point(12, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 135);
            this.panel4.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(18, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 22);
            this.label18.TabIndex = 29;
            this.label18.Text = "Number Of Total Repairs";
            // 
            // numMachine
            // 
            this.numMachine.AutoSize = true;
            this.numMachine.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.numMachine.Location = new System.Drawing.Point(36, 51);
            this.numMachine.Name = "numMachine";
            this.numMachine.Size = new System.Drawing.Size(104, 22);
            this.numMachine.TabIndex = 31;
            this.numMachine.Text = "Machines   :";
            // 
            // numVehicles
            // 
            this.numVehicles.AutoSize = true;
            this.numVehicles.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.numVehicles.Location = new System.Drawing.Point(36, 82);
            this.numVehicles.Name = "numVehicles";
            this.numVehicles.Size = new System.Drawing.Size(104, 22);
            this.numVehicles.TabIndex = 30;
            this.numVehicles.Text = "Vehicles      :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.pieChart1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 289);
            this.panel1.TabIndex = 36;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(22, 57);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(401, 221);
            this.pieChart1.TabIndex = 33;
            this.pieChart1.Text = "pieChart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total Expenses By Catogory";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(876, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(251, 38);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Declined"});
            this.status.Location = new System.Drawing.Point(607, 65);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(246, 28);
            this.status.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Approve Status :";
            // 
            // declineButton
            // 
            this.declineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.declineButton.FlatAppearance.BorderSize = 0;
            this.declineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.declineButton.ForeColor = System.Drawing.Color.White;
            this.declineButton.Location = new System.Drawing.Point(923, 553);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(218, 38);
            this.declineButton.TabIndex = 41;
            this.declineButton.Text = "Decline Transaction";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.approveButton.FlatAppearance.BorderSize = 0;
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(699, 553);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(218, 38);
            this.approveButton.TabIndex = 40;
            this.approveButton.Text = "Approve Transaction";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // repairCost_label
            // 
            this.repairCost_label.AutoSize = true;
            this.repairCost_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCost_label.Location = new System.Drawing.Point(497, 443);
            this.repairCost_label.Name = "repairCost_label";
            this.repairCost_label.Size = new System.Drawing.Size(153, 22);
            this.repairCost_label.TabIndex = 43;
            this.repairCost_label.Text = "Repair Cost            : ";
            // 
            // serviceCenter_label
            // 
            this.serviceCenter_label.AutoSize = true;
            this.serviceCenter_label.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCenter_label.Location = new System.Drawing.Point(497, 400);
            this.serviceCenter_label.Name = "serviceCenter_label";
            this.serviceCenter_label.Size = new System.Drawing.Size(147, 22);
            this.serviceCenter_label.TabIndex = 42;
            this.serviceCenter_label.Text = "Service Center      :";
            // 
            // Repair_expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 612);
            this.ControlBox = false;
            this.Controls.Add(this.repairCost_label);
            this.Controls.Add(this.serviceCenter_label);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repairDetails_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repair_expenses";
            this.Text = "Repair_expenses";
            this.Load += new System.EventHandler(this.Repair_expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repairDetails_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView repairDetails_grid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label numMachine;
        private System.Windows.Forms.Label numVehicles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label repairCost_label;
        private System.Windows.Forms.Label serviceCenter_label;
    }
}