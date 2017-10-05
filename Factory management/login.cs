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
    public partial class login : Form
    {
        DBAccess db = new DBAccess();
        int level = 0;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int x = db.connect();
            //textBox1.Text = x.ToString();
            if (validate_user(user_name.Text, password.Text)) {
                MessageBox.Show("sdfsdf");
                ((SysMain)this.MdiParent).logUser(level);

            }

            this.Close();


        }


        private bool validate_user(string user, string pass)
        {
            if (db.connect()) {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from user_details where user_name=@user and user_pass=@pass";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Connection = db.connection;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    level= login.GetInt16("user_level");
                    db.closeconnect();
                    return true;
                }
                else
                {
                    db.closeconnect();
                    return false;
                }

            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
