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
    public partial class otSearch : Form
    {

        DBAccess db = new DBAccess();
        ot o2 = new ot();
        employee ee = new employee();

        public otSearch()
        {
            InitializeComponent();
            loadGridEmp();
           

        }


        void loadGridEmp()
        {
           
            DataTable dt = ee.getEmpdetails();
            foreach (DataRow row in dt.Rows)
            {

                empGrid.Rows.Add(row.ItemArray);
            }

           
        }

        void clearDetails()
        {
            textBox11.Text = null;
            label5.Text = null;
            label6.Text = null;
            dateTimePicker1.Text = null;
            textBox1.Text = null;
            label7.Text = null;
        }


        void loadGrid()
        {
            DataTable dt = o2.getOTDetails();
            foreach (DataRow row in dt.Rows)
            {

                otGrid.Rows.Add(row.ItemArray);
            }

        }

        void loadGrid(int eid)
        {
            DataTable dt = o2.getOTDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                otGrid.Rows.Add(row.ItemArray);
            }
        }

        void loadGrid(string name)
        {
            DataTable dt = o2.getOTDetails(name);
            foreach (DataRow row in dt.Rows)
            {

                otGrid.Rows.Add(row.ItemArray);
            }
        }


        void loadGridEmp(string name)
        {
            DataTable dt = o2.getEmpDetails(name);
            foreach (DataRow row in dt.Rows)
            {

                empGrid.Rows.Add(row.ItemArray);
            }
        }

        void loadGridEmp(int eid)
        {
            DataTable dt = o2.getEmpDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                empGrid.Rows.Add(row.ItemArray);
            }
        }

        void loadGridOt(int eid)
        {
            DataTable dt = o2.getOTDetails(eid);
            foreach (DataRow row in dt.Rows)
            {

                otGrid.Rows.Add(row.ItemArray);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



     
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label5.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = otGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label5.Text = otGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label6.Text = otGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = otGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = otGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            int eid = Convert.ToInt32(label5.Text);

           loadGridOt(eid);
           // loadGrid(eid);

        }

        private void otSearch_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = otGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label5.Text = otGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label6.Text = otGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = otGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = otGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            int eid = Convert.ToInt32(label5.Text);

           
            // loadGrid(eid);
        }

        private void ot_viewAll_Click(object sender, EventArgs e)
        { 
            empGrid.Rows.Clear();
            otGrid.Rows.Clear();
            loadGrid();
            loadGridEmp();
        }

        private void ot_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (ename.Checked)
                {
                    string name = textBox11.Text;

                    otGrid.Rows.Clear();
                    empGrid.Rows.Clear();

                    loadGrid(name);
                    loadGridEmp(name);

                }

                else if (empId.Checked)
                {
                    int id = Convert.ToInt32(textBox11.Text);

                    otGrid.Rows.Clear();
                    empGrid.Rows.Clear();

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
                MessageBox.Show("ERROR");
            }
        }

        private void update_ot_Click(object sender, EventArgs e)
        {
            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }


                //empty fields
                if (warning != 1)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                if (warning == 1)
                {
                    DBAccess db = new DBAccess();
                    ot oo = new ot();

                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        otGrid.Rows.Clear();
                        empGrid.Rows.Clear();

                        int oid = Convert.ToInt32(label7.Text);
                        int id = Convert.ToInt32(label5.Text);
                        string name = label6.Text;
                        string date = dateTimePicker1.Text;
                        int otHrs = Convert.ToInt32(textBox1.Text);

                        oo.updateOtDetails(oid, id, name, date, otHrs);
                        MessageBox.Show("Successfully updated");
                        loadGrid();
                        clearDetails();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void delete_ot_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    otGrid.Rows.Clear();
                    empGrid.Rows.Clear();

                    int oid = Convert.ToInt32(label7.Text);
                    int id = Convert.ToInt32(label5.Text);
                    string name = label6.Text;
                    string date = dateTimePicker1.Text;
                    int otHrs = Convert.ToInt32(textBox1.Text);

                    o2.deleteOtDetails(oid, id, name, date, otHrs);
                    MessageBox.Show("Successfully deleted");
                    loadGrid();
                    clearDetails();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void clear_ot_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void otGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = otGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label5.Text = otGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label6.Text = otGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = otGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = otGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            int eid = Convert.ToInt32(label5.Text);
        }

        private void empGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label5.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label6.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
