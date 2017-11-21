using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Factory_management 
{
    class MaterialNewClass
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();

        public void insertinfo(string Mtype, string Mname)
        {
            db.connect();

            string query = "INSERT INTO material_details (materialtype, materialName) VALUES ('" + Mtype + "','" + Mname + "'); INSERT INTO material_stock (materialId,quantity) VALUES (LAST_INSERT_ID(),0)";
           // string query1 = "";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void updateinfo(string mid, string Mtype, string Mname)
        {
            db.connect();
            string query = "UPDATE material_details set materialType = '" + Mtype + "', materialName = '" + Mname + "' WHERE materialId = '" + mid + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void deleteinfo(string mid)
        {
            db.connect();
            string query = "DELETE FROM material_details WHERE materialId = '" + mid + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public DataTable loadgrid()
        {
            db.connect();
            string query = "SELECT * FROM material_details ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public DataTable loadgridSearch(string materialId)
        {
            db.connect();
            string query = "SELECT * FROM material_details WHERE materialId=@materialId ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@materialId", materialId);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
    }
}
