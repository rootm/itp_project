using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Factory_management
{
    class Machine
    {/*
        private int MachineNo;
        private String MachineType;
        private DateTime PurchaseDate;
        private DateTime warrentyDate;
        private double price;
        private String company;
        private String Address;
        private int telephoneNo;
        */


        public void insert(string type,string purchaseDate,string warrentydate,string price,string company,string address,string telephone, string image ,string status)
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();

                string query = "INSERT INTO machine_details (type,purchaseDate,warratyDate,price,company,address,telephone,machineImg,status) VALUES ('" + type + "', '" + purchaseDate + "', '" + warrentydate + "', '" + price + "','" + company + "', '" + address + "', '" + telephone + "' , @file ,'"+status+"')";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(image));
                cmd.ExecuteNonQuery();
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void UpdateInfo(int machineid, string type, string purchaseDate, string warrentydate, string price, string company, string address, string telephone, string image)
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();

                string query = "UPDATE machine_details set type = '" + type + "', purchaseDate = '" + purchaseDate + "', warratydate= '" + warrentydate + "', price = '" + price + "', company ='" + company + "', address ='" + address + "', telephone = '" + telephone + "', machineImg =@img WHERE machineId = '" + machineid + "'";

                if (db.connection.State == System.Data.ConnectionState.Closed)
                {
                    db.connection.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@img",File.ReadAllBytes(image));
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteInfo(int mid)
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();

                //    int mid;
                string query = "DELETE FROM machine_details WHERE machineId = '"+mid+"'";

                if (db.connection.State == System.Data.ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable getdetailsx(int mid)
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

                string query = "SELECT machineId, type, purchaseDate, warratyDate, price, company, address, telephone, machineImg, status FROM machine_details WHERE machineId= '"+mid+"'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                //      dataReader.Close();
                //       db.connection.Close();

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable getdetailsx()
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

                string query = "SELECT machineId, type, purchaseDate, warratyDate, price, company, address, telephone,machineImg , status FROM machine_details ";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                //      dataReader.Close();
                //       db.connection.Close();

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        /*
        public void update(String MachineType, string purchaseDate, string warrentyDate, double price, string company, string Address, int telephone)
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "UPDATE machine (machinetype, Date, warrentydate, price, company, address, mobile) VALUES ('" + MachineType + "', '" + PurchaseDate + "', '" + warrentyDate + "', '" + price + "', '" + company + "', '" + Address + "', '" + telephoneNo + "')";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        */
        /* public int MachineNo1
         {
             get
             {
                 return MachineNo;
             }

             set
             {
                 MachineNo = value;
             }
         }

         public string MachineType1
         {
             get
             {
                 return MachineType;
             }

             set
             {
                 MachineType = value;
             }
         }

         public DateTime PurchaseDate1
         {
             get
             {
                 return PurchaseDate;
             }

             set
             {
                 PurchaseDate = value;
             }
         }

         public DateTime WarrentyDate
         {
             get
             {
                 return warrentyDate;
             }

             set
             {
                 warrentyDate = value;
             }
         }

         public double Price
         {
             get
             {
                 return price;
             }

             set
             {
                 price = value;
             }
         }

         public string Company
         {
             get
             {
                 return company;
             }

             set
             {
                 company = value;
             }
         }

         public string Address1
         {
             get
             {
                 return Address;
             }

             set
             {
                 Address = value;
             }
         }

         public int TelephoneNo
         {
             get
             {
                 return telephoneNo;
             }

             set
             {
                 telephoneNo = value;
             }
         }*/
    }
}
