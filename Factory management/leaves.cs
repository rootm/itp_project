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
    public partial class leaves : Form
    {
        DBAccess db = new DBAccess();
        leave l1 = new leave();
        public leaves()
        {
            InitializeComponent();
            loadGrid();
            loadGridEmp();
            
        }

        void clearDetails()
        {
            textBox11.Text = null;
            textBox1.Text = null;
            leave.Text = null;
            textBox2.Text = null;
            dateTimePicker1.Text = null;
            label6.Text = null;
            label8.Text = null;

        }


        void loadGrid()
        {


            DataTable dt = l1.getLeaveDetails();

            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }
            
        }

        void loadGrid(string ename)
        {
            

            DataTable dt = l1.getLeaveDetails(ename);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }
            
        }

        void loadGrid(int eid)
        {
            

            DataTable dt = l1.getLeaveDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        void loadGridEmp()
        {
            DataTable dt = l1.getEmpDetails();
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }
            
        }

        void loadGridEmp(string name)
        {
            DataTable dt = l1.getEmpDetails(name);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }
            
        }

        void loadGridEmp(int eid)
        {
            DataTable dt = l1.getEmpDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void leaves_Load(object sender, EventArgs e)
        {

        }

        private void leaves_viewAll_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            loadGridEmp();
        }


        private void leaves_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton3.Checked)
                {
                    string name = textBox11.Text;

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();

                    loadGrid(name);
                    loadGridEmp(name);

                }

                else if (radioButton4.Checked)
                {
                    int id = Convert.ToInt32(textBox11.Text);

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();

                    loadGrid(id);
                    loadGridEmp(id);
                }

                else
                {
                    MessageBox.Show("Invalid Inputs");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_leaves_Click(object sender, EventArgs e)
        {
            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(leave.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    warning++;
                }

                //empty fields
                if (warning != 3)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                if (warning == 3)
                {

                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(label6.Text);
                        string name = label8.Text;
                        string date = dateTimePicker1.Text;
                        int noDays = Convert.ToInt32(textBox1.Text);
                        string type = leave.Text;
                        string reason = textBox2.Text;



                        l1.insertLeaveDetails(id, name, date, noDays, type, reason);
                        MessageBox.Show("Successful Insertion");

                        dataGridView1.Rows.Clear();
                        loadGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_leaves_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void search_leaves_Click(object sender, EventArgs e)
        {
            searchLeaves sl = new searchLeaves();
            sl.Show();
            this.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void demo_Click(object sender, EventArgs e)
        {
            label6.Text = "2";
            label8.Text = "aaa";
            textBox1.Text = "0" ;
            leave.Text = "Sick";
            textBox2.Text =  " ";
        }
    }
}
