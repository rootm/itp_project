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
    public partial class distributeAgentOrders : Form
    {
        distributeOrders sod = new distributeOrders();
        DataTable dt = new DataTable();
        public distributeAgentOrders()
        {
            InitializeComponent();
        }
        private void OrderD_Load(object sender, EventArgs e)
        {

        }
        private void distribute_Click(object sender, EventArgs e)
        {
            try
            {
                if (agentOrder.Checked == true)
                {
                    sod.UpdateInfoAgentOrders(Convert.ToInt32(orderid.Text), Convert.ToInt32(pid.Text), Convert.ToInt32(quantity.Text));
                    this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }
                else if (specialOrder.Checked == true)
                {
                    sod.UpdateInfoSpecialOrders(Convert.ToInt32(orderid.Text), Convert.ToInt32(pid.Text), Convert.ToInt32(quantity.Text));
                    this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            agentOrdergrid.Rows.Clear();

        }

        private void view_Click(object sender, EventArgs e)
        {
            if (agentOrder.Checked == true)
            {
                distributeOrders sod = new distributeOrders();
                DataTable dt = sod.LoadGridAgentOrders();
                agentOrdergrid.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    agentOrdergrid.Rows.Add(row.ItemArray);
                }
                
            }
            else if (specialOrder.Checked == true)
            {
                try {
                    distributeOrders sod = new distributeOrders();
                    DataTable dt = sod.LoadGridSpecialOrders();
                    agentOrdergrid.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        agentOrdergrid.Rows.Add(row.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
                
               
            }
            
        }

        private void agentOrdergrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void agentOrdergrid_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = agentOrdergrid.Rows[e.RowIndex];
            orderid.Text = row.Cells[0].Value.ToString();
            pid.Text = row.Cells[1].Value.ToString();
            quantity.Text = row.Cells[2].Value.ToString();
        }
    }
}
