using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Factory_management
{
    class vehicle
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public void InsertInfo(string regNo, string Vtype, string model, string EngineNo, string pdate, double price, string insNo, string insCompany, double insAmount, string insEnddate,string book)
        {
            try
            {


                db.connect();

                string query = "INSERT INTO vehicle_details (registrationNo, vehicleType, model, engineNo, purchaseDate, price, insuranceNo, insuranceCompany, insuranceAmount, insuranceEnd, book, status) VALUES ('" + regNo + "','" + Vtype + "','" + model + "','" + EngineNo + "','" + pdate + "','" + price + "','" + insNo + "','" + insCompany + "','" + insAmount + "','" + insEnddate + "',@file,1)";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@file",File.ReadAllBytes(book));
                cmd.ExecuteNonQuery();
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateInfo(int vid, string regNo, string Vtype, string model, string EngineNo, string pdate, int price, string insNo, string insCompany, int insAmount, string insEnddate,string book)
        {

            
            db.connect();

            
            string query = "UPDATE vehicle_details set registrationNo = '" + regNo + "', vehicleType = '" + Vtype + "', model = '" + model + "', engineNo = '" + EngineNo + "', purchaseDate = '" + pdate + "', price = '" + price + "', insuranceNo = '" + insNo + "', insuranceCompany = '" + insCompany + "', insuranceAmount = '" + insAmount + "', insuranceEnd = '" + insEnddate + "', book = @file WHERE vehicleId = '" + vid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(book));
            cmd.ExecuteNonQuery();
            db.closeconnect();

        }

        public void DeleteInfo(int vid)
        {

            
            db.connect();

            
            string query = "DELETE FROM vehicle_details WHERE vehicleId = '" + vid + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

            db.closeconnect();
        }
        public Image blobToImage(byte[] byteArrayIn)
        {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }

        public DataTable getdetails()
        {
            db.connect();
            string query = "SELECT * FROM vehicle_details";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.connection.Close();
            return dt;
        }

        public DataTable getdetails(string regNo)
        {
            db.connect();                   
            string query = "SELECT * FROM vehicle_details WHERE registrationNo = '" + regNo + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dt.Load(dataReader);
            dataReader.Close();
            db.closeconnect();
            return dt;
        }
       



    }

}
