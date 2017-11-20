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
    public partial class OT : Form
    {

        DBAccess db = new DBAccess();
        
        employee ee = new employee();
       ot  o2 = new ot();
        public OT()
        {
            InitializeComponent();
            loadGrid();
            

        }

       


        void clearDetails()
        {
            textBox11.Text = null;
            employeeID.Text = null;
            name.Text = null;
            date.Text = null;
            otHours.Text = null;
        }


        void loadGrid()
        {
          
            DataTable dt = o2.getOTDetails();
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

        void loadGridEmp()
        {
            DataTable dt = ee.getEmpdetails();
            foreach (DataRow row in dt.Rows)
            {
               empGrid.Rows.Add(row.ItemArray);
            }
        
        }

    
        private void OT_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeID.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            name.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

      
        private void ot_viewAll_Click(object sender, EventArgs e)
        {
          
            otGrid.Rows.Clear();
            empGrid.Rows.Clear();

            loadGridEmp();
        }

        private void ot_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeename.Checked)
                {
                    string name = textBox11.Text;
                    otGrid.Rows.Clear();
                    empGrid.Rows.Clear();

                    loadGridEmp(name);

                }

                else if (empId.Checked)
                {
                    int id = Convert.ToInt32(textBox11.Text);
                    otGrid.Rows.Clear();
                    empGrid.Rows.Clear();

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

        private void save_ot_Click(object sender, EventArgs e)
        {
            try
            {
                int warning = 0;

                if (!String.IsNullOrEmpty(otHours.Text))
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
                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(employeeID.Text);
                        string name = this.name.Text;
                        string date = this.date.Text;
                        int otHrs = Convert.ToInt32(otHours.Text);

                        o2.insertOtDetails(id, name, date, otHrs);
                        MessageBox.Show("Successful Insertion");
                        otGrid.Rows.Clear();
                        loadGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel Insertion");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_ot_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void search_ot_Click(object sender, EventArgs e)
        {
            otSearch os = new otSearch();
            os.Show();
            this.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            name.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeID.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            name.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void demo_Click(object sender, EventArgs e)
        {
             otHours.Text = "2";
        }
    }
}
