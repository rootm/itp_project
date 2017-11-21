using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Factory_management 

{
    public partial class MaterialRecode : Form
    {
       
        DataTable dt = new DataTable();
        public MaterialRecode()
        {
            InitializeComponent();
        }
        
  
        private void Materials_Load(object sender, EventArgs e)
        {

        }

 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }


        private void clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                Material m = new Material();
                m.updateinfoMaterial(Convert.ToInt32(mid.Text) , Convert.ToInt32(quantity.Text), Convert.ToInt32(orderId.Text));
                MessageBox.Show("data saved");
                viewMaterialsOrdergrid.Rows.RemoveAt(viewMaterialsOrdergrid.SelectedRows[0].Index);
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                
                viewMaterialsOrdergrid.Rows.Clear();
                DataTable dt = m.LoadGridmaterialRecode();
                foreach (DataRow row in dt.Rows)
                {
                    viewMaterialsOrdergrid.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                Material m = new Material();
                viewMaterialsOrdergrid.Rows.Clear();
                DataTable dt = m.LoadGridmaterialRecode();
                foreach (DataRow row in dt.Rows)
                {
                    viewMaterialsOrdergrid.Rows.Add(row.ItemArray);
                }
                
                // viewMaterialsOrdergrid.DataSource = m.LoadGridmaterialRecode();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void viewMaterialsOrdergrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = viewMaterialsOrdergrid.Rows[e.RowIndex];
            orderId.Text = row.Cells[0].Value.ToString();
            mid.Text = row.Cells[1].Value.ToString();
            quantity.Text = row.Cells[2].Value.ToString();
            add.Enabled = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            order.Enabled = true;
        }

        private void materialStockGrid_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void materialStockGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = materialStockGrid.Rows[e.RowIndex];
            materialid.Text = row.Cells[0].Value.ToString();
            orderQuantity.Enabled = true;
        }

        private void order_Click(object sender, EventArgs e)
        {
            string date = orderdate.Value.ToString("yyyy-MM-dd");
            Material m = new Material();
            if (m.InsertInfoMaterialorders(Convert.ToInt32(materialid.Text), Convert.ToInt32(orderQuantity.Text), date) > 0)
            {
                MessageBox.Show("Material Request Successfull");

            }
            else {
                MessageBox.Show("Material Request Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            DataTable dt = m.loadgridMaterialStock();
            materialStockGrid.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                materialStockGrid.Rows.Add(row.ItemArray);
            }
        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
