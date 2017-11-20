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
    public partial class viewAgent_invoice : System.Windows.Forms.Form
    {
        int orderid;
        int agentid;
        int total1;
        public viewAgent_invoice(int orderId,int agentId,int total)
        {
            InitializeComponent();
            orderid = orderId;
            agentid = agentId;
            total1 = total;

        }


        void Loadgrid(int orderID)
        {
            {
                invoice i = new invoice();
                DataTable dt = i.getProductDetails(orderID);

                foreach (DataRow row in dt.Rows)
                {

                    dataGridView1.Rows.Add(row.ItemArray);
                                       
                }

               
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice details has been sent to the Agent", "Sending Invoice");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form2__Load(object sender, EventArgs e)
        {
            invoice newInvoice = new invoice();

          //  Loadgrid(orderid);

            order_id.Text = Convert.ToString(orderid);
            agent_id.Text = Convert.ToString(agentid);
            invoice_num.Text = Convert.ToString(orderid) + Convert.ToString(agentid);

            DataTable dt = newInvoice.getAgentDetails(agentid);
            foreach (DataRow row in dt.Rows)
            {
                agentName.Text = row.ItemArray.GetValue(0).ToString();
                agentAddress.Text = row.ItemArray.GetValue(1).ToString();
            }
            grand_total.Text = Convert.ToString(total1);

            Loadgrid(orderid);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)

            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);
               // textBox2.Text = B.ToString();

            }
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void send_invoice_Click(object sender, EventArgs e)
        {
            try
            {
                invoice i1 = new invoice();
                int invoiceno = Convert.ToInt32(invoice_num.Text);
                int orderId = Convert.ToInt32(order_id.Text);
                int agentid = Convert.ToInt32(agent_id.Text);
                string date = dateTimePicker1.Text;
                int total = Convert.ToInt32(grand_total.Text);

                i1.InsertInfo(invoiceno, orderId, agentid, date, total);
                MessageBox.Show("Invoice details has been sent to the Agent", "Sending Invoice");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
