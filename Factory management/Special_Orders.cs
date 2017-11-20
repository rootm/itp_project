using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Factory_management 
{
    class Special_Orders
    {

        DBAccess dba = new DBAccess();

        public DataTable getdetails()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM special_orders";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                   db.connection.Close();

            return dt;
        }

        public DataTable getdetails10()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM agent_orders";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                   db.connection.Close();

            return dt;
        }

        public DataTable getdetails1()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM product_stock";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                  db.connection.Close();

            return dt;
        }
        public DataTable getdetails2()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT a.orderId,a.agentId,o.productId,a.orderDate,a.total,a.status,o.quantity  FROM agent_orders a , agent_orderitems o WHERE a.orderId = o.orderId";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                dataReader.Close();
                db.connection.Close();

            return dt;
        }

        public DataTable getdetails3()
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT FROM special_orders";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

                  dataReader.Close();
                  db.connection.Close();

            

            return dt;
        }

        public DataTable getdetails4 (int aoid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT a.orderId,a.agentId,o.productId,a.orderDate,a.total,a.status,o.quantity  FROM agent_orders a , agent_orderitems o WHERE a.orderId = o.orderId  AND a.orderId = '"+aoid+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }


        public DataTable getProductDetails(int pid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM special_orders WHERE orderId = '" + pid + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getdetails5(String status)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT a.orderId,a.agentId,o.productId,a.orderDate,a.total,a.status,o.quantity  FROM agent_orders a , agent_orderitems o WHERE a.orderId = o.orderId AND a.status = '"+status+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

       

        public DataTable getdetails6 (String status)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT a.orderId,a.agentId,o.productId,a.orderDate,a.total,a.status,o.quantity FROM agent_orders a , agent_orderitems o  WHERE a.orderId=o.orderId AND a.status = '"+status+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getdetails7(int pid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM product_stock  WHERE productId = '" + pid+ "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

        public DataTable getdetails15 (int pid)
        {
            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM special_orders  WHERE productId = '" + pid+ "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }




        public void InsertInfo(int pid, int pages, int quantity, string Socname, string Soaddress, string Somobile)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "INSERT INTO special_orders(productId,pages,quantity,name,address,mobile,status)VALUES('" + pid + "','" + pages + "','" + quantity + "','" + Socname + "','" + Soaddress + "','" + Somobile + "', status = 'pending')";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }


        public void UpdateInfo( int soid,int pid, int pages, int quantity, string Socname, string Soaddress, string Somobile)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE special_orders set productId = '" + pid + "', pages = '" + pages + "',quantity = '" + quantity + "', name ='" + Socname + "',address= '" + Soaddress + "', mobile = '" + Somobile + "' WHERE  orderId = '" +soid +"'";
            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void DeleteInfo(int agentid)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //    int aoid;
            string query = "DELETE  FROM agent_orders WHERE agentId  = '" + agentid + "'AND status='cancel'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void updateStatus(string orderId,string status)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE agent_orders set status = '"+status+"' WHERE orderId='"+orderId+"'";
            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public DataTable getProductType()
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

                string query = "SELECT type FROM product_details";

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


        public int getProductId(string type,string name)
        {

            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT productId FROM product_details WHERE type = '"+type+"' AND name = '"+name+"' ";
                
                MySqlCommand cmd = new MySqlCommand(query, dba.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int pid = -1;
                if (reader.Read())
                {
                    pid = reader.GetInt32("productId");

                }
               


                dba.connection.Close();
                return pid;
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }

        }


        public int getPages(string type, string name)
        {

            dba.connect();
            try
            {

                if (dba.connection.State == ConnectionState.Closed)
                {
                    dba.connection.Open();
                }

                string query = "SELECT pages FROM product_details WHERE type = '" + type + "' AND name = '" + name + "' ";

                MySqlCommand cmd = new MySqlCommand(query, dba.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                int pages = -1;
                if (reader.Read())
                {
                    pages = reader.GetInt32("pages");

                }
                dba.connection.Close();
                return pages;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }

        }


        /*
                public void delete(string orderId)
                {
                    DBAccess db = new DBAccess();
                    db.connect();
                    string query = "DELETE agent_orders set status = '" + status + "' WHERE orderId='" + orderId + "'";
                    if (db.connection.State == System.Data.ConnectionState.Closed)
                    {
                        db.connection.Open();
                    }

                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    cmd.ExecuteNonQuery();

                }
                */
    }
}

