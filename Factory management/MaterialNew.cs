using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factory_management 
{
    public partial class MaterialNew : Form
    {
        MaterialNewClass mnc = new MaterialNewClass();
        DataTable dt = new DataTable();
        public MaterialNew()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void view_Click_1(object sender, EventArgs e)
        {
            MaterialsDetailsGrid.DataSource = null;
            MaterialsDetailsGrid.Rows.Clear();
            dt = mnc.loadgrid();
            foreach (DataRow row in dt.Rows)
            {
                MaterialsDetailsGrid.Rows.Add(row.ItemArray);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                mnc.insertinfo(mtype.Text, mname.Text);
                MessageBox.Show("data saved");
                MaterialsDetailsGrid.Rows.Clear();
                dt = mnc.loadgrid();
                foreach (DataRow row in dt.Rows)
                {
                    MaterialsDetailsGrid.Rows.Add(row.ItemArray);
                }
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void clear1_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void search_Click(object sender, EventArgs e)
        {

            if ((!materialId.Text.All(char.IsDigit)) || (String.IsNullOrEmpty(materialId.Text)))
            {
                MessageBox.Show("Invalid Id or Empty Field");
            }
            else
            {
                MaterialNewClass mnc = new MaterialNewClass();
                DataTable dt = mnc.loadgridSearch(materialId.Text);
                if (dt == null)
                {
                    MessageBox.Show("Not Found");
                }
                else
                {
                    MaterialsDetailsEditGrid.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        MaterialsDetailsEditGrid.Rows.Add(row.ItemArray);
                    }
                }
            }
        }

        private void MaterialsDetailsEditGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewall_Click(object sender, EventArgs e)
        {

            MaterialsDetailsEditGrid.Rows.Clear();
            dt = mnc.loadgrid();
            foreach (DataRow row in dt.Rows)
            {
                MaterialsDetailsEditGrid.Rows.Add(row.ItemArray);
            }
        }

        private void MaterialsDetailsEditGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = MaterialsDetailsEditGrid.Rows[e.RowIndex];
            materialId.Text = row.Cells[0].Value.ToString();
            type.Text = row.Cells[1].Value.ToString();
            name.Text = row.Cells[2].Value.ToString();
            materialId.Enabled = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                mnc.updateinfo(materialId.Text,type.Text,name.Text);
                MessageBox.Show("update material");
                MaterialsDetailsEditGrid.Rows.Clear();
                dt = mnc.loadgrid();
                foreach (DataRow row in dt.Rows)
                {
                    MaterialsDetailsEditGrid.Rows.Add(row.ItemArray);
                }
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialNewClass mnc = new MaterialNewClass();
                mnc.deleteinfo(materialId.Text);
                MessageBox.Show("delete material");
                MaterialsDetailsEditGrid.Rows.RemoveAt(MaterialsDetailsEditGrid.SelectedRows[0].Index);
                MaterialsDetailsEditGrid.Rows.Clear();
                DataTable dt = mnc.loadgrid();
                foreach (DataRow row in dt.Rows)
                {
                    MaterialsDetailsEditGrid.Rows.Add(row.ItemArray);
                }

                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialId_TextChanged(object sender, EventArgs e)
        {
            search.Enabled = true;
        }
    }
}
