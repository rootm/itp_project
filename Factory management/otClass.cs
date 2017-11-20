using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_management
{
    class ot
    {
        DBAccess db = new DBAccess();
        


        public void insertOtDetails(int eid , string ename , string date , int otHrs)
        {
            
            db.connect();

            string query = "INSERT INTO ot_details (employeeId,employeeName,date,otHours) VALUES ('"+eid+"', '"+ename+"', '"+date+"', '"+otHrs+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void updateOtDetails(int oid, int eid, string ename, string date, int otHrs)
        {
            
            db.connect();
        
            string query = "UPDATE ot_details SET otID = '"+oid+"' , employeeId = '"+eid+"' , employeeName = '"+ename+"', date = '"+date+"', otHours = '"+otHrs+"' WHERE otID = '"+oid+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }


        public void deleteOtDetails(int oid, int eid, string ename, string date, int otHrs)
        {
            
            db.connect();

            string query = "DELETE FROM ot_details WHERE otID = '"+oid+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }


        public DataTable getOTDetails()
        {
            

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM ot_details ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                  db.connection.Close();

            return dt;
        }


        public DataTable getOTDetails(string name)
        {
            

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM ot_details WHERE employeeName = '"+name+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }


        public DataTable getOTDetails(int id)
        {
           
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM ot_details WHERE employeeId = '"+id+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getEmpDetails(string name)
        {
           
            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId,employeeName FROM employee_details WHERE employeeName = '"+name+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getEmpDetails(int eid)
        {
          
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
