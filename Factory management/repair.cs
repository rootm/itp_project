using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Factory_management
{
    class repair
    {
        DBAccess db = new DBAccess();
        public void InsertInfo(string vid, string type, string Rdec)
        {
            
            db.connect();
            
            string query = "INSERT INTO vehicle_repairs (vehicleId,repairType,description,status) VALUES ('" + vid + "','" + type + "','" + Rdec + "','requested')";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }

        public void UpdateInfo(int rrid, string regNo, string Vtype, int insNo, string insCompany, string Rtype, string Rdec)
        {

            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE vrepair set regNo = '" + regNo + "',Vtype = '" + Vtype + "',insNo = '" + insNo + "',insCompany = '" + insCompany + "',Rtype = '" + Rtype + "', repDesc = '" + Rdec + "', WHERE rrid = '" + rrid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void DeleteInfo(int repairId)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int vehicleid;
            string query = "DELETE FROM vrepair WHERE repairId = '" + repairId  + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();



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

            string query = "SELECT regNo,Vtype,model,EngineNo,pdate,colour FROM vehicle";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }

        public DataTable getdetails(string Vtype)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT regNo,Vtype,model,EngineNo,pdate,colour FROM vehicle WHERE Vtype = '" + Vtype + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;



        }


        public DataTable getdetails(int regNo)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT regNo,Vtype,model,EngineNo,pdate,colour FROM vehicle WHERE regNo = '" + regNo + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;






        }
    }
}
