using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Factory_management
{
    class deliverySchedule
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public int InsertInfo(string date, string time, string oderId, string driverId, string vehicleId)
        {

            db.connect();

            string query = "INSERT INTO delivery_schedule (date, time,orderId,driverId,vehicleId,status) VALUES (@date,@time,@orderId,@driverid,@vehicleId,'scheduled')";
            string query1 = "UPDATE agent_orders SET status = 'delivered' WHERE orderId = @orderId";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@orderId", oderId);
            cmd.Parameters.AddWithValue("@driverid", driverId);
            cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd1.Parameters.AddWithValue("@orderId", oderId);

            int rows = cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            db.closeconnect();

            return rows;
        }

        public void UpdateInfo(string id, string date, string time, string orderId, string vehicleId, string driverId)
        {
            db.connect();

            string query = "UPDATE delivery_schedule SET date = @date, time = @time, orderId = @orderId, vehicleId = @vehicleId, driverId = @driverId WHERE deliveryId = @deliveryId ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
            cmd.Parameters.AddWithValue("@driverId", driverId);
            cmd.Parameters.AddWithValue("@deliveryId", id);
            cmd.ExecuteNonQuery();
            db.closeconnect();

        }

        public void DeleteInfo(string id )
        {

            
            db.connect();

            
            string query = "DELETE FROM delivery_schedule WHERE deliveryId = @id";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            db.closeconnect();

        }

        public DataTable getdetails()
        {
            
            db.connect();

            

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT ao.orderId,ao.agentId,ad.name,ao.orderDate,ao.total FROM agent_orders ao,agent_details ad WHERE  ad.agentId=ao.agentId AND ao.status='released'";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.closeconnect();

            return dt;
        }


        public DataTable getdetailsSearch(string orderdate )
        {
            

            db.connect();
            

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT ao.orderId,ao.agentId,ad.name,ao.orderDate,ao.total FROM agent_orders ao,agent_details ad WHERE ao.orderDate=@date AND ad.agentId=ao.agentId AND ao.status='released'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", orderdate);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.closeconnect();

            return dt;

        }
        public DataTable getdetailsShedule(string deliveryId )
        {


            db.connect();


          
            string query = "SELECT * FROM delivery_schedule WHERE deliveryId=@id";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@id", deliveryId);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;

        }
        public DataTable getdetailsSheduleView()
        {


            db.connect();



            string query = "SELECT * FROM delivery_schedule";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            //cmd.Parameters.AddWithValue("@id", deliveryId);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;

        }
    }
    }
