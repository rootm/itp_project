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
    public partial class salarySearch : Form
    {
        salary1 s1 = new salary1();
        employee ee = new employee();
        public salarySearch()
        {
            InitializeComponent();
            loadSalGrid();
           
        }

        void loadSalGrid(int id)
        {
            DataTable dt = s1.getSalaryDetails(id);
            foreach (DataRow row in dt.Rows)
            {
                salaryGrid.Rows.Add(row.ItemArray);
            }
           
        }

        void loadSalGrid()
        {
            DataTable dt = s1.getSalaryDetails();
            foreach(DataRow row in dt.Rows)
            {
                salaryGrid.Rows.Add(row.ItemArray);
            }
        }
        void loadEmpGrid(int department)
        { 

            DataTable dt = s1.getDeptEmpDetails(department);
            foreach (DataRow row in dt.Rows)
            {
                empGrid.Rows.Add(row.ItemArray);
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

        void loadEmpGrid1(string ename)
        {
            DataTable dt = s1.getDeptEmpDetailsName(ename);
            foreach (DataRow row in dt.Rows)
            {
                empGrid.Rows.Add(row.ItemArray);
            }
        }
      

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                int warning = 0;

                if (!String.IsNullOrEmpty(month.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(hRate.Text))
                {
                    warning++;
                }
                
                if (!String.IsNullOrEmpty(noPay.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(dailyDeduction.Text))
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

                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int eid = Convert.ToInt32(id.Text);
                        string ename = this.ename.Text;
                        string month1 = month.Text;
                        double salary = Convert.ToDouble(bsalary.Text);
                        int otHours = Convert.ToInt32(this.otHours.Text);
                        double hourlyRate = Convert.ToDouble(hRate.Text);

                        double otTotal = otHours * hourlyRate;
                        this.otTotal.Text = Convert.ToString(otTotal);

                        double epf = salary * 0.08;
                        epf_.Text = Convert.ToString(epf);

                        double etf = salary * 0.12;
                        epf_.Text = Convert.ToString(etf);

                        int noPayDays = Convert.ToInt32(noPay.Text);
                        double dailyDeduction = Convert.ToDouble(this.dailyDeduction.Text);

                        double nopayTotal = noPayDays * dailyDeduction;
                        noPayTot.Text = Convert.ToString(nopayTotal);

                        double total = (salary + otTotal) - (epf + nopayTotal);


                  //      s1.updateSalaryDetails(eid, ename, month1, salary, otHours, hourlyRate, otTotal, epf, etf, noPayDays, dailyDeduction, nopayTotal, total);

                        MessageBox.Show("Successfully Updated");
                        loadSalGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int eid = Convert.ToInt32(id.Text);
                    string month = this.month.Text;
          //          s1.deleteSalaryDetails(eid,month);
                    loadSalGrid();
                    MessageBox.Show("Successfully Deleted");
                    clearDetails();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            loadEmpGrid();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ename.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            bsalary.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            otHours.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            epf_.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            etf_.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);


            int id = Convert.ToInt32(this.id.Text);

            loadSalGrid(id);


        }

        void clearDetails()
        {
            id.Text = null;
            ename.Text = null;
            month.Text = null;
            bsalary.Text = null;
            otHours.Text = null;
            hRate.Text = null;
            otTotal.Text = null;
            epf_.Text = null;
            etf_.Text = null;
            noPay.Text = null;
            dailyDeduction.Text = null;
            noPayTot.Text = null;
            total.Text = null;

        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string department = dept.Text;
                int deptId = s1.getDepartmentId(department);
                loadEmpGrid(deptId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = salaryGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ename.Text = salaryGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            month.Text = salaryGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            bsalary.Text = salaryGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            otHours.Text = salaryGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            hRate.Text = salaryGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            otTotal.Text = salaryGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            epf_.Text = salaryGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            etf_.Text = salaryGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            noPay.Text = salaryGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            dailyDeduction.Text = salaryGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            noPayTot.Text = salaryGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
            total.Text = salaryGrid.Rows[e.RowIndex].Cells[12].Value.ToString();




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = salaryGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ename.Text = salaryGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            month.Text = salaryGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            bsalary.Text = salaryGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            otHours.Text = salaryGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            hRate.Text = salaryGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            otTotal.Text = salaryGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            epf_.Text = salaryGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            etf_.Text = salaryGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            noPay.Text = salaryGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            dailyDeduction.Text = salaryGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            noPayTot.Text = salaryGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
            total.Text = salaryGrid.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void agent_search_Click(object sender, EventArgs e)
        {
            try
            {
                string department = dept.Text;
                int deptId = s1.getDepartmentId(department);

                empGrid.Rows.Clear();
                loadEmpGrid(deptId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agent_viewAll_Click(object sender, EventArgs e)
        {

            
        }

        private void update_salary_Click(object sender, EventArgs e)
        {
            try
            {
                int warning = 0;

                if (!String.IsNullOrEmpty(month.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(hRate.Text))
                {
                    warning++;
                }

                if (!String.IsNullOrEmpty(noPay.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(dailyDeduction.Text))
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

                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int eid = Convert.ToInt32(id.Text);
                        string ename = this.ename.Text;
                        string month1 = month.Text;
                        string year = year1.Text;
                        double salary = Convert.ToDouble(bsalary.Text);
                        int otHours = Convert.ToInt32(this.otHours.Text);
                        double hourlyRate = Convert.ToDouble(hRate.Text);

                        double otTotal = otHours * hourlyRate;
                        this.otTotal.Text = Convert.ToString(otTotal);

                        double epf = salary * 0.08;
                        epf_.Text = Convert.ToString(epf);

                        double etf = salary * 0.12;
                        epf_.Text = Convert.ToString(etf);

                        int noPayDays = Convert.ToInt32(noPay.Text);
                        int dailyDeduction = Convert.ToInt32(this.dailyDeduction.Text);

                        double nopayTotal = noPayDays * dailyDeduction;
                        noPayTot.Text = Convert.ToString(nopayTotal);

                        double total = (salary + otTotal) - (epf + nopayTotal);


                        s1.updateSalaryDetails(eid, ename, month1,year, salary, otHours, hourlyRate, otTotal, epf, etf, noPayDays, dailyDeduction, nopayTotal, total);

                        MessageBox.Show("Successfully Updated");
                        salaryGrid.Rows.Clear();

                        loadSalGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_salary_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int eid = Convert.ToInt32(id.Text);
                    string month = this.month.Text;
                    string year = this.year1.Text;

                    s1.deleteSalaryDetails(eid, month,year);

                    salaryGrid.Rows.Clear();
                    loadSalGrid();
                    MessageBox.Show("Successfully Deleted");
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

        private void clear_salary_Click(object sender, EventArgs e)
        {
            clearDetails();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            this.id.Text = empGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ename.Text = empGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            bsalary.Text = empGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            otHours.Text = empGrid.Rows[e.RowIndex].Cells[3].Value.ToString();


            epf_.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.06);
            etf_.Text = Convert.ToString(Convert.ToDouble(empGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) * 0.04);


            int id = Convert.ToInt32(this.id.Text);

           // loadSalGrid(id);

        }

        private void salarySearch_Load(object sender, EventArgs e)
        {
            DataTable dt = ee.getDepartmentDetails();
            foreach (DataRow row in dt.Rows)
            {
                dept.Items.Add(row.ItemArray[0]);
            }
        }

        private void salary_viewAll_Click(object sender, EventArgs e)
        {
            empGrid.Rows.Clear();
            loadEmpGrid();
        }

        private void salaryGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id.Text = salaryGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            ename.Text = salaryGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            month.Text = salaryGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            //this.year1.Text = salaryGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            bsalary.Text = salaryGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            otHours.Text = salaryGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            hRate.Text = salaryGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            otTotal.Text = salaryGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            epf_.Text = salaryGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            etf_.Text = salaryGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            noPay.Text = salaryGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
            dailyDeduction.Text = salaryGrid.Rows[e.RowIndex].Cells[12].Value.ToString();
            noPayTot.Text = salaryGrid.Rows[e.RowIndex].Cells[13].Value.ToString();
            total.Text = salaryGrid.Rows[e.RowIndex].Cells[14].Value.ToString();

        }
    }
}
