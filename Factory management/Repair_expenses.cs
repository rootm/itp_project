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
    public partial class Repair_expenses : Form
    {
        DBAccess db = new DBAccess();

        public Repair_expenses()
        {
            InitializeComponent();
        }

        void repairtDetails()
        {
            int machineTotal = 0;
            int vehicleTotal = 0;

            //try
            //{
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT SUM(mr.cost),SUM(vr.cost) FROM machine_repairs mr,vehicle_repairs vr ";

                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    machineTotal = reader.GetInt32(0);
                    vehicleTotal = reader.GetInt32(1);


                }
                reader.Close();

                cmd.CommandText = "SELECT (SELECT COUNT(*) FROM  machine_repairs),(SELECT COUNT(*) FROM vehicle_repairs) AS DUEL";

                MySqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {


                    numMachine.Text += " " + reader1.GetValue(0);
                    numVehicles.Text += " " + reader1.GetValue(1);


                }


                loadChart(machineTotal, vehicleTotal);



                db.closeconnect();



            }
            //}
            //catch (Exception)
            //{

            //  MessageBox.Show("error chart");            }


        }

        void loadChart(int machine, int vehicle)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
           string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Machine",
                    Values = new ChartValues<double> {machine},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Vehicle",
                    Values = new ChartValues<double> {vehicle},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },

            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }


        void expenseDetails(string transactionID, string type)
        {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                if (type == "Machine")
                {
                    cmd.CommandText = "SELECT 	mr.cost,ms.name FROM machine_servicecenter ms,machine_repairs mr WHERE ms.centerId=mr.serviceCenter AND mr.repairId=@id";
                }
                else if (type == "Vehicle")
                {
                    cmd.CommandText = "SELECT 	mr.cost,ms.name FROM vehicle_servicecenter ms,vehicle_repairs mr WHERE ms.centerId=mr.serviceCenter AND mr.repairId=@id";
                }


                cmd.Parameters.AddWithValue("@id", transactionID);
                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    serviceCenter_label.Text = "Service Center      :" + reader.GetValue(1);
                    repairCost_label.Text = "Repair Cost            : " + reader.GetValue(0); 

                }


            }



            db.closeconnect();

        }

            
        

   

        bool transactionStatus(string repairId, string status, string type)
        {

            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                if (type == "Machine")
                {
                    cmd.CommandText = "UPDATE machine_repairs SET status=@status where repairId=@id";
                }
                else if (type == "Vehicle")
                {
                    cmd.CommandText = "UPDATE vehicle_repairs SET status=@status where repairId=@id";
                }


                cmd.Parameters.AddWithValue("@id", repairId);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }



            db.closeconnect();
            return false;




        }

        void machineRepairs(string status) {
            repairDetails_grid.Rows.Clear();
            //expenseList_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT repairId,machineId,repairDate,description FROM machine_repairs WHERE status=@status";
                cmd.Parameters.AddWithValue("@status", status.ToLower());
                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    repairDetails_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), "Machine", reader.GetValue(2), reader.GetValue(3));


                }

                
                db.closeconnect();



            }
        }

        void vehicleRepairs(string status)
        {
            
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT repairId,vehicleId,repairDate,description FROM vehicle_repairs WHERE status=@status";
                cmd.Parameters.AddWithValue("@status", status.ToLower());
                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    repairDetails_grid.Rows.Add(reader.GetValue(0), reader.GetValue(1), "Vehicle", reader.GetValue(2), reader.GetValue(3));


                }


                db.closeconnect();



            }
        }

        



        private void Repair_expenses_Load(object sender, EventArgs e)
        {

            repairtDetails();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (status.SelectedIndex > -1)
            {
                machineRepairs(status.SelectedItem.ToString());
                vehicleRepairs(status.SelectedItem.ToString());
            }
        }

        private void repairDetails_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (repairDetails_grid.SelectedRows.Count > 0)
            {
                //  getSupplierDetails(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[4].Value.ToString(), Int32.Parse(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[2].Value.ToString()));
                // expenseList_grid.Rows.Clear();
                //expenseList(vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), vehicleExpenses_grid.Rows[vehicleExpenses_grid.SelectedRows[0].Index].Cells[2].Value.ToString());
                expenseDetails(repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[2].Value.ToString());
                approveButton.Enabled = true;
                declineButton.Enabled = true;
            }
            else
            {
                approveButton.Enabled = false;
                declineButton.Enabled = false;

            }
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if (transactionStatus(repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), "approved", repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Approve Successful");
                repairDetails_grid.Rows.RemoveAt(repairDetails_grid.SelectedRows[0].Index);
                repairDetails_grid.Refresh();
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            if (transactionStatus(repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), "declined", repairDetails_grid.Rows[repairDetails_grid.SelectedRows[0].Index].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Decline Successful");
                repairDetails_grid.Rows.RemoveAt(repairDetails_grid.SelectedRows[0].Index);
                repairDetails_grid.Refresh();
            }
        }
    }
}
