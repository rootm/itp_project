using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Factory_management

{
    class general
    {
        DBAccess db = new DBAccess();
        public void InsertInfo(string Vtype, string purpose, string regNo, string ename, int mobile, string destination)
        {

            db.connect();

            string query = "INSERT INTO tshedule (Vtype, purpose, regNo, ename, mobile, destination) VALUES ('" + Vtype + "','" + purpose + "','" + regNo + "','" + ename + "''" + mobile + "','" + destination + "')";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void UpdateInfo(int vehicleId, string tDate, string tTime, string purpose, string regNo, string Vtype, string ename, int mobile, string destination)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int vehicleId;
            string query = "UPDATE tshedule set tDate = '" + tDate + "', tTime = '" + tTime + "', purpose = '" + purpose + "', regNo = '" + regNo + "', Vtype = '" + Vtype + "', ename = '" + ename + "', mobile = '" + mobile + "', destination = '" + destination + "', ' WHERE vehicleId = '" + vehicleId + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void DeleteInfo(int vehicleId)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int vehicleid;
            string query = "DELETE FROM tschedule WHERE vehicleId = '" + vehicleId + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }



        public DataTable getdetailsvehicle(string date)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT vehicleId, registrationNo, vehicleType, model, status FROM vehicle_details WHERE  status=1 AND vehicleId NOT IN ((SELECT ts.vehicleId FROM transport_schedule ts WHERE ts.date=@date UNION SELECT ds.vehicleId  FROM delivery_schedule ds WHERE ds.date=@date))";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }


        public DataTable getdetailsdriver(string date)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT employeeId, employeeName,phone FROM employee_details WHERE designation='driver' AND employeeId NOT IN (SELECT driverId FROM transport_schedule ts WHERE ts.date=@date UNION SELECT ds.driverId FROM delivery_schedule ds WHERE ds.date=@date)";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;



        }

        public DataTable getdetails5()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT eid,ename,mobile FROM employee WHERE designation = 'Driver'";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;






        }
    }
    
}
