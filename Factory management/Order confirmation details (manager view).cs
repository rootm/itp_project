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
    public partial class order_conf : Form
    {
        public order_conf()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

      

        private void order_conf_Load(object sender, EventArgs e)
        {

        }

        private void agent_search_Click(object sender, EventArgs e)
        {
            //search

            if ((!textBox1.Text.All(char.IsDigit)) || (String.IsNullOrEmpty(textBox1.Text)))
            {
                MessageBox.Show("Invalid Id or Empty Field");
            }
            else
            {
                Order or = new Order();
                DataTable dt = or.searchOrders(textBox1.Text);
                if (dt == null)
                {
                    MessageBox.Show("Not Found");
                }
                else
                {
                    dataGridView1.DataSource = dt;
                    textBox1.Text = string.Empty;

                }
            }

        }

        private void agent_viewAll_Click(object sender, EventArgs e)
        {
            //view all
            Order o1 = new Order();
            DataTable dt = o1.getOrders();
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
            
        }
    }
}
