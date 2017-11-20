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
    public partial class salary : Form
    {

        salary1 s1 = new salary1();
        employee ee = new employee();
        public salary()
        {
            InitializeComponent();
            loadSalaryGrid();
            

        }

        void loadEmpGrid(int department)
        {
            DataTable dt = s1.getDeptEmpDetails(department);
            foreach (DataRow row in dt.Rows)
            {
                empGrid.Rows.Add(row.ItemArray);
            }
        }


        void loadSalaryGrid()
        {
            DataTable dt = s1.getSalaryDetails();
            foreach (DataRow row in dt.Rows)
            {
                salaryGrid.Rows.Add(row.ItemArray);
            }
        }

        void loadEmpGrid()
        {
            DataTable dt = s1.getDeptEmpDetails();
            
            foreach (DataRow row in dt.Rows)
            {
                empGrid.Rows.Add(row.ItemArray);
            }
        }

        void clearDetails()
        {
            label20.Text = null;
            label23.Text = null;
            comboBox2.Text = null;
            label1.Text = null;
            label2.Text = null;
            textBox3.Text = null;
            
            label21.Text = null;
            label22.Text = null;
            textBox1.Text = null;
            deduct.Text = null;
            label8.Text = null;
            label11.Text = null;

        }

      

        void loadLabels()
        {
            salary1 s1 = new salary1();

            int eid = Convert.ToInt32(label20.Text);
            string ename = label23.Text;
            string month = comboBox2.Text;
            double basicSalary = Convert.ToDouble(label1.Text);
            int othrs = Convert.ToInt32(label2.Text);
            double hrlyRate = Convert.ToDouble(textBox3.Text);

            double otTot = othrs * hrlyRate;
            label7.Text = Convert.ToString(otTot);

            double epf = basicSalary * 0.06;
            label21.Text = Convert.ToString(epf);

            double etf = basicSalary * 0.04;
            label22.Text = Convert.ToString(etf);

            int nodays = Convert.ToInt32(textBox1);
            double dailyDeduction = Convert.ToDouble(deduct);
            double nopayTot = nodays * dailyDeduction;
            label8.Text = Convert.ToString(nopayTot);

            double grandTot = (basicSalary + otTot) - (epf + nopayTot);
            //label11.Text = Convert.ToString(grandTot);



        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonX2_Click(object sender, EventArgs e)
        {


            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(comboBox2.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {
                    warning++;
                }
               
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(deduct.Text))
                {
                    warning++;
                }

                //empty fields
                if (warning != 4)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                if (warning == 4) {


                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int eid = Convert.ToInt32(label20.Text);
                        string ename = label23.Text;
                        string month1 = comboBox2.Text;
                        double salary = Convert.ToDouble(label1.Text);
                        int otHours = Convert.ToInt32(label2.Text);
                        double hourlyRate = Convert.ToDouble(textBox3.Text);

                        double otTotal = otHours * hourlyRate;
                        label7.Text = Convert.ToString(otTotal);

                        double epf = salary * 0.08;
                        label21.Text = Convert.ToString(epf);

                        double etf = salary * 0.12;
                        label21.Text = Convert.ToString(etf);

                        int noPayDays = Convert.ToInt32(textBox1.Text);
                        double dailyDeduction = Convert.ToDouble(deduct.Text);

                        double nopayTotal = noPayDays * dailyDeduction;
                        label8.Text = Convert.ToString(nopayTotal);

                        double total = (salary + otTotal) - (epf + nopayTotal);


                //        s1.insertSalaryDetails(eid, ename, month1, salary, otHours, hourlyRate, otTotal, epf, etf, noPayDays, dailyDeduction, nopayTotal, total);

                        MessageBox.Show("Successful Insertion");
                        loadSalaryGrid();
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            salarySearch ss = new salarySearch();
            ss.Show();
            this.Dispose();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string department = dept.Text;
                int deptId = s1.getDepartmentId(department);
                loadEmpGrid(deptId);

            }
            catch
            {

            }
 /*           //DBAccess db = new DBAccess();
            salary1 ss = new salary1();

            try
            {
                
                string department = comboBox1.Text;
                Loadgrid(department);

                int eid = Convert.ToInt32(label20.Text);
                

            }
            catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
    
*/

        }

        private string getOtHours(int eid)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label20.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label23.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label1.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            label2.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            label21.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            label22.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            loadEmpGrid();
        }

        private void agent_viewAll_Click(object sender, EventArgs e)
        {
            loadEmpGrid();
        }

        private void agent_search_Click(object sender, EventArgs e)
        {
           
            /*           //DBAccess db = new DBAccess();
                       salary1 ss = new salary1();

                       try
                       {

                           string department = comboBox1.Text;
                           Loadgrid(department);

                           int eid = Convert.ToInt32(label20.Text);


                       }
                       catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }

           */
        }

        private void save_salary_Click(object sender, EventArgs e)
        {


            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(comboBox2.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {
                    warning++;
                }

                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(deduct.Text))
                {
                    warning++;
                }

                //empty fields
                if (warning != 4)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                if (warning == 4)
                {


                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int eid = Convert.ToInt32(label20.Text);
                        string ename = label23.Text;
                        string month1 = comboBox2.Text;
                        string year1 = year.Text;
                        double salary = Convert.ToDouble(label1.Text);
                        int otHours = Convert.ToInt32(label2.Text);
                        double hourlyRate = Convert.ToDouble(textBox3.Text);

                        double otTotal = otHours * hourlyRate;
                        label7.Text = Convert.ToString(otTotal);

                        double epf = salary * 0.08;
                        label21.Text = Convert.ToString(epf);

                        double etf = salary * 0.12;
                        label21.Text = Convert.ToString(etf);

                        int noPayDays = Convert.ToInt32(textBox1.Text);
                        int dailyDeduction = Convert.ToInt32(deduct.Text);

                        double nopayTotal = noPayDays * dailyDeduction;
                        label8.Text = Convert.ToString(nopayTotal);

                        double total = (salary + otTotal) - (epf + nopayTotal);

                        s1.insertSalaryDetails(eid, ename, month1, year1, salary, otHours, hourlyRate, otTotal, epf, etf, noPayDays,dailyDeduction, nopayTotal, total);

                        MessageBox.Show("Successful Insertion");
                        salaryGrid.Rows.Clear();
                        loadSalaryGrid();
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

        private void clear_attendance_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void search_salary_Click(object sender, EventArgs e)
        {
            salarySearch ss = new salarySearch();
            ss.Show();
            this.Dispose();
        }

        private void salary_Load(object sender, EventArgs e)
        {
            DataTable dt = ee.getDepartmentDetails();
            foreach (DataRow row in dt.Rows)
            {
                dept.Items.Add(row.ItemArray[0]);
            }

            label2.Text = "0";
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            label20.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label23.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label1.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            label2.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            label21.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            label22.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label20.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label23.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label1.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            label2.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            label21.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            label22.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void empGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label20.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            label23.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            label1.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            label2.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

            comboBox2.Text = "November";
            label21.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            label22.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);

        }

        private void salaryGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void salary_view_all(object sender, EventArgs e)
        {
            empGrid.Rows.Clear();
            loadEmpGrid();
        }

        private void salary_search_Click(object sender, EventArgs e)
        {
            try
            {
                string department = dept.Text;
                int deptId=s1.getDepartmentId(department);
                loadEmpGrid(deptId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void demo_Click(object sender, EventArgs e)
        {
            comboBox2.Text ="January";
            textBox3.Text = "300";
            textBox1.Text = "0";
            deduct.Text = "150";

       }
    }
        
    }
