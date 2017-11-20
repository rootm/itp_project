using Factory_management;
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
    public partial class searchLeaves : Form
    {
        leave l1 = new leave();
        
        public searchLeaves()
        {
            InitializeComponent();
            loadGrid();
            
        }

        void loadGrid(string ename)
        {
            leave l1 = new leave();

            DataTable dt = l1.getLeaveDetails(ename);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

         
        }

        void loadGrid(int eid)
        {
            leave l1 = new leave();

            DataTable dt = l1.getLeaveDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

            
        }
        void loadGrid()
        {
            leave l1 = new leave();

            DataTable dt = l1.getLeaveDetails();
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

   
        }

        void loadGridEmp()
        {
            leave l1 = new leave();

            DataTable dt = l1.getEmpDetails();
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }

        
        }

        void loadGridEmp(string name)
        {
            leave l1 = new leave();

            DataTable dt = l1.getEmpDetails(name);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }
           
        }

        void loadGridEmp(int eid)
        {
            leave l1 = new leave();

            DataTable dt = l1.getEmpDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView2.Rows.Add(row.ItemArray);
            }
          
        }


        void clearDetails()
        {
            textBox11.Text = null;
            textBox1.Text = null;
            comboBox2.Text = null;
            textBox2.Text = null;
            dateTimePicker1.Text = null;
            label11.Text = null;
            label6.Text = null;
            label8.Text = null;


        }
       

       

       
        private void label10_Click(object sender, EventArgs e)
        {

        }

      
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();



        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void leaves_viewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            loadGrid();
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

        private void update_leaves_Click(object sender, EventArgs e)
        {
            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(comboBox2.Text))
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

                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int lid = Convert.ToInt32(label11.Text);
                        int id = Convert.ToInt32(label6.Text);
                        string name = label8.Text;
                        string date = dateTimePicker1.Text;
                        int noDays = Convert.ToInt32(textBox1.Text);
                        string type = comboBox2.Text;
                        string reason = textBox2.Text;

                        l1.updateLeaveDetails(lid, id, name, date, noDays, type, reason);
                        MessageBox.Show("Successfully updated");
                        dataGridView1.Rows.Clear();
                        loadGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel ");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void delete_leaves_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int lid = Convert.ToInt32(label11.Text);
                    int id = Convert.ToInt32(label6.Text);
                    string name = label8.Text;
                    string date = dateTimePicker1.Text;
                    int noDays = Convert.ToInt32(textBox1.Text);
                    string type = comboBox2.Text;
                    string reason = textBox2.Text;

                    l1.deleteLeaveDetails(lid, id, name, date, noDays, type, reason);
                    MessageBox.Show("Successfully deleted");
                    loadGrid();
                    clearDetails();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel Deletion");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label6.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            label8.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
