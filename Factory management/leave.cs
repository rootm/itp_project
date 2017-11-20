using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_management
{
    class leave
    {
        DBAccess db = new DBAccess();


        public void insertLeaveDetails(int eid, string ename, string date, int nodays, string type, string reason)
        {
            DBAccess db = new DBAccess();
            db.connect();

            string query = "INSERT INTO leave_details (emplyeeId,employeeName,date,numberOfDays,leavetype,reason) VALUES ('" + eid + "', '" + ename + "', '" + date + "', '" + nodays + "', '"+type+"' , '"+reason+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void updateLeaveDetails(int lid, int eid, string ename, string date, int noDays, string type, string reason)
        {
            DBAccess db = new DBAccess();
            db.connect();

            string query = "UPDATE leave_details SET leaveId = '" + lid + "' , emplyeeId = '" + eid + "' , employeeName = '" + ename + "', date = '" + date + "', numberOfDays = '" + noDays + "' , leavetype = '"+type+"' , reason = '"+reason+"' WHERE leaveId = '" + lid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void deleteLeaveDetails(int lid, int eid, string ename, string date, int noDays, string type, string reason)
        {
            DBAccess db = new DBAccess();
            db.connect();

            string query = "DELETE FROM leave_details WHERE leaveId = '" + lid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public DataTable getLeaveDetails()
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM leave_details";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getLeaveDetails(string ename)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM leave_details WHERE employeeName = '"+ename+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getLeaveDetails(int eid)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM leave_details WHERE emplyeeId = '"+eid+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }




        public DataTable getEmpDetails()
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId,employeeName FROM employee_details ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getEmpDetails(string name)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId,employeeName FROM employee_details WHERE employeeName = '"+ name +"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getEmpDetails(int eid)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId,employeeName FROM employee_details WHERE employeeId = '"+eid+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }
    }
}
