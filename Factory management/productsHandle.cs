using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Factory_management 
{
    class productsHandle
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public DataTable loadgrid()
        {
            db.connect();
            string query = "SELECT pd.productId, pd.type, pd.name, pd.pages, ps.quantity  FROM product_stock ps, product_details pd WHERE ps.productId = pd.productId ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
       
        public void updateinfo(int pid, int quantity)
        {
            db.connect();
            string query = "UPDATE product_stock set quantity = quantity + ('" + quantity + "') WHERE productId = '" + pid + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void updateinfoMaterial (int mid, int quantity)
        {
            db.connect();
            string query = "UPDATE material_stock set quantity = quantity - ('" + quantity + "') WHERE materialId = '" + mid + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
    }
}
