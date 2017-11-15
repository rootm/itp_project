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

        void loadExpences() {
            vehicleExpenses_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT tsId,vehicleId,destination,purpose,tDate,expenses FROM tshedule WHERE status=false";
                //   cmd.Parameters.AddWithValue("@orderDate", dt);
             //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    vehicleExpenses_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));


                }






                db.closeconnect();



            }
        }

        void expenseList(string transactionID) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT * FROM travel_expenses WHERE transportID=@id";
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


        bool approveTransaction(string transactionID) {
            
                if (db.connect())
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = "UPDATE tshedule SET status=true where tsId=@id";
                    cmd.Parameters.AddWithValue("@id", transactionID);
                    cmd.Connection = db.connection;


                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0) { return true; } else { return false; }



                }



                db.closeconnect();
                return false;



            
        }

        bool declineTransaction(string transactionID)
        {

            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE tshedule SET status=-1 where tsId=@id";
                cmd.Parameters.AddWithValue("@id", transactionID);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }



            db.closeconnect();
            return false;




        }


        private void Vehicle_expenses_Load(object sender, EventArgs e)
        {
            loadExpences();

            Func<ChartPoint, string> labelPoint = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void vehicleExpenses_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (vehicleExpenses_grid.SelectedRows.Count > 0)
            {
                //  getSupplierDetails(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[4].Value.ToString(), Int32.Parse(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[2].Value.ToString()));
                listExpense_grid.Rows.Clear();
                expenseList(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString());

                approve_button.Enabled = true;
                decline_button.Enabled = true;
            }
            else
            {
                approve_button.Enabled = true;
                decline_button.Enabled = true;
               
            }
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (approveTransaction(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Approve Successful");
                vehicleExpenses_grid.Rows.RemoveAt(vehicleExpenses_grid.SelectedRows[0].Index);
                vehicleExpenses_grid.Refresh();
            }
        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            if (declineTransaction(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Decline Successful");
                vehicleExpenses_grid.Rows.RemoveAt(vehicleExpenses_grid.SelectedRows[0].Index);
                vehicleExpenses_grid.Refresh();
            }
        }
    }
}
