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
    public partial class EditTransport_shedule : Form
    {
        DataTable dt = new DataTable();
        Transport t = new Transport();
        public EditTransport_shedule()
        {
            InitializeComponent();
        }
        public string TransportID;


        private void transport_shedule_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            dt = t.searchDate(transportdate.Text);
            transpordGrid.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                transpordGrid.Rows.Add(row.ItemArray);
            }

        }

        private void view_Click(object sender, EventArgs e)
        {

            dt = t.view();
            transpordGrid.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                transpordGrid.Rows.Add(row.ItemArray);
            }
        }

        private void shedule_transport_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Scheduled travel");
        }

        

        private void view_all_drivers_Click(object sender, EventArgs e)
        {
            
        }

       
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void transpordGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = transpordGrid.SelectedRows[0];
            TransportID= row.Cells[0].Value.ToString();
            vehicleId.Text = row.Cells[1].Value.ToString();
            travelDate.Text = row.Cells[2].Value.ToString();
            time.Text = row.Cells[3].Value.ToString();
            driverId.Text = row.Cells[4].Value.ToString();
            destination.Text = row.Cells[5].Value.ToString();
            purpose.Text = row.Cells[6].Value.ToString();
            

        }

        private void travelDate_ValueChanged(object sender, EventArgs e)
        {
            time.Enabled = true;
            loadDriver();
            loadVehicle();
        }
        public void loadVehicle()
        {
            dt = t.Searchvehicle(travelDate.Text);
            foreach (DataRow row in dt.Rows)
            {
                vehicleGrid.Rows.Add(row.ItemArray);
            }
        }
        public void loadDriver()
        {
            try
            {
                dt = t.SearchDriver(travelDate.Text);
                foreach (DataRow row in dt.Rows)
                {
                    driverGrid.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            t.UpdateInfo(TransportID,vehicleId.Text,transportdate.Text,time.Text,driverId.Text,destination.Text,purpose.Text);
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            transpordGrid.Rows.RemoveAt(transpordGrid.SelectedRows[0].Index);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            t.DeleteInfo(TransportID);
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            transpordGrid.Rows.RemoveAt(transpordGrid.SelectedRows[0].Index);
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void driverGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = vehicleGrid.SelectedRows[0];
            driverId.Text = row.Cells[0].Value.ToString();
        }

        private void vehicleGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = vehicleGrid.SelectedRows[0];
            vehicleId.Text = row.Cells[1].Value.ToString();
        }
    }

}
