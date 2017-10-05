namespace Factory_management
{
    partial class login
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
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userName_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userName_focus = new System.Windows.Forms.Panel();
            this.password_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.password_focus = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_label = new System.Windows.Forms.Label();
            this.userName_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(105, 19);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(235, 33);
            this.user_name.TabIndex = 4;
           
            this.user_name.Enter += new System.EventHandler(this.user_name_GotFocus);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(100, 20);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(235, 33);
            this.password.TabIndex = 5;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(99, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(194)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(89, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login to Your Account";
            // 
            // userName_panel
            // 
            this.userName_panel.Controls.Add(this.pictureBox2);
            this.userName_panel.Controls.Add(this.userName_focus);
            this.userName_panel.Controls.Add(this.user_name);
            this.userName_panel.Location = new System.Drawing.Point(-1, 93);
            this.userName_panel.Name = "userName_panel";
            this.userName_panel.Size = new System.Drawing.Size(423, 76);
            this.userName_panel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Factory_management.Properties.Resources.avatar;
            this.pictureBox2.Location = new System.Drawing.Point(58, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // userName_focus
            // 
            this.userName_focus.Dock = System.Windows.Forms.DockStyle.Left;
            this.userName_focus.Location = new System.Drawing.Point(0, 0);
            this.userName_focus.Name = "userName_focus";
            this.userName_focus.Size = new System.Drawing.Size(7, 76);
            this.userName_focus.TabIndex = 5;
            // 
            // password_panel
            // 
            this.password_panel.Controls.Add(this.pictureBox3);
            this.password_panel.Controls.Add(this.password_focus);
            this.password_panel.Controls.Add(this.password);
            this.password_panel.Location = new System.Drawing.Point(-1, 169);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(423, 76);
            this.password_panel.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Factory_management.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(53, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // password_focus
            // 
            this.password_focus.Dock = System.Windows.Forms.DockStyle.Left;
            this.password_focus.Location = new System.Drawing.Point(0, 0);
            this.password_focus.Name = "password_focus";
            this.password_focus.Size = new System.Drawing.Size(7, 76);
            this.password_focus.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Factory_management.Properties.Resources.cancel;
            this.pictureBox4.Location = new System.Drawing.Point(399, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Factory_management.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.status_label.Location = new System.Drawing.Point(76, 313);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(280, 25);
            this.status_label.TabIndex = 11;
            this.status_label.Text = "User Name or Password Incorrect";
            this.status_label.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 347);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.password_panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userName_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.userName_panel.ResumeLayout(false);
            this.userName_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel userName_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel userName_focus;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel password_focus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label status_label;
    }
}