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
    public partial class ProductNew : Form
    {
        product pn = new product();
        DataTable dt = new DataTable();

        public ProductNew()
        {
            InitializeComponent();
        }
        private void view_Click(object sender, EventArgs e)
        {
            product pn = new product();
            productGrid.Rows.Clear();
            DataTable dt = pn.LoadGridNewproduct();
            foreach (DataRow row in dt.Rows)
            {
                productGrid.Rows.Add(row.ItemArray);
            }
            //productGrid.DataSource = pn.LoadGridNewproduct();
        }

        private void add_Click(object sender, EventArgs e)
        {
            product pn = new product();
            pn.InsertInfo(ptype.Text, pname.Text, Convert.ToInt32(pages.Text), Convert.ToInt32(price.Text));
            MessageBox.Show("data added");
            productGrid.Rows.Clear();
            DataTable dt = pn.LoadGridNewproduct();
            foreach (DataRow row in dt.Rows)
            {
                productGrid.Rows.Add(row.ItemArray);
            }
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            productGrid.DataSource = null;
        }

        private void productGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            add.Enabled = false;
            update.Enabled = true;
            del.Enabled = true;
            DataGridViewRow row = productGrid.Rows[e.RowIndex];
            pid.Text = row.Cells[0].Value.ToString();
            ptype.Text = row.Cells[1].Value.ToString();
            pname.Text = row.Cells[2].Value.ToString();
            pages.Text = row.Cells[3].Value.ToString();
            price.Text = row.Cells[4].Value.ToString();
            pid.ReadOnly = true;
        }

        private void del_Click(object sender, EventArgs e)
        {
            product pn = new product();
            if (pn.getQuantity(Convert.ToInt32(pid.Text))==0){
                pn.DeleteInfo(Convert.ToInt32(pid.Text));
                MessageBox.Show("data deleted");
                productGrid.Rows.Clear();
                DataTable dt = pn.LoadGridNewproduct();
                foreach (DataRow row in dt.Rows)
                {
                    productGrid.Rows.Add(row.ItemArray);
                }
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            }
            else
            {
                MessageBox.Show("stock is not empty");
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            product pn = new product();
            DataTable dt = pn.LoadGridNewproductSearch(Convert.ToInt32(pid.Text));
            productGrid.Rows.Clear();
            
            foreach (DataRow row in dt.Rows)
            {
                productGrid.Rows.Add(row.ItemArray);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            product pn = new product();
            pn.UpdateInfo(Convert.ToInt32(pid.Text), ptype.Text,pname.Text,Convert.ToInt32(pages.Text),Convert.ToInt32(price.Text));
            MessageBox.Show("update product");
            productGrid.Rows.Clear();
            
            DataTable dt = pn.LoadGridNewproduct();
            productGrid.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                productGrid.Rows.Add(row.ItemArray);
            }
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }
    }
}
