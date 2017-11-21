using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace Factory_management 
{
    class Material
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        

        public void UpdateInfo( int quantity, int supId,int mid)
        {
            db.connect();

           
            string query = "UPDATE material_stock set materialId = '" + mid + "', supplierId = '" + supId + "', quantity = '" + quantity + "' WHERE materialId = '" + mid + "' AND supplierId = '" + supId + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }
        public void DeleteInfo(int mid, int supId)
        {
            db.connect();

            string query = "DELETE FROM material_stock WHERE materialId = '" + mid + "' AND supplierId = '" + supId + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }
        public DataTable LoadGrid()
        {
            db.connect();

            string query = "SELECT * FROM material_stock ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;

            
        }
        public DataTable LoadGridS(int mid )
        {
            db.connect();

            string query = "SELECT * FROM material_stock WHERE materialId = '" + mid + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;

            
        }
        public DataTable LoadGridmaterialRecode()
        {
            db.connect();

            string query = "SELECT * FROM material_orders  where status = 'approved'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public void updateinfoMaterial(int mid, int quantity, int orderId )
        {
            db.connect();
            //string query = "INSERT INTO meterial_stock (meterialId,quantity) VALUES ('" + mid + "','" + quantity + "')";
            string query = "UPDATE material_stock SET  quantity = quantity + @quantity  WHERE materialId = @mid ; UPDATE material_orders SET status = 'received' WHERE orderId = @orderId";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public DataTable loadgridMaterialStock()
        {
            db.connect();
            string query = "select  materialId, quantity from material_stock ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public int InsertInfoMaterialorders(int mid, int quantity, string Odate)
        {
            int rows;
            db.connect();
            string query = "INSERT INTO material_orders (materialId, quantity, orderDate) VALUES ('" + mid + "','" + quantity + "','" + Odate + "')";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            rows=cmd.ExecuteNonQuery();
            db.closeconnect();
            return rows;
        }

    }
}
