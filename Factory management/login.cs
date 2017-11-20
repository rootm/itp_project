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
       
      //  public static Form lgc;
        int level = 0;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
     //       lg = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int x = db.connect();
            //textBox1.Text = x.ToString();
            if (validate_user(user_name.Text, password.Text))
            {
                // MessageBox.Show("sdfsdf");
                // ((SysMain)this.MdiParent).logUser(level);
                this.Visible = false;
                Main main = new Main();
                main.Show();
              

               // this.Close();
            }
            else {
                status_label.Visible = true;
            }

        //    this.Hide();


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
                    User.Instance.setSection(login.GetInt16("section"));
                    User.Instance.setCurrentUser(user);
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

      

        private void user_name_GotFocus(object sender, EventArgs e)
        {
            userName_panel.BackColor = Color.FromArgb(200,224,228,208);
            userName_focus.BackColor = Color.FromArgb(255, 1, 194, 110);

            password_focus.BackColor = Color.White;
            password_panel.BackColor = Color.White;

            status_label.Visible = false;

        }

        private void password_Enter(object sender, EventArgs e)
        {
            userName_panel.BackColor = Color.White;
            userName_focus.BackColor = Color.White;

            password_focus.BackColor = Color.FromArgb(255, 1, 194, 110);
            password_panel.BackColor = Color.FromArgb(200, 224, 228, 208);

            status_label.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
