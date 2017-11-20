namespace Factory_management
{
    partial class otSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ot_search = new System.Windows.Forms.Button();
            this.ename = new System.Windows.Forms.RadioButton();
            this.ot_viewAll = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.empId = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.otGrid = new System.Windows.Forms.DataGridView();
            this.ot_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_ot = new System.Windows.Forms.Button();
            this.delete_ot = new System.Windows.Forms.Button();
            this.update_ot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this.label19.Location = new System.Drawing.Point(128, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(225, 28);
            this.label19.TabIndex = 128;
            this.label19.Text = "Employee Over Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ot_search);
            this.groupBox1.Controls.Add(this.ename);
            this.groupBox1.Controls.Add(this.ot_viewAll);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.empId);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(401, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 139);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // ot_search
            // 
            this.ot_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ot_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ot_search.FlatAppearance.BorderSize = 0;
            this.ot_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ot_search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_search.ForeColor = System.Drawing.Color.White;
            this.ot_search.Location = new System.Drawing.Point(353, 79);
            this.ot_search.Name = "ot_search";
            this.ot_search.Size = new System.Drawing.Size(227, 38);
            this.ot_search.TabIndex = 175;
            this.ot_search.Text = "Search";
            this.ot_search.UseVisualStyleBackColor = false;
            this.ot_search.Click += new System.EventHandler(this.ot_search_Click);
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ename.Location = new System.Drawing.Point(167, 40);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(151, 26);
            this.ename.TabIndex = 129;
            this.ename.TabStop = true;
            this.ename.Text = "Employee Name";
            this.ename.UseVisualStyleBackColor = true;
            // 
            // ot_viewAll
            // 
            this.ot_viewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ot_viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ot_viewAll.FlatAppearance.BorderSize = 0;
            this.ot_viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ot_viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_viewAll.ForeColor = System.Drawing.Color.White;
            this.ot_viewAll.Location = new System.Drawing.Point(588, 79);
            this.ot_viewAll.Name = "ot_viewAll";
            this.ot_viewAll.Size = new System.Drawing.Size(227, 38);
            this.ot_viewAll.TabIndex = 174;
            this.ot_viewAll.Text = "View All";
            this.ot_viewAll.UseVisualStyleBackColor = false;
            this.ot_viewAll.Click += new System.EventHandler(this.ot_viewAll_Click);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(35, 84);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(293, 29);
            this.textBox11.TabIndex = 127;
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(35, 40);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(112, 26);
            this.empId.TabIndex = 128;
            this.empId.TabStop = true;
            this.empId.Text = "Emloyee ID";
            this.empId.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 247);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 151;
            this.label7.Text = "OT ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 150;
            this.label8.Text = "OT ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 149;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 148;
            this.label5.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 147;
            this.label4.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 146;
            this.label3.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 29);
            this.textBox1.TabIndex = 145;
            this.textBox1.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 144;
            this.label2.Text = "OT Hours";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 29);
            this.dateTimePicker1.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "Date";
            // 
            // otGrid
            // 
            this.otGrid.AllowUserToAddRows = false;
            this.otGrid.AllowUserToDeleteRows = false;
            this.otGrid.BackgroundColor = System.Drawing.Color.White;
            this.otGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.otGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.otGrid.ColumnHeadersHeight = 32;
            this.otGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ot_id,
            this.emp_id,
            this.emp_name,
            this.date,
            this.ot_hours});
            this.otGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.otGrid.Location = new System.Drawing.Point(13, 438);
            this.otGrid.Name = "otGrid";
            this.otGrid.ReadOnly = true;
            this.otGrid.RowHeadersVisible = false;
            this.otGrid.RowHeadersWidth = 50;
            this.otGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.otGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.otGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.otGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.otGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.otGrid.Size = new System.Drawing.Size(905, 174);
            this.otGrid.TabIndex = 173;
            this.otGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.otGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.otGrid_CellMouseClick);
            // 
            // ot_id
            // 
            this.ot_id.HeaderText = "OT ID";
            this.ot_id.Name = "ot_id";
            this.ot_id.ReadOnly = true;
            this.ot_id.Width = 150;
            // 
            // emp_id
            // 
            this.emp_id.HeaderText = "Employee ID";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Width = 150;
            // 
            // emp_name
            // 
            this.emp_name.HeaderText = "Employee Name";
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            this.emp_name.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // ot_hours
            // 
            this.ot_hours.HeaderText = "OT Hours";
            this.ot_hours.Name = "ot_hours";
            this.ot_hours.ReadOnly = true;
            this.ot_hours.Width = 150;
            // 
            // empGrid
            // 
            this.empGrid.AllowUserToAddRows = false;
            this.empGrid.AllowUserToDeleteRows = false;
            this.empGrid.BackgroundColor = System.Drawing.Color.White;
            this.empGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empGrid.ColumnHeadersHeight = 32;
            this.empGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eid,
            this.name});
            this.empGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.empGrid.Location = new System.Drawing.Point(569, 184);
            this.empGrid.Name = "empGrid";
            this.empGrid.ReadOnly = true;
            this.empGrid.RowHeadersVisible = false;
            this.empGrid.RowHeadersWidth = 50;
            this.empGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.empGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.empGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.empGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.empGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empGrid.Size = new System.Drawing.Size(349, 236);
            this.empGrid.TabIndex = 172;
            this.empGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.empGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empGrid_CellMouseClick);
            // 
            // eid
            // 
            this.eid.HeaderText = "Employee ID";
            this.eid.Name = "eid";
            this.eid.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Employee Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // clear_ot
            // 
            this.clear_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_ot.FlatAppearance.BorderSize = 0;
            this.clear_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_ot.ForeColor = System.Drawing.Color.White;
            this.clear_ot.Location = new System.Drawing.Point(942, 574);
            this.clear_ot.Name = "clear_ot";
            this.clear_ot.Size = new System.Drawing.Size(275, 38);
            this.clear_ot.TabIndex = 178;
            this.clear_ot.Text = "Clear";
            this.clear_ot.UseVisualStyleBackColor = false;
            this.clear_ot.Click += new System.EventHandler(this.clear_ot_Click);
            // 
            // delete_ot
            // 
            this.delete_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.delete_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_ot.FlatAppearance.BorderSize = 0;
            this.delete_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_ot.ForeColor = System.Drawing.Color.White;
            this.delete_ot.Location = new System.Drawing.Point(942, 530);
            this.delete_ot.Name = "delete_ot";
            this.delete_ot.Size = new System.Drawing.Size(275, 38);
            this.delete_ot.TabIndex = 177;
            this.delete_ot.Text = "Delete OT";
            this.delete_ot.UseVisualStyleBackColor = false;
            this.delete_ot.Click += new System.EventHandler(this.delete_ot_Click);
            // 
            // update_ot
            // 
            this.update_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.update_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_ot.FlatAppearance.BorderSize = 0;
            this.update_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_ot.ForeColor = System.Drawing.Color.White;
            this.update_ot.Location = new System.Drawing.Point(942, 486);
            this.update_ot.Name = "update_ot";
            this.update_ot.Size = new System.Drawing.Size(275, 38);
            this.update_ot.TabIndex = 176;
            this.update_ot.Text = "UpdateOT";
            this.update_ot.UseVisualStyleBackColor = false;
            this.update_ot.Click += new System.EventHandler(this.update_ot_Click);
            // 
            // otSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.clear_ot);
            this.Controls.Add(this.delete_ot);
            this.Controls.Add(this.update_ot);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "otSearch";
            this.Text = "otSearch";
            this.Load += new System.EventHandler(this.otSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ename;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.RadioButton empId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView otGrid;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.Button ot_search;
        private System.Windows.Forms.Button ot_viewAll;
        private System.Windows.Forms.Button clear_ot;
        private System.Windows.Forms.Button delete_ot;
        private System.Windows.Forms.Button update_ot;
        private System.Windows.Forms.DataGridViewTextBoxColumn eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_hours;
    }
}