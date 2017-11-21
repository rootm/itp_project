using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Factory_management
{
    public partial class empSearch : Form
    {
        DBAccess db = new DBAccess();
        employee ee = new employee();

        public empSearch()
        {
            InitializeComponent();
            Loadgrid();

        }


      

        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

      
   

      

        private void empSearch_Load(object sender, EventArgs e)
        {
            
        }



        //clear data method
        public void clearDetails()
        {
            label7.Text = null;
            textBox1.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = null;
            textBox2.Text = null;
            dateTimePicker2.Text = null;
            dept1.Text = null;
            comboBox3.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;

            radioButton7.Checked = false;
            radioButton8.Checked = false;
            dept2.Text = null;
            textBox12.Text = null;
        }



        //table load

        void Loadgrid()
        {
            employee ee = new employee();

            DataTable dt = ee.getdetails();

            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

           

        }

        void Loadgrid1(int id , int dept)
        {
            employee ee = new employee();

              DataTable dt = ee.getdetails(id,dept);

            foreach (DataRow row in dt.Rows)
            {

              dataGridView1.Rows.Add(row.ItemArray);
            }
            

        }

        void Loadgrid2(int department)
        {
            employee ee = new employee();

            DataTable dt = ee.getdetails(department);

            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

           

        }

        void Loadgrid3(string name , int department)
        {
            employee ee = new employee();

            DataTable dt = ee.getdetails(name,department);
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

        }

     

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            radioButton1.Checked = true; 
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            int did =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            comboBox3.Text = ee.getDepartmentName(did);
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void employee_viewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Loadgrid();
        }

        private void employee_search_Click(object sender, EventArgs e)
        {

            DBAccess db = new DBAccess();
            employee ee = new employee();

            try
            {

                string Department = dept2.Text;
                int Department1 = ee.getDepartmentId(Department);


                if (radioButton8.Checked)
                {
                    int EID1 = Convert.ToInt32(textBox12.Text);
                    dataGridView1.Rows.Clear();
                    Loadgrid1(EID1, Department1);


                }
                else if (radioButton7.Checked)
                {
                    string Name1 = textBox12.Text;
                    dataGridView1.Rows.Clear();
                    Loadgrid3(Name1, Department1);

                }

                else
                {
                    dataGridView1.Rows.Clear();
                    Loadgrid2(Department1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clearDetails();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            label7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            radioButton1.Checked = true;
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            int did = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            dept1.Text = ee.getDepartmentName(did);

            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
        }

        private void update_employee_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            employee ee = new employee();

            try
            {
                //validation
                int warning = 0;
                bool warning6 = false;
                bool warning7 = false;



                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(dateTimePicker2.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(dept1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(comboBox3.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox4.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox5.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox6.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox7.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox8.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox9.Text))
                {
                    warning++;
                }


                /////////////////////////////

                if ((!textBox4.Text.All(char.IsDigit)) || (textBox4.Text.Length != 10))
                {
                    MessageBox.Show("Invalid phone number");
                    warning6 = true;
                }

                //////////////////////

                if ((!textBox5.Text.All(char.IsDigit)) || (textBox5.Text.Length != 10))
                {
                    warning7 = true;
                    MessageBox.Show("Invalid mobile number");
                }

                ///////////////////////////////////
                if (warning != 13)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                /*      //nic
                      if ((textBox2.Text).Length != 10)
                      {
                          MessageBox.Show("Invali NIC");
               
                       }*/

                //email
                string email = textBox6.Text;

                if (IsValidEmail(email) == false)
                {
                    MessageBox.Show("Invalid Email");
                }


                if ((warning == 13) && (warning6 == false) && (warning7 == false) && (IsValidEmail(email) == true))
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //set values
                        String EID1 = label7.Text;
                        string Name1 = textBox1.Text;
                        string Gender1;
                        if (radioButton1.Checked)
                        {
                            Gender1 = "male";
                        }
                        else
                        {
                            Gender1 = "female";
                        }
                        string Birthday1 = dateTimePicker1.Text;
                        string NIC1 = textBox2.Text;
                        string JoinDate1 = dateTimePicker2.Text;
                        string Department = dept1.Text;
                        int Department1 = ee.getDepartmentId(Department);
                        string Designation1 = comboBox3.Text;
                        string Address1 = textBox3.Text;
                        string Phone1 = textBox4.Text;
                        string Mobile1 = textBox5.Text;
                        string Email1 = textBox6.Text;
                        string Salary1 = textBox7.Text;
                        string Bank1 = textBox8.Text;
                        string AccNo1 = textBox9.Text;


                        ee.UpdateInfo(EID1, Name1, Gender1, Birthday1, NIC1, JoinDate1, Department1, Designation1, Address1, Phone1, Mobile1, Email1, Salary1, Bank1, AccNo1);

                        dataGridView1.Rows.Clear();
                        Loadgrid();

                        MessageBox.Show("Data Saved Successfully");

                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel  ");
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_employee_Click(object sender, EventArgs e)
        {

            employee ee = new employee();

            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int EID1 = Convert.ToInt32(label7.Text);

                    ee.DeleteInfo(EID1);
                    dataGridView1.Rows.Clear();
                    Loadgrid();
                    clearDetails();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

     
        private void clear_employee_Click(object sender, EventArgs e)
        {
            try
            {
                clearDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {


            label7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            radioButton1.Checked = true;
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            int did = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            dept1.Text = ee.getDepartmentName(did);
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataTable dt = ee.getDepartmentDetails();
            foreach (DataRow row in dt.Rows)
            {
                dept2.Items.Add(row.ItemArray[0]);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            DataTable dt = ee.getDepartmentDetails();
            foreach (DataRow row in dt.Rows)
            {
                dept1.Items.Add(row.ItemArray[0]);
            }
        }
    }
}
