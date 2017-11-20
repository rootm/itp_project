using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Factory_management
{
    class ServiceCenters
    {
       /* private String name;
        private string address;
        private int telephoneNo;
        private int contactNo;
        private String SpecializedMachine;
        */
        public void insertMachine(string name, string telephone, string address )
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "INSERT INTO machine_servicecenter (name,telephone,address) VALUES ('"+name+"','"+telephone+"','"+address+"' )";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void insertVehicle(string name, string telephone, string address)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "INSERT INTO vehicle_servicecenter (name,telephone,address) VALUES ('" + name + "','" + telephone + "','" + address + "' )";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void UpdateMachine(int serviceId,string name,string telephone ,string address)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE machine_servicecenter set centerId = '"+serviceId+"' , name = '"+name+"', telephone = '"+telephone+"', address = '"+address+"' WHERE centerId= '"+serviceId+"'";
            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
        }

        public void UpdateVehicle(int serviceId, string name, string telephone, string address)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE vehicle_servicecenter set centerId = '" + serviceId + "' , name = '" + name + "', telephone = '" + telephone + "', address = '" + address + "' WHERE centerId= '" + serviceId + "'";
            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
        }


        public void DeleteMachine(int center)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int scid;
            string query = "DELETE FROM machine_servicecenter WHERE centerId= '"+center+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void DeleteVehicle(int center)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int scid;
            string query = "DELETE FROM vehicle_servicecenter WHERE centerId= '" + center + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }
        public DataTable getdetailsx(int scid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM machine_servicecenter WHERE centerId= '"+scid+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }

        public DataTable getdetailsV(int scid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM vehicle_servicecenter WHERE centerId= '" + scid + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }


        public DataTable getdetailsx()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM machine_servicecenter";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }

        public DataTable getdetailsV()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM vehicle_servicecenter";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }
        /*internal DataTable getdetailsx(object scid)
        {
            throw new NotImplementedException();
        }*/






        /*  public string Name
          {
              get
              {
                  return name;
              }

              set
              {
                  name = value;
              }
          }

          public string Address
          {
              get
              {
                  return address;
              }

              set
              {
                  address = value;
              }
          }

          public int TelephoneNo
          {
              get
              {
                  return telephoneNo;
              }

              set
              {
                  telephoneNo = value;
              }
          }

          public int ContactNo
          {
              get
              {
                  return contactNo;
              }

              set
              {
                  contactNo = value;
              }
          }

          public string SpecializedMachine1
          {
              get
              {
                  return SpecializedMachine;
              }

              set
              {
                  SpecializedMachine = value;
              }
          }*/


    }
}
