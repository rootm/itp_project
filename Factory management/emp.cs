using Factory_management;
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
    public partial class emp : Form
    {
        employee ee = new employee();


        public emp()
        {
            InitializeComponent();
            Loadgrid();
        }

     

        //email
        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

      
      
     
    

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        //clear data method
        public void clearDetails()
        {
            textBox1.Text = null;
            radioButton2.Checked = false;
            dateTimePicker1.Text = null;
            textBox2.Text = null;
            dateTimePicker2.Text = null;
            dept.Text = null;
            comboBox3.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
        }



        //table load


        void LoadDepartment()
        {
            
           
        }
        void Loadgrid()
        {
            employee ee = new employee();

              DataTable dt = ee.getdetails();
              

            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataTable dt = ee.getDepartmentDetails();
            foreach (DataRow row in dt.Rows)
            {
                dept.Items.Add(row.ItemArray[0]);
            }
        }

        private void emp_Load(object sender, EventArgs e)
        {

        }

        private void save_employee_Click(object sender, EventArgs e)
        {
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
                if (!String.IsNullOrEmpty(dept.Text))
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


                //phone

                if ((!textBox4.Text.All(char.IsDigit)) || (textBox4.Text.Length != 10))
                {
                    MessageBox.Show("Invalid phone number");
                    warning6 = true;
                }

                //mobile

                if ((!textBox5.Text.All(char.IsDigit)) || (textBox5.Text.Length != 10))
                {
                    warning7 = true;
                    MessageBox.Show("Invalid mobile number");
                }

                //empty fields
                if (warning != 13)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                /*        //nic
                        if ((textBox2.Text).Length != 10)
                        {
                            MessageBox.Show("Invali NIC");
                        }
                        */
                //email
                string email = textBox6.Text;

                if (IsValidEmail(email) == false)
                {
                    MessageBox.Show("Invalid Email");
                }


                //

                if ((warning == 13) && (warning6 == false) && (warning7 == false) && (IsValidEmail(email) == true))

                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

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
                        string Department = dept.Text;
                        int Department1 = ee.getDepartmentId(Department);

                        string Designation1 = comboBox3.Text;
                        string Address1 = textBox3.Text;
                        string Phone1 = textBox4.Text;
                        string Mobile1 = textBox5.Text;
                        string Email1 = textBox6.Text;
                        double Salary1 = Convert.ToDouble(textBox7.Text);
                        string Bank1 = textBox8.Text;
                        int AccNo1 = Convert.ToInt32(textBox9.Text);


                        ee.InsertInfo(Name1, Gender1, Birthday1, NIC1, JoinDate1, Department1, Designation1, Address1, Phone1, Mobile1, Email1, Salary1, Bank1, AccNo1);

                        dataGridView1.Rows.Clear();
                        Loadgrid();

                        MessageBox.Show("Data Saved Successfully");

                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel Insertion");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_employee_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void search_employee_Click(object sender, EventArgs e)
        {
            empSearch es = new empSearch();
            es.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void demo_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Text = "Kamal";
            dateTimePicker1.Text = "1980-05-02";
            textBox2.Text = "801236547V";
            dateTimePicker2.Text ="2015-10-10";
            dept.Text = "Financial";
            comboBox3.Text = "Driver";
            textBox3.Text = "No;22/B/1,Matara";
            textBox4.Text = "0412165489";
            textBox5.Text = "0712369854";
            textBox6.Text = "kamal123@gmail.com";
            textBox7.Text = "15000";
            textBox8.Text = "BOC";
            textBox9.Text = "2013456";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
