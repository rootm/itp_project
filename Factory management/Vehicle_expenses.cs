using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class Vehicle_expenses : Form
    {


        DBAccess db = new DBAccess();
        public Vehicle_expenses()
        {
            InitializeComponent();
        }


        void transportDetails()
        {
            int deliveryTotal = 0;
            int transportTotal = 0;

            //try
            //{
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT SUM(de.amount),SUM(te.amount) FROM delivery_expenses de,transport_expenses te ";

                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                   
                    deliveryTotal = reader.GetInt32(0);
                    transportTotal = reader.GetInt32(1);


                }
                reader.Close();

                cmd.CommandText = "SELECT (SELECT COUNT(*) FROM  transport_schedule),(SELECT COUNT(*) FROM delivery_schedule) AS DUEL";

                MySqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {


                    numTransport.Text += " " + reader1.GetValue(0);
                    numDelivery.Text += " " + reader1.GetValue(1);


                }


                loadChart(transportTotal, deliveryTotal);



                db.closeconnect();



            }
        //}
        //catch (Exception)
        //{

        //  MessageBox.Show("error chart");            }

    
        }

        void loadChart(int trans,int del) {
            Func<ChartPoint, string> labelPoint = chartPoint =>
           string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Transport",
                    Values = new ChartValues<double> {trans},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Delivery",
                    Values = new ChartValues<double> {del},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },

            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        void loadExpences(string status) {
            vehicleExpenses_grid.Rows.Clear();
            listExpense_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT transportId,vehicleId,destination,date FROM transport_schedule WHERE status=@status";
                 cmd.Parameters.AddWithValue("@status", status.ToLower());
             //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    vehicleExpenses_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), "Travel", reader.GetValue(2), reader.GetValue(3));


                }






                db.closeconnect();

               

            }
        }

        void DeliveryExpences(string status)
        {
           // vehicleExpenses_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT t.deliveryId,t.vehicleId,t.date,ag.address FROM delivery_schedule t,agent_details ag,agent_orders od WHERE t.status=@status AND od.orderId=t.orderId AND ag.agentId=od.agentId";
                cmd.Parameters.AddWithValue("@status", status.ToLower());
                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    vehicleExpenses_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), "Delivery", reader.GetValue(3), reader.GetValue(2));


                }






                db.closeconnect();



            }
        }


        void expenseList(string transactionID,string type) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                if (type == "Travel")
                {
                    cmd.CommandText = "SELECT * FROM transport_expenses WHERE transportId=@id";
                }
                else if(type=="Delivery") {
                    cmd.CommandText = "SELECT * FROM delivery_expenses WHERE deliveryId=@id";
                }
               
                cmd.Parameters.AddWithValue("@id",transactionID);
                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    listExpense_grid.Rows.Add(reader.GetValue(0), reader.GetValue(2), reader.GetValue(3),"Not attached");


                }






                db.closeconnect();



            }
        }


        bool transactionStatus(string transactionID,string status,string type) {
            
                if (db.connect())
                {
                    MySqlCommand cmd = new MySqlCommand();

                if (type == "Travel")
                {
                    cmd.CommandText = "UPDATE transport_schedule SET status=@status where transportId=@id";
                }
                else if (type == "Delivery")
                {
                    cmd.CommandText = "UPDATE delivery_schedule SET status=@status where deliveryId=@id";
                }

               
                cmd.Parameters.AddWithValue("@id", transactionID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Connection = db.connection;


                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0) { return true; } else { return false; }



                }



                db.closeconnect();
                return false;



            
        }




        private void Vehicle_expenses_Load(object sender, EventArgs e)
        {
            //  loadExpences();
            transportDetails();


        }

        private void vehicleExpenses_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (vehicleExpenses_grid.SelectedRows.Count > 0)
            {
                //  getSupplierDetails(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[4].Value.ToString(), Int32.Parse(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[2].Value.ToString()));
                listExpense_grid.Rows.Clear();
                expenseList(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[2].Value.ToString());

                approve_button.Enabled = true;
                decline_button.Enabled = true;
            }
            else
            {
                approve_button.Enabled = false;
                decline_button.Enabled = false;
               
            }
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            
        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (status.SelectedIndex>-1) {
                loadExpences(status.SelectedItem.ToString());
               DeliveryExpences(status.SelectedItem.ToString());
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            if (transactionStatus(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString(),"declined",vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Decline Successful");
                vehicleExpenses_grid.Rows.RemoveAt(vehicleExpenses_grid.SelectedRows[0].Index);
                vehicleExpenses_grid.Refresh();
            }
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if (transactionStatus(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), "approved", vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Approve Successful");
                vehicleExpenses_grid.Rows.RemoveAt(vehicleExpenses_grid.SelectedRows[0].Index);
                vehicleExpenses_grid.Refresh();
            }
        }
    }
}
