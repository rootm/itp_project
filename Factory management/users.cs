using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class users : Form
    {

        DBAccess db = new DBAccess();

        public users()
        {
            InitializeComponent();
        }

        bool checkUsers(string userName)
        {
            if (db.connect())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from user_details where user_name=@user";
                cmd.Parameters.AddWithValue("@user", userName);

                cmd.Connection = db.connection;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {

                    db.closeconnect();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }


        bool checkPass(string pass)
        {
            if (pass.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void users_Load(object sender, EventArgs e)
        {

        }



        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text == confirmPass.Text)
            {
                passCon.Visible = false;
                userLevel.Enabled = true;
            }
            else
            {
                passCon.Show();
                userLevel.Enabled = false;
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (checkUsers(userName.Text))
            {
                invalidUser_label.Show();
                validUser_lable.Hide();

                pass.Enabled = false;
                confirmPass.Enabled = false;
                userLevel.Enabled = false;

            }
            else
            {
                invalidUser_label.Hide();
                validUser_lable.Show();

                pass.Enabled = true;
                confirmPass.Enabled = true;
                userLevel.Enabled = true;
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (checkPass(pass.Text))
            {
                invalidPassword_lable.Show();
                validPassword_lable.Hide();
                confirmPass.Enabled = false;
                userLevel.Enabled = false;

            }
            else
            {
                invalidPassword_lable.Hide();
                validPassword_lable.Show();
                confirmPass.Enabled = true;
                userLevel.Enabled = true;
            }
        }

        private void userLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userLevel.SelectedIndex > -1)
            {
                addUser_button.Enabled = true;
            }
            else
            {
                addUser_button.Enabled = false;
            }
        }

        bool addUser(string user,string pass,string level)
        {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "Insert into user_details SET VALUES (@user,@pass,@level);";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }



            db.closeconnect();
            return false;



        }


        private void addUser_button_Click(object sender, EventArgs e)
        {


            if (addUser(userName.Text, pass.Text, userLevel.SelectedText))
            {
                MessageBox.Show("User Add Successful");
                pass.Enabled = false;
                confirmPass.Enabled = false;
                userLevel.Enabled = false;
                addUser_button.Enabled = false;
            }
            else {
                MessageBox.Show("User Add failed");
                
            }
        }

    }
}
