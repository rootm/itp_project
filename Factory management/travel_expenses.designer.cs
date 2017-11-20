namespace Factory_management
{
    partial class travel_expenses
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
            this.label2 = new System.Windows.Forms.Label();
            this.transportType = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expense = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            this.view_all = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.invoice = new System.Windows.Forms.Button();
            this.sheduleGrid = new System.Windows.Forms.DataGridView();
            this.approveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transport Date";
            // 
            // transportType
            // 
            this.transportType.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportType.FormattingEnabled = true;
            this.transportType.Items.AddRange(new object[] {
            "delivery",
            "general"});
            this.transportType.Location = new System.Drawing.Point(158, 94);
            this.transportType.Name = "transportType";
            this.transportType.Size = new System.Drawing.Size(211, 30);
            this.transportType.TabIndex = 6;
            this.transportType.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(158, 143);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(211, 29);
            this.date.TabIndex = 7;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expense Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount (LKR)";
            // 
            // expense
            // 
            this.expense.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense.Location = new System.Drawing.Point(179, 495);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(197, 29);
            this.expense.TabIndex = 14;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(565, 444);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(197, 29);
            this.Amount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(89, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Add Travel Expenses";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Factory_management.Properties.Resources.bill;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search.Enabled = false;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(448, 94);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(227, 38);
            this.search.TabIndex = 53;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // view_all
            // 
            this.view_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.view_all.FlatAppearance.BorderSize = 0;
            this.view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_all.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.White;
            this.view_all.Location = new System.Drawing.Point(681, 94);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(227, 38);
            this.view_all.TabIndex = 54;
            this.view_all.Text = "View All";
            this.view_all.UseVisualStyleBackColor = false;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(930, 529);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(209, 38);
            this.save.TabIndex = 55;
            this.save.Text = "Save ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.invoice.FlatAppearance.BorderSize = 0;
            this.invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.ForeColor = System.Drawing.Color.White;
            this.invoice.Location = new System.Drawing.Point(449, 529);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(158, 38);
            this.invoice.TabIndex = 56;
            this.invoice.Text = "Invoice";
            this.invoice.UseVisualStyleBackColor = false;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // sheduleGrid
            // 
            this.sheduleGrid.AllowUserToAddRows = false;
            this.sheduleGrid.AllowUserToDeleteRows = false;
            this.sheduleGrid.BackgroundColor = System.Drawing.Color.White;
            this.sheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sheduleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sheduleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sheduleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sheduleGrid.ColumnHeadersHeight = 32;
            this.sheduleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.sheduleGrid.Location = new System.Drawing.Point(12, 190);
            this.sheduleGrid.Name = "sheduleGrid";
            this.sheduleGrid.ReadOnly = true;
            this.sheduleGrid.RowHeadersVisible = false;
            this.sheduleGrid.RowHeadersWidth = 50;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheduleGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.sheduleGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.sheduleGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.sheduleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sheduleGrid.Size = new System.Drawing.Size(1093, 193);
            this.sheduleGrid.TabIndex = 59;
            this.sheduleGrid.SelectionChanged += new System.EventHandler(this.sheduleGrid_SelectionChanged);
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.approveButton.FlatAppearance.BorderSize = 0;
            this.approveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(715, 529);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(209, 38);
            this.approveButton.TabIndex = 60;
            this.approveButton.Text = "View Invoice";
            this.approveButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(10, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 182;
            this.label10.Text = "Add Expenses";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(179, 440);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(197, 29);
            this.id.TabIndex = 184;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 183;
            this.label6.Text = "Transport Id";
            // 
            // travel_expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.sheduleGrid);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.save);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.expense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.transportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "travel_expenses";
            this.Text = "travel_expenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox transportType;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expense;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button view_all;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.DataGridView sheduleGrid;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label6;
    }
}