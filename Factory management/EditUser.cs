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
    public partial class EditUser : Form
    {
        DBAccess db = new DBAccess();
      


        public EditUser()
        {
            InitializeComponent();
        }

        void getAllUser()
        {

            if (db.connect())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from user_details";

                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    userGrid.Rows.Add(reader.GetValue(0), reader.GetValue(1), User.Instance.getSection(reader.GetInt32("section")));


                }
                db.closeconnect();

            }



        }

        //bool updateUser() {

        //}


        private void EditUser_Load(object sender, EventArgs e)
        {
            getAllUser();
        }

        private void userGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count > 0) {
                userName.Text = userGrid.Rows[userGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
            }
        }
    }
}