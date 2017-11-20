using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace Factory_management
{
    class Bill
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public void insertBill(string type, string month, string unit, string amount, string billImage)
        {
            db.connect();

            string query = "INSERT INTO utilitybills (type, month, unit, billAmount, bill) VALUES (@type,@month,@unit,@amount,@bill)";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@bill", File.ReadAllBytes(billImage));
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public DataTable search_month(string month)
        {
            db.connect();
            string query = "SELECT * FROM utilitybills WHERE month =@month";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@month", month);
            MySqlDataReader dataReader = cmd.ExecuteReader();
           
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
        public DataTable searchBill(string month, string type)
        {
            db.connect();
            string query = "SELECT * FROM utilitybills WHERE month =@month AND type=@type";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@type", type);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
        void getbook(string bid)
        {
            db.connect();
            string query = "SELECT book FROM utilitybills WHERE billId =@bid";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@bid", bid);
            MySqlDataReader reader = cmd.ExecuteReader();
            //dt.Load(reader);
            if (reader.HasRows)
            {
                reader.Read();
               // pic.Image = blobToImage((byte[])(reader.GetValue(0)));
               // pic.Refresh();
                //paymentSlip_panel.Visible = true;
            }
            reader.Close();
            db.connection.Close();

            //return dt;

        }
        public Image blobToImage(byte[] byteArrayIn)
        {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }
    }
}
