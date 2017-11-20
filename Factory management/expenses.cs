using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Factory_management
{
    class expenses
    {
        DBAccess db = new DBAccess();
        public void InsertInfo(string transportId, string expenceType, string amount, string invoiceImg)
        {

            db.connect();
            // db.openConnect();
            string query = "INSERT INTO transport_expenses (transportId, expenseType, amount, invoice) VALUES (@transportId,@expenceType,@amount,@invoiceImg)";
            
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@transportId", transportId);
            cmd.Parameters.AddWithValue("@expenceType", expenceType);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@invoiceImg", invoiceImg);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void InsertInfoDelivery(string transportId, string expenceType, string amount, string invoiceImg)
        {

            db.connect();
            // db.openConnect();
            string query = "INSERT INTO delivery_schedule (deliveryId, Type, amount, invoice) VALUES (@transportId,@expenceType,@amount,@invoiceImg)";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@transportId", transportId);
            cmd.Parameters.AddWithValue("@expenceType", expenceType);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@invoiceImg", invoiceImg);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }



        public DataTable Searchdelivery ()
        {
            
            db.connect();

            DataTable dt = new DataTable();

            

            string query = "SELECT * FROM delivery_schedule";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.closeconnect();

            return dt;
        }
        public DataTable Searchgeneral()
        {

            db.connect();

            DataTable dt = new DataTable();



            string query = "SELECT * FROM transport_schedule";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }
        public DataTable Searchdelivery(string date)
        {

            db.connect();

            DataTable dt = new DataTable();



            string query = "SELECT * FROM delivery_schedule WHERE date=@date";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }
        public DataTable Searchgeneral(string date)
        {

            db.connect();

            DataTable dt = new DataTable();



            string query = "SELECT * FROM transport_schedule WHERE date=@date";


            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@date", date);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            //      dataReader.Close();
            //       db.connection.Close();

            return dt;
        }


        public DataTable getdetails1(string Vtype)
        {
            DBAccess db = new DBAccess();

            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM vehicle v,delschedule d,tshedule t WHERE Vtype = '" + Vtype + "'";

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

            string query = "SELECT * FROM vehicle WHERE regNo = '" + regNo + "'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }
    }
}
