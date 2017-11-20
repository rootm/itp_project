using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class productAgent_payment : Form
    {

        DBAccess db = new DBAccess();

        public productAgent_payment()
        {
            InitializeComponent();
        }

        private void productAgent_payment_Load(object sender, EventArgs e)
        {

        }
        bool setTransactionStatus(string id,int status) {

            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();
                if (status == 0)
                {
                    cmd.CommandText = "UPDATE agent_transactions SET status = 'approved' WHERE transactionId = @id;";
                }
                else {
                    cmd.CommandText = "UPDATE agent_transactions SET status = 'declined' WHERE transactionId = @id;";

                }
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }



            db.closeconnect();
            return false;



        }

        


          
        
        void searchAgentPayments(String date) {
            orderPayment_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT p.transactionId,ao.agentId,p.orderId,a.name,p.payDate,p.amount,ao.total FROM agent_transactions p,agent_orders ao,agent_details a WHERE ao.orderId=p.orderId AND a.agentId=ao.agentId AND p.status=0 AND p.payDate=@date AND p.status='pending'";
                //cmd.CommandText = "SELECT p.atid,ao.aid,p.aoid,a.Aname,p.payDate,p.amount,ao.quantity,pr.Puprice FROM atransaction p,aorder ao,agent a,product pr WHERE p.payDate=@date AND ao.aoid=p.aoid AND a.aid=ao.aid AND pr.pid=ao.pid";
                //   cmd.Parameters.AddWithValue("@orderDate", dt);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    orderPayment_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(6), reader.GetValue(4), reader.GetValue(5));
                  

                }






                db.closeconnect();



            }

        }

        void allAgentPayments()
        {
            orderPayment_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT p.transactionId,ao.agentId,p.orderId,a.name,p.payDate,p.amount,ao.total FROM agent_transactions p,agent_orders ao,agent_details a WHERE ao.orderId=p.orderId AND a.agentId=ao.agentId AND p.status='pending'";
                //   cmd.Parameters.AddWithValue("@orderDate", dt);
               // cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    orderPayment_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(6), Int32.Parse(reader.GetValue(5).ToString()) );


                }






                db.closeconnect();



            }

        }

        void getSlip(string orderId) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT bankSlip FROM agent_transactions WHERE orderId=@id";
                  cmd.Parameters.AddWithValue("@id", orderId);
                // cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    paymentSlip_pictureBox.Image = blobToImage((byte[])(reader.GetValue(0)));
                    paymentSlip_panel.Visible = true;
                }






                db.closeconnect();



            }
        }

        Image blobToImage(byte[] byteArrayIn) {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string date = payDate.Value.ToString("yyyy-MM-dd");

            searchAgentPayments(date);
        }

     
        

        private void orderPayment_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void productAgent_payment_MouseClick(object sender, MouseEventArgs e)
        {
            paymentSlip_panel.Hide();
        }

        private void orderPayment_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (orderPayment_grid.SelectedRows.Count > 0)
            {
                orderId_lable.Text = "Order ID                      : " + orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[2].Value.ToString();
                agentName_lable.Text = "Agent Name               : " + orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[3].Value.ToString(); 
                invoiceAmount_lable.Text = "Invoice Amount         : " + orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[6].Value.ToString(); 
                paidAmount_label.Text = "Paid Amount              : " + orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[5].Value.ToString(); 


                paySlip_button.Enabled = true;
                approve_button.Enabled = true;
                decline_button.Enabled = true;
            }
            else {
                orderId_lable.Text = "Order ID                      : " ;
                agentName_lable.Text = "Agent Name               : " ;
                invoiceAmount_lable.Text = "Invoice Amount         : "  ;
                paidAmount_label.Text = "Paid Amount              : " ;


                paySlip_button.Enabled = true;
                approve_button.Enabled = true;
                decline_button.Enabled = false;
            }
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            allAgentPayments();
        }

     

        private void orderPayment_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            allAgentPayments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = payDate.Value.ToString("yyyy-MM-dd");

            searchAgentPayments(date);
        }

     

     

        private void paySlip_button_Click(object sender, EventArgs e)
        {
            getSlip(orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[0].Value.ToString());

        }

     

        private void decline_button_Click(object sender, EventArgs e)
        {
            if (orderPayment_grid.SelectedRows.Count > 0)
            {

                if (setTransactionStatus(orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), 1))
                {
                    orderPayment_grid.Rows.RemoveAt(orderPayment_grid.SelectedRows[0].Index);
                    orderPayment_grid.Refresh();
                    successMsg msg = new successMsg();
                    msg.Show();
                }
                else
                {
                    errorMsg msg = new errorMsg();
                    msg.Show();
                }
            }
        }

    

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (orderPayment_grid.SelectedRows.Count>0)
            {

                if (setTransactionStatus(orderPayment_grid.Rows[orderPayment_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), 0))
                {
                    orderPayment_grid.Rows.RemoveAt(orderPayment_grid.SelectedRows[0].Index);
                    orderPayment_grid.Refresh();
                    successMsg msg = new successMsg();
                    msg.Show();
                }
                else {
                    errorMsg msg = new errorMsg();
                    msg.Show();
                }

            }
            
        }
    }
}
