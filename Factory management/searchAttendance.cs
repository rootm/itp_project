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
    public partial class searchAttendance_form : Form
    {
        public searchAttendance_form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
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

        private void buttonX6_Click(object sender, EventArgs e)
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            attendance a2 = new attendance();
            a2.Show();
            this.Dispose();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_attendance_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
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

        private void delete_attendance_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
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

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {

        }

        private void view_all_Click(object sender, EventArgs e)
        {

        }
    }
}
