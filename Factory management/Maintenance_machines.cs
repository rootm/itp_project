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
    public partial class Maintenance_machines : Form
    {
        Machine m = new Machine();
        machineRepairs mr = new machineRepairs();


        public string image;

        public Maintenance_machines()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //textBox5.Text = dataGridView8.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        void loadGrid(int mid)
        {
            DataTable dt = m.getdetailsx(mid);
            foreach (DataRow row in dt.Rows)
            {
                machineRepairGriid.Rows.Add(row.ItemArray);
            }
        }

        void loadGrid()
        {
            DataTable dt = m.getdetailsx();
            foreach (DataRow row in dt.Rows)
            {
                machineRepairGriid.Rows.Add(row.ItemArray);
            }
        }

        void clearDetails()
        {
            machineNo.Text = null;
            //type.Text = null;
            sericeCenter.Text = null;
            date.Text = null;
            cost.Text = null;
            receipt_description.Text = null;
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  textBox5.Text = dataGridView8.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(machineNo.Text);
                machineRepairGriid.Rows.Clear();
                loadGrid(mid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            machineRepairGriid.Rows.Clear();
            loadGrid();
        }

        private void save_repair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int machineNo = Convert.ToInt32(this.machineNo.Text);
                  
                    string serviceCenter1 = sericeCenter.Text;
                    int service_center = mr.getServiceCenterID(serviceCenter1);
                    string cost1 = cost.Text;
                    string date1 = date.Text;
                    string repair = receipt_description.Text;

                    mr.insertMachine(machineNo, service_center, date1, repair, cost1, "Available");

                    MessageBox.Show("Successful Insertion");
                  
                    clearDetails();

                }
                else
                {
                    MessageBox.Show("Cancel Insertion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView8_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //  textBox5.Text = dataGridView8.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void machineRepairGriid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            machineNo.Text = machineRepairGriid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void sericeCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Maintenance_machines_Load(object sender, EventArgs e)
        {
            DataTable dt = mr.getMachineServiceCenter();
            foreach (DataRow row in dt.Rows)
            {
                sericeCenter.Items.Add(row.ItemArray[0]);
            }
        }
    }
}
