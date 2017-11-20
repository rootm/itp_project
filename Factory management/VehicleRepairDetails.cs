using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Factory_management
{
    class VehicleRepairDetails
    {
        DBAccess dba = new DBAccess();

        public DataTable getdetailsx()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT vehicleId, repairType, description, cost, repairDate, serviceCenter, status FROM vehicle_repairs"; //WHERE rrid = '" + rrid + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }


        public int getServiceID(string serviceCenter)
        {

            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT centerId FROM vehicle_servicecenter WHERE name = '" + serviceCenter + "'";

                MySqlCommand cmd = new MySqlCommand(query, dba.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int centerID = -1;
                if (reader.Read())
                {
                    centerID = reader.GetInt32("centerId");

                }


                dba.connection.Close();
                return centerID;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }

        }

        public DataTable getVehicleRepairDetails()
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

                string query = "SELECT repairId,vehicleId,repairType,description FROM vehicle_repairs WHERE status = 'requested' ";

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


        public DataTable getAllVehicleRepairDetails()
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

                string query = "SELECT repairId,vehicleId,repairType,description,cost,repairDate,serviceCenter,status FROM vehicle_repairs";

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


        public void updateInfo(int repairId, int vehicleId, string repairType,string description,string cost,string repairDate,int serviceCenter,string status)
        {

            DBAccess db = new DBAccess();
            db.connect();

            
            string query = "UPDATE vehicle_repairs set cost = '"+cost+"', repairDate = '"+repairDate+"', serviceCenter = '"+serviceCenter+"', status = '"+status+"' WHERE repairId = '"+repairId+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void delete(int repairId)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "DELETE * FROM vehicle_repairs WHERE repairId='" + repairId + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void update(int repairId, int vehicleId, string repairType, string description, string cost, string repairDate, int serviceCenter, string status)
        {

            DBAccess db = new DBAccess();
            db.connect();


            string query = "UPDATE vehicle_repairs set repairId = '"+repairId+"', vehicleId = '"+vehicleId+"', repairType = '"+repairType+"' , description = '"+description+"' , cost = '"+cost+"', repairDate = '"+repairDate+"', serviceCenter = '"+serviceCenter+"', status = '"+status+"' WHERE repairId = '"+repairId+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public DataTable getVehicleServiceCenter()
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

                string query = "SELECT name FROM vehicle_servicecenter";

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

        /*
                private int VehicleRegNo;
                private String VehicleType;
                private int ModelNumber;
                private int EngineNumber;
                private DateTime Date;
                private String colour;

        */

        //public int VehicleRegNo1
        //{
        /* get
         {
             return VehicleRegNo;
         }

         set
         {
             VehicleRegNo = value;
         }
     }

     public string VehicleType1
     {
         get
         {
             return VehicleType;
         }

         set
         {
             VehicleType = value;
         }
     }

     public int ModelNumber1
     {
         get
         {
             return ModelNumber;
         }

         set
         {
             ModelNumber = value;
         }
     }

     public int EngineNumber1
     {
         get
         {
             return EngineNumber;
         }

         set
         {
             EngineNumber = value;
         }
     }

     public DateTime Date1
     {
         get
         {
             return Date;
         }

         set
         {
             Date = value;
         }
     }

     public string Colour
     {
         get
         {
             return colour;
         }

         set
         {
             colour = value;
         }
     }*/
        //}

    }
}
