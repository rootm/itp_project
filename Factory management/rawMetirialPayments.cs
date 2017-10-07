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
    public partial class rawMetirialPayments : Form
    {

        DBAccess db = new DBAccess();

        public rawMetirialPayments()
        {
            InitializeComponent();
        }

        private void rawMetirialPayments_Load(object sender, EventArgs e)
        {

        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            //if (db.connect())
            //{

            //    MySqlCommand cmd = new MySqlCommand();
            //    cmd.CommandText = "Select * from user_details where user_name=@user and user_pass=@pass";
            //    cmd.Parameters.AddWithValue("@user", user);
            //    cmd.Parameters.AddWithValue("@pass", pass);
            //    cmd.Connection = db.connection;
            //    MySqlDataReader login = cmd.ExecuteReader();
            //    if (login.Read())
            //    {
            //        level = login.GetInt16("user_level");
            //        db.closeconnect();
                   
            //    }
            //    else
            //    {
            //        db.closeconnect();
                   
             // }

            //}
        }
    }
}
