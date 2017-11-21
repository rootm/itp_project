using Factory_management;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    class employee
    {

        DBAccess dba = new DBAccess();

        public int getDepartmentId(string department)
        {
            
            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT departmentId FROM department_details WHERE departmentName = '" + department + "'";

                MySqlCommand cmd = new MySqlCommand(query, dba.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int dept = -1;
                if (reader.Read()) {
                    dept = reader.GetInt32("departmentId");
                    
                }
              
               
                dba.connection.Close();
                return dept;
    
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
                
            }

        }

        public string getDepartmentName(int department)
        {

            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT departmentName FROM department_details WHERE departmentId = '"+department+"'";

                MySqlCommand cmd = new MySqlCommand(query, dba.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                string dept = null;
                if (reader.Read())
                {
                    dept = reader.GetString("departmentName");

                }


                dba.connection.Close();
                return dept;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }

        }

        public DataTable getDepartmentDetails()
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();

                DataTable dt = new DataTable();

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                string query = "SELECT departmentName FROM department_details";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                //      dataReader.Close();
                //       db.connection.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public DataTable getdetails()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM employee_details";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                 dataReader.Close();
                 db.connection.Close();

            return dt;
        }

        public DataTable getdetailsx(string department)
        {
            DBAccess db = new DBAccess();
            db.connect();


            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId,employeeName,basicSalary FROM employee_details WHERE departmentid = '"+department+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                   db.connection.Close();

            return dt;
        }

        public void InsertInfo(string name, string gender, string birthday, string nic, string joinDate, int department, string designation, string address, string phone, string mobile, string email, string salary, string bank, string accNo)
        {

            DBAccess db = new DBAccess();
            db.connect();

             //   int eid;
            string query = "INSERT INTO employee_details (employeeName,gender,birthday,nic,joinDate,departmentid,designation,address,phone,mobile,email,basicSalary,bank,accountNumber) VALUES ('"+name+"','"+gender+"','"+birthday+"','"+nic+"','"+joinDate+"','"+department+"','"+designation+"','"+address+"','"+phone+"','"+mobile+"','"+email+"','"+salary+"','"+bank+"','"+accNo+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void UpdateInfo(string eid, string name, string gender, string birthday, string nic, string joinDate, int department, string designation, string address, string phone, string mobile, string email, string salary, string bank, string accNo)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int eid;
            string query = "UPDATE employee_details set employeeName = '" +name+ "', gender = '" +gender+ "', birthday = '" +birthday+ "', nic = '" +nic+ "', joinDate = '" +joinDate+ "', departmentid = '" +department+ "', designation = '" +designation+ "', address = '" +address+ "', phone = '" +phone+ "', mobile = '" +mobile+ "', email = '" +email+ "', basicSalary = '" +salary+ "', bank = '" +bank+ "', accountNumber= '" +accNo+ "' WHERE employeeId = '" +eid+ "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }


        public void DeleteInfo(int eid)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int eid;
            string query = "DELETE  FROM employee_details WHERE employeeId = '" + eid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public DataTable getdetails(int department)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM employee_details WHERE departmentid = '"+department+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                  db.connection.Close();

            return dt;
        }

        public DataTable getdetails1(string department)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT e.employeeId,e.employeeName,e.basicSalary,o.otHours FROM employee_details e , ot_details o , leave_details l WHERE o.employeeId = e.employeeId AND l.employeeId = e.employeeId AND e.departmentid = '" + department + "' ";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getEmpdetails()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId , employeeName  FROM employee_details ";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }


        public DataTable getdetails(string name, int department)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM employee_details WHERE employeeName = '" + name + "' OR departmentid = '" + department + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                  db.connection.Close();

            return dt;
        }

        public DataTable getdetails(int id, int department)
        {
            DBAccess db = new DBAccess();
            db.connect();
            
                DataTable dt = new DataTable();

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                string query = "SELECT * FROM employee_details WHERE employeeId = '" + id + "' OR departmentid = '" + department + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                       dataReader.Close();
                       db.connection.Close();

                return dt;
            }



        /*        
               private int ID;
               private string Name;
               private string Gender;
               private string Birthday;
               private string NIC;
               private string JoinDate;
               private string Department;
               private string Designation;
               private string Address;
               private int Phone;
               private int Mobile;
               private string Email;
               private float Salary;
               private string Bank;
               private int AccNo;
        */


        }


    }

  

