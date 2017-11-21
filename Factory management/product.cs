using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Factory_management 
{
    class product
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public DataTable LoadGridNewproduct ()
        {
            db.connect();

            string query = "SELECT * FROM product_details ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public void InsertInfo(string type, string name, int pages, int price)
        {
            db.connect();

            string query = "INSERT INTO product_details (type, name, pages, price) VALUES ('" + type + "','" + name + "','" + pages + "','" + price + "');INSERT INTO product_stock(productId,quantity) VALUES (LAST_INSERT_ID(),0)";
            //string query1 = "INSERT INTO product_stock (quantity) VALUES ('0')";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            //MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd.ExecuteNonQuery();
            //cmd1.ExecuteNonQuery();
            db.closeconnect();
        }
        public DataTable LoadGridNewproductSearch(int pid)
        {
            db.connect();

            string query = "SELECT * FROM product_details WHERE productId = '"+pid+"' ";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            db.closeconnect();
            return dt;
        }
        public void UpdateInfo(int pid, string type, string name, int pages, int price)
        {
            db.connect();
            string query = "UPDATE product_details SET type = '" + type + "', name = '"+name+"', pages = '"+pages+"', price = '"+price+"' WHERE productId = '"+pid+"'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void DeleteInfo(int pid )
        {
            db.connect();
            string query = "DELETE FROM product_details WHERE productId = @pid ;DELETE FROM product_stock WHERE productId = @pid";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
            db.closeconnect();

        }
        public int getQuantity(int pid)
        {
            int count=-1;
            db.connect();

            string query = "SELECT quantity FROM product_stock WHERE productId = @pid ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@pid", pid);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                 count = dataReader.GetInt32(0);
            }
            
            return count ;
        }

    }
}
