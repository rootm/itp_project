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
    
    public partial class CheckRepair : Form
    {
        int id;

        Machine m = new Machine();
        machineRepairs mr = new machineRepairs();
        VehicleRepairDetails v = new VehicleRepairDetails();

        public CheckRepair()
        {
            InitializeComponent();
        }

        void loadGridMachine()
        {
            DataTable dt = mr.getMachineRepairDetails();
            foreach (DataRow row in dt.Rows)
            {
                machineRepairGrid.Rows.Add(row.ItemArray);
            }
        }
        void loadGridVehicle()
        {
            DataTable dt = v.getAllVehicleRepairDetails();
            foreach(DataRow row in dt.Rows)
            {
                vehicleRepairGrid.Rows.Add(row.ItemArray);
            }
        
        }
        private void CheckRepair_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            
            DBAccess db = new DBAccess();
             Machine m = new Machine();


             try
             {

                 DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                    

                     m.DeleteInfo(id);

                     //Loadgrid();
                     MessageBox.Show("Successfully deleted");
                     //clearDetails();
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
        

        private void buttonX5_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Machine m = new Machine();

            try
            {

                if (machineRadio.Checked)
                {

                    loadGridMachine();

                }

                else if (vehicleRadio.Checked)
                {

                    loadGridVehicle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        //   id = Convert.ToInt32(//dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {

                if (machineRadio.Checked)
                {
                    vehicleRepairGrid.Hide();
                    machineRepairGrid.Show();

                    machineRepairGrid.Rows.Clear();
                    loadGridMachine();

                }

                else if (vehicleRadio.Checked)
                {
                    machineRepairGrid.Hide();
                    vehicleRepairGrid.Show();

                    vehicleRepairGrid.Rows.Clear();
                    loadGridVehicle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void save_Click(object sender, EventArgs e)
        {
            // panel1.Hide();
            /*
            if (machineRadio.Checked)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int repairId= Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[0].Value.ToString());
                        int machineId= Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[1].Value.ToString());
                        int serviceCenter=Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[2].Value.ToString());
                        string repairDate= vehicleRepairGrid.SelectedRows[0].Cells[3].Value.ToString(); 
                        string description= vehicleRepairGrid.SelectedRows[0].Cells[4].Value.ToString(); 
                        string cost= vehicleRepairGrid.SelectedRows[0].Cells[5].Value.ToString();
                        string status = statusCombo.Text;

                        //    mr.update(repairId, machineId, serviceCenter, repairDate, description, cost, status);

                        mr.updateStatus(repairId, status);
                        MessageBox.Show("Data Saved Successfully");
                        vehicleRepairGrid.Rows.Clear();
                        loadGridVehicle();

                        statusCombo.Text = null;


                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel ");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
         
            else if (vehicleRadio.Checked)
            {
                
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int repairId = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[0].Value.ToString());
                            int vehicleId = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[1].Value.ToString());
                            string repairType = vehicleRepairGrid.SelectedRows[0].Cells[2].Value.ToString();
                            string description = vehicleRepairGrid.SelectedRows[0].Cells[3].Value.ToString();
                            string cost = vehicleRepairGrid.SelectedRows[0].Cells[4].Value.ToString();
                            string repairDate = vehicleRepairGrid.SelectedRows[0].Cells[5].Value.ToString();
                            int serviceCenter = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[6].Value.ToString());
                            string status = statusCombo.Text;

                            v.update(repairId,vehicleId,repairType,description,cost,repairDate,serviceCenter,status);


                            MessageBox.Show("Data Saved Successfully");
                            machineRepairGrid.Rows.Clear();
                            loadGridMachine();

                            statusCombo.Text = null;


                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Cancel  ");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            */
        }

        private void delete_Click(object sender, EventArgs e)
        {
           /* if (machineRadio.Checked) {
                try
                {

                    DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int repairId = Convert.ToInt32(machineRepairGrid.SelectedRows[0].Cells[0].Value.ToString());
                        mr.delete(repairId);
                        MessageBox.Show("successful deletion");
                        machineRepairGrid.Rows.Clear();
                        loadGridMachine();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("cancel deletion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (vehicleRadio.Checked)
            {
                try
                {

                    DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int repairId = Convert.ToInt32(vehicleRepairGrid.SelectedRows[0].Cells[0].Value.ToString());
                        v.delete(repairId);
                        MessageBox.Show("successful deletion");
                        machineRepairGrid.Rows.Clear();
                        loadGridMachine();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("cancel deletion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
