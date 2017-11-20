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
    public partial class vehicleRepairs_shedule : Form
    {
        VehicleRepairDetails v1 = new VehicleRepairDetails();

        public string image;


        public vehicleRepairs_shedule()
        {
            InitializeComponent();
        }


        void loadGrid()
        {
            DataTable dt = v1.getVehicleRepairDetails();
            foreach (DataRow row in dt.Rows)
            {
                vehicleRepairGrid.Rows.Add(row.ItemArray);
            }
        }

        private void vehicleRepairs_shedule_Load(object sender, EventArgs e)
        {
            //vehicleRepairGrid.Rows.Clear();
            loadGrid();

            DataTable dt = v1.getVehicleServiceCenter();
            foreach (DataRow row in dt.Rows)
            {
                serviceCenter.Items.Add(row.ItemArray[0]);
            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_repair_details_Click(object sender, EventArgs e)
        {
            try
            {
                int repairId = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[0].Value.ToString());
                int vehicleId = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[1].Value.ToString());
                string repairType = vehicleRepairGrid.SelectedRows[0].Cells[2].Value.ToString();
                string description = vehicleRepairGrid.SelectedRows[0].Cells[3].Value.ToString();

                string cost1 = cost.Text;
                string date1 = date.Text;
                string serviceCenter1 = serviceCenter.Text;
                int service_center = v1.getServiceID(serviceCenter1);
                string status = "Available";

                v1.updateInfo(repairId, vehicleId, repairType, description, cost1, date1, service_center, status);

                vehicleRepairGrid.Rows.Clear();
                loadGrid();
                // string key = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                serviceCenter.Text = "";
                cost.Text = "";

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vehicleRepairGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // machineNo.Text = machineRepairGriid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                    image = fd.FileName;
                    //byte[] photo_aray = new byte[fs.Length];
                    //fs.Read(image, 0, image.Length);
                    //warrentyImage.Image = Bitmap.FromFile(fd.FileName);

                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }
    }
}
