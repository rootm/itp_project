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
    public partial class departments : Form
    {

        department d1 = new department();
        public departments()
        {
            InitializeComponent();
        }

     
        void loadGridAdd()
        {
            DataTable dt = d1.getDepartment();
            foreach (DataRow row in dt.Rows)
                {
                    deptAdd.Rows.Add(row.ItemArray);
                }
         }

        void loadGridEdit()
        {
            DataTable dt = d1.getDepartment();
            foreach (DataRow row in dt.Rows)
            {
                deptEdit.Rows.Add(row.ItemArray);
            }

        }

        void clearDetails()
        {
            name_.Text = null;

        }

        private void save_Click(object sender, EventArgs e)
        {
            string deptName = name_.Text;
            try
            {
                d1.insertDepartment(deptName);

                MessageBox.Show("Successful Insertion");
                deptAdd.Rows.Clear();
                loadGridAdd();
                clearDetails();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            panel1.Show();
            deptEdit.Rows.Clear();
            loadGridEdit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void departments_Load(object sender, EventArgs e)
        {
            deptAdd.Rows.Clear();
            loadGridAdd();
        }

        private void deptEdit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            did.Text = deptEdit.Rows[e.RowIndex].Cells[0].Value.ToString();
            deptName.Text = deptEdit.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string department = deptName.Text;
            int deptId = Convert.ToInt32(did.Text);
            try
            {
                d1.updateDepartment(department,deptId);

                MessageBox.Show("Successfully Updated");
                deptEdit.Rows.Clear();
                loadGridEdit();
                clearDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            int deptId = Convert.ToInt32(did.Text);
            try
            {
                d1.deleteDepartment(deptId);

                MessageBox.Show("Successfully Deleted");
                deptEdit.Rows.Clear();
                loadGridEdit();
                clearDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void did_Click(object sender, EventArgs e)
        {

        }
    }
}
