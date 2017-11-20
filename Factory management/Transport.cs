using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Factory_management
{
    class Transport
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();

        public DataTable SearchDriver(string date)
        {
            db.connect();
            string query = "SELECT employeeId, employeeName,phone FROM employee_details WHERE designation='driver' AND employeeId NOT IN (SELECT driverId FROM transport_schedule ts WHERE ts.date=@date UNION SELECT ds.driverId FROM delivery_schedule ds WHERE ds.date=@date)";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
        
        public DataTable Searchvehicle(string date)
        {
            db.connect();
            string query = "SELECT vehicleId, registrationNo, vehicleType, model, status FROM vehicle_details WHERE  status=1 AND vehicleId NOT IN ((SELECT ts.vehicleId FROM transport_schedule ts WHERE ts.date=@date UNION SELECT ds.vehicleId  FROM delivery_schedule ds WHERE ds.date=@date))";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
        public void InsertInfo(string vehicleId,string date, string time, string driverId,string destination, string purpose)
        {

            db.connect();

            string query = "INSERT INTO transport_schedule (vehicleId,date, time,driverId,destination,purpose,status) VALUES (@vehicleId,@date,@time,@driverid,@destination,@purpose,'scheduled')";
            
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@driverid", driverId);
            cmd.Parameters.AddWithValue("@destination", destination);
            cmd.Parameters.AddWithValue("@purpose", purpose);
            cmd.ExecuteNonQuery();
            db.closeconnect(); 
        }
        public void UpdateInfo(string transportId, string vehicleId, string date, string time, string driverId, string destination, string purpose)
        {
            db.connect();

            string query = "UPDATE transport_schedule SET  vehicleId = @vehicleId, date = @date, time = @time,  driverId = @driverId, destination = @destination, purpose=@purpose WHERE transportId=@transportId";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@driverId", driverId);
            cmd.Parameters.AddWithValue("@destination", destination);
            cmd.Parameters.AddWithValue("@purpose", purpose);
            cmd.Parameters.AddWithValue("@transportId", transportId);
            cmd.ExecuteNonQuery();
            db.closeconnect();

        }
        public void DeleteInfo(string transportId)
        {
            db.connect();
            string query = "DELETE FROM transport_schedule WHERE transportId=@transportId";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@transportId", transportId);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public DataTable searchDate(string transportDate)
        {
            db.connect();
            string query = "SELECT * FROM transport_schedule WHERE date=@date AND status = 'scheduled' ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", transportDate);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
        public DataTable view()
        {
            db.connect();
            string query = "SELECT * FROM transport_schedule WHERE status = 'scheduled' ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }


    }
}
