using Factory_management;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    class salary1
    {
        DBAccess db = new DBAccess();

        public int getDepartmentId(string department)
        {

            db.connect();
            try
            {

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                string query = "SELECT departmentId FROM department_details WHERE departmentName = '" + department + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int dept = -1;
                if (reader.Read())
                {
                    dept = reader.GetInt32("departmentId");

                }


                db.connection.Close();
                return dept;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }

        }
        public void insertSalaryDetails(int eid, string ename, string month1,string year, double salary, int otHours, double hourlyRate, double otTotal, double epf, double etf, int noPayDays, int dailyDeduction, double nopayTotal, double total)
        {
           
            db.connect();

            string query = "INSERT INTO salary_details (employeeId,employeeName,month,year,salary,otHours,hourlyRate,otTotal,epf,etf,noPay_days,dailyDeductions,noPay_total,total) VALUES ('"+eid+"', '"+ename+"', '"+month1+"', '"+year+"' ,  '"+salary+"', '"+otHours+"' , '"+hourlyRate+"', '"+otTotal+"', '"+epf+"', '"+etf+"', '"+noPayDays+"', '"+dailyDeduction+"', '"+nopayTotal+"', '"+total+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void updateSalaryDetails(int eid, string ename, string month1, string year, double salary, int otHours, double hourlyRate, double otTotal, double epf, double etf, int noPayDays, int dailyDeduction, double nopayTotal, double total)
        {
            
            db.connect();

            string query = "UPDATE salary_details SET employeeId  = '"+eid+"', employeeName = '"+ename+"', month ='"+month1+"' , year = '"+year+"' ,  salary = '"+salary+"', otHours = '"+otHours+"' , hourlyRate = '"+hourlyRate+"', otTotal = '"+otTotal+"', epf = '"+epf+"', etf = '"+etf+"', noPay_days = '"+noPayDays+"', dailyDeductions = '"+dailyDeduction+"', noPay_total = '"+nopayTotal+"' , total = '"+total+"' WHERE employeeId = '"+eid+"' AND month = '"+month1+"' AND year = '"+year+"'";
            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void deleteSalaryDetails(int eid,string month,string year)
        {

          
            db.connect();

            //    int eid;
            string query = "DELETE  FROM salary_details WHERE employeeId = '"+eid+"' AND month='"+month+"' AND year='"+year+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }
        public DataTable getSalaryDetails()
        {

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM salary_details";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getDeptEmpDetails(int department)
        {

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT e.employeeId,e.employeeName,e.basicSalary,o.otHours FROM employee_details e , ot_details o , leave_details l WHERE o.employeeId = e.employeeId AND l.emplyeeId = e.employeeId AND e.departmentid = '" + department + "' ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getDeptEmpDetailsId(int id)
        {
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT e.employeeId,e.employeeName,e.basicSalary,o.otHours FROM employee_details e , ot_details o WHERE o.employeeId = e.employeeId  AND e.employeeId = '"+id+"' ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getDeptEmpDetailsName(string ename)
        {
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT e.employeeId,e.employeeName,e.basicSalary,o.otHours FROM employee_details e , ot_details o  WHERE o.employeeId = e.employeeId AND e.employeeName = '"+ename+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getDeptEmpDetails()
        {
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT e.employeeId,e.employeeName,e.basicSalary,o.otHours FROM employee_details e , ot_details o WHERE o.employeeId = e.employeeId ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }


        public DataTable getSalaryDetails(int id)
        {
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM salary_details WHERE employeeId = '"+id+"'";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;



        }

 
    }

}

