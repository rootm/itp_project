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
    public partial class ServiceCenter : Form
    {
        DBAccess db = new DBAccess();
        ServiceCenters sc = new ServiceCenters();
        
        public ServiceCenter()
        {
            InitializeComponent();
        }
        void loadGrid(int scid)
        {
            
            DataTable dt = sc.getdetailsx(scid);
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
            
        }

        void loadGridV(int scid)
        {

            DataTable dt = sc.getdetailsV(scid);
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }

        }
        void loadGrid()
        {
            DataTable dt = sc.getdetailsx();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
                        
        }

        void loadGridV()
        {
            DataTable dt = sc.getdetailsV();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }

        }

        void clearDetail()
        {
            name_.Text = null;
            address_.Text = null;
            telephone_.Text = null;
            //c_person.Text = null;
            serviceType_.Text = null;
        }

        void clearDetailsEdit()
        {
            centerID.Text = null;
            name_edit.Text = null;
            address_edit.Text = null;
            telephone_edit.Text = null;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServiceCenter_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

      
      

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                centerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                telephone_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                address_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //   textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //   textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = name_.Text;
                string address = address_.Text;
                string telephone = telephone_.Text;
              //  string person = c_person.Text;
                string s_type = serviceType_.Text;

                if (s_type == "Vehicle")
                {

                    sc.insertVehicle(name, telephone, address);

                    MessageBox.Show("Data saved");
                    clearDetail();
                }

                else if(s_type == "Machine")
                {
                    sc.insertMachine(name, telephone, address);

                    MessageBox.Show("Data saved");
                    clearDetail();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearDetail();
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int scid =Convert.ToInt32( centerID.Text);
                dataGridView1.Rows.Clear();
                if (service_type.Text == "Machine")
                {

                    loadGrid(scid);
                }
                else if (service_type.Text == "Vehicle")
                {
                    loadGridV(scid);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            if (service_type.Text == "Machine")
            {
                loadGrid();
            }
            else if (service_type.Text == "Vehicle")
            {
                loadGridV();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int serviceID = Convert.ToInt32(centerID.Text);
                    string service_name = name_edit.Text;
                    string address = address_edit.Text;
                    string telephone = telephone_edit.Text;

                    dataGridView1.Rows.Clear();

                    if (service_type.Text == "Machine")
                    {

                        sc.UpdateMachine(serviceID, service_name, telephone, address);
                        loadGrid(serviceID);
                        MessageBox.Show("Data Saved Successfully");
                    }
                   
                    else if (service_type.Text == "Vehicle")
                    {
                        sc.UpdateVehicle(serviceID, service_name, telephone, address);
                        loadGridV(serviceID);
                        MessageBox.Show("Data Saved Successfully");

                    }

                    clearDetailsEdit();

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel update ");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int centerid = Convert.ToInt32(centerID.Text);

                    dataGridView1.Rows.Clear();

                    if (service_type.Text == "Machine")
                    {
                        sc.DeleteMachine(centerid);

                        loadGrid();
                        MessageBox.Show("Successfully deleted");
                    }
                    else if (service_type.Text == "Vehicle")
                    {
                        sc.DeleteVehicle(centerid);

                        loadGridV();
                        MessageBox.Show("Successfully deleted");
                    }
                     
                 }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel Deletion");
                }


                clearDetailsEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            panel1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                centerID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                telephone_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                address_edit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                //textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void service_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
