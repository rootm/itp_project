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
    public partial class edit_scheduled_product_orders_delivery : Form
    {
        deliverySchedule shedule = new deliverySchedule();
        general g = new general();
        public edit_scheduled_product_orders_delivery()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            shedule.UpdateInfo(deliveryId.Text, deliverydate.Text, deliverytime.Text, orderid.Text, vehicleid.Text,driverid.Text);
            MessageBox.Show("data updated");
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            sheduleGrid.Rows.RemoveAt(sheduleGrid.SelectedRows[0].Index);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = deliveryId.Text;
            shedule.DeleteInfo(id);
            MessageBox.Show("data deleted");
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            sheduleGrid.Rows.RemoveAt(sheduleGrid.SelectedRows[0].Index);
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string id = deliveryId.Text;
                DataTable table = shedule.getdetailsShedule(id);
                sheduleGrid.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    sheduleGrid.Rows.Add(row.ItemArray);
                }

                // orderGrid.DataSource = shedule.getdetailsSearch(date);
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
                // string id = deliveryId.Text;
                DataTable table = shedule.getdetailsSheduleView();
                sheduleGrid.Rows.Clear();
                foreach (DataRow row in table.Rows)
                {
                    sheduleGrid.Rows.Add(row.ItemArray);
                }

                // orderGrid.DataSource = shedule.getdetailsSearch(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void sheduleGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (sheduleGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = sheduleGrid.SelectedRows[0];
                deliveryId.Text = row.Cells[0].Value.ToString();
                deliverydate.Text = row.Cells[1].Value.ToString();
                deliverytime.Text = row.Cells[2].Value.ToString();
                orderid.Text = row.Cells[3].Value.ToString();
                vehicleid.Text = row.Cells[4].Value.ToString();
                driverid.Text = row.Cells[5].Value.ToString();


                deliverydate.Enabled = true;
                deliverytime.Enabled = true;
                
                delete.Enabled = true;
                update.Enabled = true;

            }
            else
            {
                orderid.Text = "";
                deliverydate.Enabled = false;
                deliverytime.Enabled = false;
                driverGrid.Rows.Clear();
                vehicleGrid.Rows.Clear();
                delete.Enabled = false;
                update.Enabled = false;
            }
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



            }
            else
            {
                driverid.Text = "";

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

            
        }
    }
}
