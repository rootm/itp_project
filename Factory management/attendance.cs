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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agent_save_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {/*
                con.Open();
                String sql = "delete * from emp_details where Name = '"+textBox1.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable d1 = new DataTable();
                sda.Fill(d1);
                dataGridView1.DataSource = d1;
                con.Close();*/
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void clear_attendance_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to clear ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {/*
                con.Open();
                String sql = "delete * from emp_details where Name = '"+textBox1.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable d1 = new DataTable();
                sda.Fill(d1);
                dataGridView1.DataSource = d1;
                con.Close();*/
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void search_attendance_Click(object sender, EventArgs e)
        {
            searchAttendance_form sa = new searchAttendance_form();
            sa.Show();
            this.Dispose();
        }
    }
}
