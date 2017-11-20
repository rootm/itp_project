namespace Factory_management
{
    partial class users
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userSection = new System.Windows.Forms.ComboBox();
            this.invalidUser_label = new System.Windows.Forms.Label();
            this.validUser_lable = new System.Windows.Forms.Label();
            this.invalidPassword_lable = new System.Windows.Forms.Label();
            this.validPassword_lable = new System.Windows.Forms.Label();
            this.passCon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addUser_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(177, 98);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(194, 29);
            this.userName.TabIndex = 4;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // pass
            // 
            this.pass.Enabled = false;
            this.pass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(177, 150);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(194, 29);
            this.pass.TabIndex = 5;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // confirmPass
            // 
            this.confirmPass.Enabled = false;
            this.confirmPass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(177, 201);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(194, 29);
            this.confirmPass.TabIndex = 6;
            this.confirmPass.TextChanged += new System.EventHandler(this.confirmPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add User Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // userSection
            // 
            this.userSection.Enabled = false;
            this.userSection.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSection.FormattingEnabled = true;
            this.userSection.Items.AddRange(new object[] {
            "Admin",
            "Users Management",
            "Financial Management",
            "Employee Management",
            "Supplier Management",
            "Agent Management",
            "Order Management",
            "Vehicle Management",
            "Maintainance Mangement",
            "Inventory Management",
            ""});
            this.userSection.Location = new System.Drawing.Point(177, 249);
            this.userSection.Name = "userSection";
            this.userSection.Size = new System.Drawing.Size(194, 30);
            this.userSection.TabIndex = 12;
            this.userSection.SelectedIndexChanged += new System.EventHandler(this.userLevel_SelectedIndexChanged);
            // 
            // invalidUser_label
            // 
            this.invalidUser_label.AutoSize = true;
            this.invalidUser_label.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidUser_label.ForeColor = System.Drawing.Color.Red;
            this.invalidUser_label.Location = new System.Drawing.Point(259, 78);
            this.invalidUser_label.Name = "invalidUser_label";
            this.invalidUser_label.Size = new System.Drawing.Size(112, 17);
            this.invalidUser_label.TabIndex = 13;
            this.invalidUser_label.Text = "User Name Exists";
            this.invalidUser_label.Visible = false;
            // 
            // validUser_lable
            // 
            this.validUser_lable.AutoSize = true;
            this.validUser_lable.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validUser_lable.ForeColor = System.Drawing.Color.ForestGreen;
            this.validUser_lable.Location = new System.Drawing.Point(259, 78);
            this.validUser_lable.Name = "validUser_lable";
            this.validUser_lable.Size = new System.Drawing.Size(108, 17);
            this.validUser_lable.TabIndex = 14;
            this.validUser_lable.Text = "Valid User Name";
            this.validUser_lable.Visible = false;
            // 
            // invalidPassword_lable
            // 
            this.invalidPassword_lable.AutoSize = true;
            this.invalidPassword_lable.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPassword_lable.ForeColor = System.Drawing.Color.Red;
            this.invalidPassword_lable.Location = new System.Drawing.Point(250, 134);
            this.invalidPassword_lable.Name = "invalidPassword_lable";
            this.invalidPassword_lable.Size = new System.Drawing.Size(121, 17);
            this.invalidPassword_lable.TabIndex = 15;
            this.invalidPassword_lable.Text = "spaces not allowed";
            this.invalidPassword_lable.Visible = false;
            // 
            // validPassword_lable
            // 
            this.validPassword_lable.AutoSize = true;
            this.validPassword_lable.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPassword_lable.ForeColor = System.Drawing.Color.ForestGreen;
            this.validPassword_lable.Location = new System.Drawing.Point(272, 134);
            this.validPassword_lable.Name = "validPassword_lable";
            this.validPassword_lable.Size = new System.Drawing.Size(99, 17);
            this.validPassword_lable.TabIndex = 16;
            this.validPassword_lable.Text = "Valid password";
            this.validPassword_lable.Visible = false;
            // 
            // passCon
            // 
            this.passCon.AutoSize = true;
            this.passCon.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCon.ForeColor = System.Drawing.Color.Red;
            this.passCon.Location = new System.Drawing.Point(244, 182);
            this.passCon.Name = "passCon";
            this.passCon.Size = new System.Drawing.Size(127, 17);
            this.passCon.TabIndex = 17;
            this.passCon.Text = "Password Mismatch";
            this.passCon.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Section";
            // 
            // addUser_button
            // 
            this.addUser_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.addUser_button.FlatAppearance.BorderSize = 0;
            this.addUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_button.ForeColor = System.Drawing.Color.White;
            this.addUser_button.Location = new System.Drawing.Point(177, 304);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(194, 38);
            this.addUser_button.TabIndex = 48;
            this.addUser_button.Text = "Add User";
            this.addUser_button.UseVisualStyleBackColor = false;
            this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 379);
            this.Controls.Add(this.addUser_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passCon);
            this.Controls.Add(this.invalidUser_label);
            this.Controls.Add(this.userSection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validUser_lable);
            this.Controls.Add(this.validPassword_lable);
            this.Controls.Add(this.invalidPassword_lable);
            this.Name = "users";
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox userSection;
        private System.Windows.Forms.Label invalidUser_label;
        private System.Windows.Forms.Label validUser_lable;
        private System.Windows.Forms.Label invalidPassword_lable;
        private System.Windows.Forms.Label validPassword_lable;
        private System.Windows.Forms.Label passCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUser_button;
    }
}