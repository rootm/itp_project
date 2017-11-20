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
    public partial class agentOder_details : System.Windows.Forms.Form
    {

        DBAccess db = new DBAccess();
        Special_Orders o = new Special_Orders();
        public agentOder_details()
        {
            InitializeComponent();
            

        }

        void Loadgrid  ()
        {
            {
                
                DataTable dt = o.getdetails10();
                dataGridView2.DataSource = dt;
            }
        }
        void Loadgrid3()
        {
            {
                DataTable dt = o.getdetails2();

                foreach(DataRow row in dt.Rows){

                    dataGridView2.Rows.Add(row.ItemArray);
                }

               // dataGridView2.DataSource = dt;
            }
        }

        void Loadgrid4(int aoid)
        {
                DataTable dt = o.getdetails4(aoid);
            //    dataGridView2.DataSource = dt;

                foreach (DataRow row in dt.Rows)
                {

                    dataGridView2.Rows.Add(row.ItemArray);
                }
            
        }

        void Loadgrid5(string status)
        {
                DataTable dt = o.getdetails5(status);
                foreach (DataRow row in dt.Rows)
                {

                    dataGridView2.Rows.Add(row.ItemArray);
                }
            
        }

        void Loadgrid6 (string status)
        {
                DataTable dt = o.getdetails6(status);
                foreach (DataRow row in dt.Rows)
                {

                    dataGridView2.Rows.Add(row.ItemArray);
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Cancel this order?", "Order Cancellation");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            String name = "Order request has been sent to the stock";
            MessageBox.Show(name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewProduct_stock f = new viewProduct_stock();
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
         //   Form2_ fo = new Form2_(orderid,agentid);
           // fo.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock is under procesing;Order is pending", "under processing Status");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

 
        private void order_viewAll_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Loadgrid3();
        }

        private void order_search_Click(object sender, EventArgs e)
        {
            int aoid = Convert.ToInt32(textBox1.Text);
            dataGridView2.Rows.Clear();
            Loadgrid4(aoid);
        }

        private void pending_orders_Click(object sender, EventArgs e)
        {
            string status = "pending";
            dataGridView2.Rows.Clear();
            Loadgrid5(status);
        }

        private void delivered_orders_Click(object sender, EventArgs e)
        {
            string status = "delivered";
            dataGridView2.Rows.Clear();
            Loadgrid6(status);
        }

        private void approve_order_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to approve this order?", "Order Request", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               // int orderID = Convert.ToInt32(textBox1.Text);
                string oid1 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string agentid1 = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                string total1 = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();

                int oid = Convert.ToInt32(oid1);
                int agentid = Convert.ToInt32(agentid1);
                int total = Convert.ToInt32(total1);

            //    string status = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                string status = "approved";
                o.updateStatus(oid1, status);

                dataGridView2.Rows.Clear();
                Loadgrid3();

                viewAgent_invoice f = new viewAgent_invoice(oid,agentid,total);
                f.Show();
                

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void cancel_order_Click(object sender, EventArgs e)
        {


            try
            {

                DialogResult dialogResult = MessageBox.Show(" Are you sure you want to Cancel this order ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string oid = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                    string status = "decline";
                    o.updateStatus(oid, status);

                    dataGridView2.Rows.Clear();

                    Loadgrid3();

                 //   o.DeleteInfo(oid);

                   // Loadgrid();

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_order_Click(object sender, EventArgs e)
        {
            Request_Order fg = new Request_Order();
            fg.Show();
        }

        private void view_stock_Click(object sender, EventArgs e)
        {
            viewProduct_stock fn = new viewProduct_stock();
            fn.Show();
        }

        private void request_order_Click(object sender, EventArgs e)
        {
            String name = "Order request has been sent to the stock";
            MessageBox.Show(name);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int orderId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            int agentId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }

    }


    


       /* void Loadgrid()
        {
            Request_Order fg = new Request_Order();
            DataTable dt = fg.getdetails();
            DataGridView.DataSource = dt;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Loadgrid();

            clearDetails();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
    }*/

