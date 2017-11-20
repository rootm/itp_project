namespace Factory_management
{
    partial class OT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ot_search = new System.Windows.Forms.Button();
            this.empId = new System.Windows.Forms.RadioButton();
            this.ot_viewAll = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.employeename = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.otHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.otGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_report = new System.Windows.Forms.Button();
            this.search_ot = new System.Windows.Forms.Button();
            this.clear_ot = new System.Windows.Forms.Button();
            this.save_ot = new System.Windows.Forms.Button();
            this.demo = new System.Windows.Forms.Button();
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
            this.label19.Location = new System.Drawing.Point(127, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(225, 28);
            this.label19.TabIndex = 126;
            this.label19.Text = "Employee Over Time";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ot_search);
            this.groupBox1.Controls.Add(this.empId);
            this.groupBox1.Controls.Add(this.ot_viewAll);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.employeename);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(380, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 128);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ot_search
            // 
            this.ot_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ot_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ot_search.FlatAppearance.BorderSize = 0;
            this.ot_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ot_search.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_search.ForeColor = System.Drawing.Color.White;
            this.ot_search.Location = new System.Drawing.Point(364, 70);
            this.ot_search.Name = "ot_search";
            this.ot_search.Size = new System.Drawing.Size(221, 38);
            this.ot_search.TabIndex = 161;
            this.ot_search.Text = "Search";
            this.ot_search.UseVisualStyleBackColor = false;
            this.ot_search.Click += new System.EventHandler(this.ot_search_Click);
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(187, 40);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(122, 26);
            this.empId.TabIndex = 131;
            this.empId.TabStop = true;
            this.empId.Text = "Employee ID";
            this.empId.UseVisualStyleBackColor = true;
            // 
            // ot_viewAll
            // 
            this.ot_viewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ot_viewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ot_viewAll.FlatAppearance.BorderSize = 0;
            this.ot_viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ot_viewAll.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_viewAll.ForeColor = System.Drawing.Color.White;
            this.ot_viewAll.Location = new System.Drawing.Point(591, 70);
            this.ot_viewAll.Name = "ot_viewAll";
            this.ot_viewAll.Size = new System.Drawing.Size(221, 38);
            this.ot_viewAll.TabIndex = 160;
            this.ot_viewAll.Text = "View All";
            this.ot_viewAll.UseVisualStyleBackColor = false;
            this.ot_viewAll.Click += new System.EventHandler(this.ot_viewAll_Click);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(21, 79);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(288, 29);
            this.textBox11.TabIndex = 127;
            // 
            // employeename
            // 
            this.employeename.AutoSize = true;
            this.employeename.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeename.Location = new System.Drawing.Point(21, 40);
            this.employeename.Name = "employeename";
            this.employeename.Size = new System.Drawing.Size(151, 26);
            this.employeename.TabIndex = 128;
            this.employeename.TabStop = true;
            this.employeename.Text = "Employee Name";
            this.employeename.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.employeeID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.otHours);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 197);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(170, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 22);
            this.name.TabIndex = 149;
            this.name.Text = "Name";
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID.Location = new System.Drawing.Point(170, 16);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(104, 22);
            this.employeeID.TabIndex = 148;
            this.employeeID.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 147;
            this.label4.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 146;
            this.label3.Text = "Name";
            // 
            // otHours
            // 
            this.otHours.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otHours.Location = new System.Drawing.Point(174, 153);
            this.otHours.Name = "otHours";
            this.otHours.Size = new System.Drawing.Size(278, 29);
            this.otHours.TabIndex = 145;
            this.otHours.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 144;
            this.label2.Text = "OT Hours";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM";
            this.date.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(174, 97);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(278, 29);
            this.date.TabIndex = 143;
            this.date.Value = new System.DateTime(2017, 11, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "Month";
            // 
            // otGrid
            // 
            this.otGrid.AllowUserToAddRows = false;
            this.otGrid.AllowUserToDeleteRows = false;
            this.otGrid.BackgroundColor = System.Drawing.Color.White;
            this.otGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.otGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.otGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.otGrid.ColumnHeadersHeight = 32;
            this.otGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.otGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.otGrid.Location = new System.Drawing.Point(31, 379);
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
            this.otGrid.Size = new System.Drawing.Size(924, 214);
            this.otGrid.TabIndex = 171;
            this.otGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OT ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Employee Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "OT Hours";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // empGrid
            // 
            this.empGrid.AllowUserToAddRows = false;
            this.empGrid.AllowUserToDeleteRows = false;
            this.empGrid.BackgroundColor = System.Drawing.Color.White;
            this.empGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.empGrid.ColumnHeadersHeight = 32;
            this.empGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eid,
            this.ename});
            this.empGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.empGrid.Location = new System.Drawing.Point(615, 176);
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
            this.empGrid.Size = new System.Drawing.Size(340, 188);
            this.empGrid.TabIndex = 170;
            this.empGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.empGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empGrid_CellMouseClick);
            // 
            // eid
            // 
            this.eid.HeaderText = "Employee ID";
            this.eid.Name = "eid";
            this.eid.ReadOnly = true;
            // 
            // ename
            // 
            this.ename.HeaderText = "Employee Name";
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            this.ename.Width = 150;
            // 
            // ot_report
            // 
            this.ot_report.BackColor = System.Drawing.Color.Teal;
            this.ot_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ot_report.FlatAppearance.BorderSize = 0;
            this.ot_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ot_report.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_report.ForeColor = System.Drawing.Color.White;
            this.ot_report.Location = new System.Drawing.Point(971, 555);
            this.ot_report.Name = "ot_report";
            this.ot_report.Size = new System.Drawing.Size(227, 38);
            this.ot_report.TabIndex = 175;
            this.ot_report.Text = "OT Report";
            this.ot_report.UseVisualStyleBackColor = false;
            // 
            // search_ot
            // 
            this.search_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.search_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_ot.FlatAppearance.BorderSize = 0;
            this.search_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_ot.ForeColor = System.Drawing.Color.White;
            this.search_ot.Location = new System.Drawing.Point(971, 447);
            this.search_ot.Name = "search_ot";
            this.search_ot.Size = new System.Drawing.Size(227, 38);
            this.search_ot.TabIndex = 174;
            this.search_ot.Text = "Search OT";
            this.search_ot.UseVisualStyleBackColor = false;
            this.search_ot.Click += new System.EventHandler(this.search_ot_Click);
            // 
            // clear_ot
            // 
            this.clear_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clear_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_ot.FlatAppearance.BorderSize = 0;
            this.clear_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_ot.ForeColor = System.Drawing.Color.White;
            this.clear_ot.Location = new System.Drawing.Point(971, 393);
            this.clear_ot.Name = "clear_ot";
            this.clear_ot.Size = new System.Drawing.Size(227, 38);
            this.clear_ot.TabIndex = 173;
            this.clear_ot.Text = "Clear";
            this.clear_ot.UseVisualStyleBackColor = false;
            this.clear_ot.Click += new System.EventHandler(this.clear_ot_Click);
            // 
            // save_ot
            // 
            this.save_ot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.save_ot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_ot.FlatAppearance.BorderSize = 0;
            this.save_ot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_ot.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_ot.ForeColor = System.Drawing.Color.White;
            this.save_ot.Location = new System.Drawing.Point(971, 339);
            this.save_ot.Name = "save_ot";
            this.save_ot.Size = new System.Drawing.Size(227, 38);
            this.save_ot.TabIndex = 172;
            this.save_ot.Text = "Save OT";
            this.save_ot.UseVisualStyleBackColor = false;
            this.save_ot.Click += new System.EventHandler(this.save_ot_Click);
            // 
            // demo
            // 
            this.demo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.demo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demo.FlatAppearance.BorderSize = 0;
            this.demo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo.ForeColor = System.Drawing.Color.White;
            this.demo.Location = new System.Drawing.Point(971, 501);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(227, 38);
            this.demo.TabIndex = 176;
            this.demo.Text = "Demo";
            this.demo.UseVisualStyleBackColor = false;
            this.demo.Click += new System.EventHandler(this.demo_Click);
            // 
            // OT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 605);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.ot_report);
            this.Controls.Add(this.search_ot);
            this.Controls.Add(this.clear_ot);
            this.Controls.Add(this.save_ot);
            this.Controls.Add(this.otGrid);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OT";
            this.Text = "OT";
            this.Load += new System.EventHandler(this.OT_Load);
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

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.RadioButton employeename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox otHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton empId;
        private System.Windows.Forms.Button ot_search;
        private System.Windows.Forms.Button ot_viewAll;
        private System.Windows.Forms.DataGridView otGrid;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.Button ot_report;
        private System.Windows.Forms.Button search_ot;
        private System.Windows.Forms.Button clear_ot;
        private System.Windows.Forms.Button save_ot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn eid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.Button demo;
    }
}