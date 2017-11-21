using MySql.Data.MySqlClient;
using System.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Factory_management 
{
    class distributeOrders
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public DataTable LoadGridAgentOrders ()
        {
            db.connect();

            string query = "SELECT a.orderId, a.productId, a.quantity FROM agent_orderitems a, agent_orders ao WHERE a.orderId = ao.orderId AND ao.status = 'approved'  ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;


        }
        public void UpdateInfoAgentOrders(int oid, int quantity, int productId)
        {
            db.connect();

            string query = "UPDATE agent_orders set status = 'release' WHERE orderId = '" + oid + "'";
            string query1 = "UPDATE product_stock set quantity = quantity - '" + quantity + "' WHERE productId = '" + productId + "' ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            db.closeconnect();

        }

        public DataTable LoadGridSpecialOrders()
        {
            db.connect();
            string query = "SELECT orderId, productId,quantity FROM special_orders WHERE status = 'approved' ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public void UpdateInfoSpecialOrders(int oid, int pid, int quantity)
        {
            db.connect();
            string query = "UPDATE special_orders set status = 'release' WHERE orderId = '" + oid + "'";
            string query1 = "UPDATE product_stock set quantity = quantity - '" + quantity + "' ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            db.closeconnect();
        }
    }
}
