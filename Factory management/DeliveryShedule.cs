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
    public partial class DeliveryShedule : Form
    {
        general g = new general();
        DataTable dt = new DataTable();
        deliverySchedule shedule = new deliverySchedule();
        public DeliveryShedule()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeliveryShedule_Load(object sender, EventArgs e)
        {
          
        }

      

   
        private void buttonX4_Click(object sender, EventArgs e)
        {
            
           // shedule.InsertInfo(deliverydate.Text, deliverytime.Text, Convert.ToInt32(textBox1.Text), orderid.Text, vehicleid.Text, driverid.Text,  textBox6.Text);
            MessageBox.Show("Scheduled delivery");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void search_Click(object sender, EventArgs e)
        {
            

            try
            {
                string date = orderdate.Value.ToString("yyyy-MM-dd");
               DataTable table= shedule.getdetailsSearch(date);
                orderGrid.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    orderGrid.Rows.Add(row.ItemArray);
                }
                     //orderGrid.DataSource = shedule.getdetailsSearch(date);
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
                string date = orderdate.Value.ToString("yyyy-MM-dd");
                DataTable table = shedule.getdetails();
                orderGrid.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    orderGrid.Rows.Add(row.ItemArray);
                }
                 
                //orderGrid.DataSource = shedule.getdetails();
             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void schedule_delivery_Click(object sender, EventArgs e)
        {
            
          // shedule.InsertInfo(, deliverytime.Text, Convert.ToInt32(textBox1.Text), orderid.Text, vehicleid.Text, driverid.Text, Convert.ToInt32(textBox5.Text), textBox6.Text);

            if (shedule.InsertInfo(deliverydate.Text, deliverytime.Text, orderid.Text, driverid.Text, vehicleid.Text) > 0) {
                MessageBox.Show("Delivery Scheduled ");
                orderGrid.Rows.RemoveAt(orderGrid.SelectedRows[0].Index);
            } else {
                MessageBox.Show("Delivery Scheduling Failed");
            }
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            driverGrid.DataSource = null;
            vehicleGrid.DataSource = null;
            orderGrid.DataSource = null;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
        }

        private void orderGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (orderGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = orderGrid.SelectedRows[0];
                orderid.Text = row.Cells[0].Value.ToString();

                deliverydate.Enabled = true;
                deliverytime.Enabled = true;
                driverGrid.Rows.Clear();
                vehicleGrid.Rows.Clear();

            }
            else {
                orderid.Text = "";
                deliverydate.Enabled = false;
                deliverytime.Enabled = false;
                driverGrid.Rows.Clear();
                vehicleGrid.Rows.Clear();
            }
           

        }

        private void deliverydate_ValueChanged(object sender, EventArgs e)
        {
            string date = deliverydate.Value.ToString("yyyy-MM-dd");
            DataTable table = g.getdetailsdriver(date);
            driverGrid.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                driverGrid.Rows.Add(row.ItemArray);
            }

            DataTable vehicleTable = g.getdetailsvehicle(date);
            vehicleGrid.Rows.Clear();
            foreach (DataRow row in vehicleTable.Rows)
            {
                vehicleGrid.Rows.Add(row.ItemArray);
            }

            schedule_delivery.Enabled = true;

        }

        private void vehicleGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (vehicleGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = vehicleGrid.SelectedRows[0];
                vehicleid.Text = row.Cells[0].Value.ToString();

                

            }
            else
            {
                vehicleid.Text = "";
                
            }
        }

        private void driverGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (driverGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = driverGrid.SelectedRows[0];
                driverid.Text = row.Cells[0].Value.ToString();
                driverName.Text = row.Cells[1].Value.ToString();


            }
            else
            {
                driverid.Text = "";
                driverName.Text = "";
                schedule_delivery.Enabled = false;

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            driverGrid.DataSource = null;
            vehicleGrid.DataSource = null;
            orderGrid.DataSource = null;
        }
    }
}
