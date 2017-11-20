using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Factory_management
{
    class machineRepairs
    {
        /* private int machineNo;
         private String machineType;
         private DateTime WarrentyDate;
         private double Price;
         private String company;
         private String Address;
         private int TelephoneNo;*/

        DBAccess dba = new DBAccess();

        public int getServiceCenterID(string serviceCenter)
        {

            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT centerId FROM machine_servicecenter WHERE name = '"+serviceCenter+"'";

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


        public void insertMachine(int machineNo,int serviceCenter,string repairdate,string description,string cost,string status)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "INSERT INTO machine_repairs (machineId,serviceCenter,repairDate,description,cost,status) VALUES ('"+machineNo+"','"+serviceCenter+"','"+repairdate+"','"+description+"','"+cost+"','"+status+"' )";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void update(int repairId,int machineNo, int serviceCenter, string repairdate, string description, string cost, string status)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE machine_repairs SET machineId = '"+machineNo+"',serviceCenter = '"+serviceCenter+"',repairDate = '"+repairdate+"',description = '"+description+"',cost = '"+cost+"',status = '"+status+"' WHERE repairId = '"+repairId+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void updateStatus(int repairId, string status)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE machine_repairs SET status = '"+status+"' WHERE repairId = '"+repairId+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void delete(int repairId)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "DELETE * FROM machine_repairs WHERE repairId='"+repairId+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public DataTable getMachineServiceCenter()
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

                string query = "SELECT name FROM machine_servicecenter";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                //      dataReader.Close();
                //       db.connection.Close();

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable getMachineRepairDetails()
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

                string query = "SELECT repairId,machineId,serviceCenter,repairDate,description,cost,status FROM machine_repairs ";

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
        /*  public int MachineNo
          {
              get
              {
                  return machineNo;
              }

              set
              {
                  machineNo = value;
              }
          }

          public string MachineType
          {
              get
              {
                  return machineType;
              }

              set
              {
                  machineType = value;
              }
          }

          public DateTime WarrentyDate1
          {
              get
              {
                  return WarrentyDate;
              }

              set
              {
                  WarrentyDate = value;
              }
          }

          public double Price1
          {
              get
              {
                  return Price;
              }

              set
              {
                  Price = value;
              }
          }

          public string Company
          {
              get
              {
                  return company;
              }

              set
              {
                  company = value;
              }
          }

          public string Address1
          {
              get
              {
                  return Address;
              }

              set
              {
                  Address = value;
              }
          }

          public int TelephoneNo1
          {
              get
              {
                  return TelephoneNo;
              }

              set
              {
                  TelephoneNo = value;
              }
          }*/
    }
}
