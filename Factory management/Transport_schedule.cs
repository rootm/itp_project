using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Factory_management
{
    public partial class Transport_schedule : Form
    {
        DataTable dt = new DataTable();
        Transport t = new Transport();
        public Transport_schedule()
        {
            InitializeComponent();
        }

        private void edit_transport_schedule_Load(object sender, EventArgs e)
        {

        }

        private void view_delivery_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                time.Enabled = true;
                loadDriver();
                loadVehicle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
        public void loadVehicle()
        {
            dt = t.Searchvehicle(date.Text);
            foreach (DataRow row in dt.Rows)
            {
                vehicleGrid.Rows.Add(row.ItemArray);
            }
        }
        public void loadDriver()
        {
            try
            {
                dt = t.SearchDriver(date.Text);
                foreach (DataRow row in dt.Rows)
                {
                    driverGrid.Rows.Add(row.ItemArray);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void vehicleGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = vehicleGrid.SelectedRows[0];
            vehicleId.Text= row.Cells[0].Value.ToString();
        }

        private void driverGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = driverGrid.SelectedRows[0];
            driverId.Text = row.Cells[0].Value.ToString();
        }

        private void shedule_transport_Click(object sender, EventArgs e)
        {
            try
            {
                t.InsertInfo(vehicleId.Text, date.Text, time.Text, driverId.Text, destination.Text, purpose.Text);
                MessageBox.Show("data added");
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());

        }
    }
}
