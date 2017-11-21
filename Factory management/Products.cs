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
    public partial class Products : Form
    {
        productsHandle ph = new productsHandle();
        public Products()
        {
            InitializeComponent();
        }
        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            product pn = new product();
            DataTable dt = ph.loadgrid();

            productStockGrid.Rows.Clear();
            
            foreach (DataRow row in dt.Rows)
            {
                productStockGrid.Rows.Add(row.ItemArray);
            }
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());

        }

        private void add_Click(object sender, EventArgs e)
        {
            ph.updateinfo(Convert.ToInt32(pid.Text), Convert.ToInt32(quantity.Text));
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            ph.updateinfoMaterial(Convert.ToInt32(mid.Text), Convert.ToInt32(quantity.Text));
        }

        private void viewDistribution_Click(object sender, EventArgs e)
        {

        }

        private void productStockGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = productStockGrid.Rows[e.RowIndex];
            pid.Text = row.Cells[0].Value.ToString();
            

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void viewMaterialDistributionGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = viewMaterialDistributionGrid.Rows[e.RowIndex];
            mid.Text = row.Cells[0].Value.ToString();
        }

        private void pid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
