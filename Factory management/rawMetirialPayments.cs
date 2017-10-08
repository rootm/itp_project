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
    public partial class rawMetirialPayments : Form
    {

        DBAccess db = new DBAccess();

        public rawMetirialPayments()
        {
            InitializeComponent();
        }

        void loadMaterial() {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();
                
                    cmd.CommandText = "SELECT Mname FROM material";
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                    materialType.Items.Add(login.GetString("Mname"));

                    }

             

                }



                db.closeconnect();



            
        }

        void searchSupplier(string dt,int materialType) {

            meterialOrder_grid.Rows.Clear();
            if (db.connect())
            {
                 MySqlCommand cmd = new MySqlCommand();
                if (materialType > 0)
                {
                    cmd.CommandText = "SELECT m.Mname,mo.MorderId,mo.quantity,mo.Odate,s.Sname,s.supid,s.Uprice FROM morder mo,material m,supplier s where mo.status='pending' AND mo.mid=@mid AND mo.Odate=@orderDate  AND s.supid=mo.supid AND m.mid=mo.mid;";
                    cmd.Parameters.AddWithValue("@orderDate", dt);
                    cmd.Parameters.AddWithValue("@mid", materialType);
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                        meterialOrder_grid.Rows.Add(login.GetString("MorderId"), login.GetString("Mname"), login.GetString("quantity"), login.GetString("Odate"), login.GetString("supid"), login.GetString("Sname"), login.GetString("Uprice"), login.GetString("Uprice"));

                    }

                }
                else {
                    cmd.CommandText = "SELECT m.Mname,mo.MorderId,mo.quantity,mo.Odate,s.supid,s.Sname,s.Uprice FROM morder mo,material m,supplier s where mo.status='pending' AND mo.Odate=@orderDate  AND s.supid=mo.supid AND m.mid=mo.mid;";
               //     cmd.Parameters.AddWithValue("@materialID", materialType);
                    cmd.Parameters.AddWithValue("@orderDate", dt);
                    
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                        meterialOrder_grid.Rows.Add(login.GetString("MorderId"), login.GetString("Mname"), login.GetString("quantity"), login.GetString("Odate"), login.GetString("supid"), login.GetString("Sname"), login.GetString("Uprice"), login.GetString("Uprice"));

                    }

                }



                db.closeconnect();



            }
        }

        void getSupplierDetails(string id,int qnt) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();
               
                    cmd.CommandText = "SELECT * FROM supplier  where supid=@supplierID";
                 //   cmd.Parameters.AddWithValue("@orderDate", dt);
                    cmd.Parameters.AddWithValue("@supplierID", id);
                    cmd.Connection = db.connection;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    //meterialOrder_grid.Rows.Add(login.GetString("MorderId"), login.GetString("Mname"), login.GetString("quantity"), login.GetString("Odate"), login.GetString("Sname"), login.GetString("Uprice"), login.GetString("Uprice"));
                    supplierID_label.Text = "Supplier ID             : " + reader.GetString("supid");
                    supplierName_label.Text= "Supplier Name      : " + reader.GetString("Sname");
                    supplierAccount_label.Text= "Supplier Account : " + reader.GetString("Sacc1");
                    unitPrice_label.Text = "Unit Price (LKR)     : " + reader.GetString("Uprice");
                    total_lable.Text= "Grand Total           : " + reader.GetInt32("Uprice")*qnt;

                }






                db.closeconnect();



            }
        }


        private void rawMetirialPayments_Load(object sender, EventArgs e)
        {
            loadMaterial();
            materialType.SelectedIndex = 0;
        }

        bool approveOrder(string orderID) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE morder SET status='approved' where MorderId=@id";
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.Connection = db.connection;
                

                int rows=cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }
                


            }



            db.closeconnect();
            return false;



        }
    



        private void search_Click(object sender, EventArgs e)
        {
            string date = orderDate.Value.ToString("yyyy-MM-dd");
         
            searchSupplier(date, materialType.SelectedIndex);
        }

        private void meterialOrder_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getSupplierDetails(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[4].Value.ToString(), Int32.Parse(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[2].Value.ToString()));
        }

        private void aproveButton_Click(object sender, EventArgs e)
        {

            if (approveOrder(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[0].Value.ToString())) {
                MessageBox.Show("sadasd");
                meterialOrder_grid.Rows.RemoveAt(meterialOrder_grid.SelectedRows[0].Index);
                meterialOrder_grid.Refresh();
            }
        }
    }
}
