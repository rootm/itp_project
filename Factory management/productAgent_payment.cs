using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class productAgent_payment : Form
    {

        DBAccess db = new DBAccess();

        public productAgent_payment()
        {
            InitializeComponent();
        }

        private void productAgent_payment_Load(object sender, EventArgs e)
        {

        }

        void searchAgentPayments(String date) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT * FROM atransaction WHERE payDate=@date";
                //   cmd.Parameters.AddWithValue("@orderDate", dt);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    orderPayment_grid.Rows.Add();
                  

                }






                db.closeconnect();



            }

        }

        void getSlip() {

        }

        Image blobToImage(byte[] byteArrayIn) {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string date = payDate.Value.ToString("yyyy-MM-dd");

            searchAgentPayments(date);
        }
    }
    }
}
