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
                
                    cmd.CommandText = "SELECT materialName FROM material_details";
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                    materialType.Items.Add(login.GetString("materialName"));

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
                    cmd.CommandText = "SELECT m.materialName,mo.orderId,mo.quantity,mo.orderDate,mo.cost,s.supplierId,s.name,sm.unitPrice FROM material_orders mo,material_details m,supplier_details s,supplier_material sm where mo.status='pending' AND s.supplierId=mo.supplierId AND m.materialId=mo.materialId AND sm.materialId=mo.materialId AND sm.supplierId=mo.supplierId AND mo.orderDate=@orderDate AND mo.materialId=@mid";
                    cmd.Parameters.AddWithValue("@orderDate", dt);
                    cmd.Parameters.AddWithValue("@mid", materialType);
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                        meterialOrder_grid.Rows.Add(login.GetString("orderId"), login.GetString("materialName"), login.GetString("quantity"), login.GetString("orderDate"), login.GetString("supplierId"), login.GetString("name"), login.GetString("unitPrice"), login.GetString("cost"));

                    }

                }
                else {
                    cmd.CommandText = "SELECT m.materialName,mo.orderId,mo.quantity,mo.orderDate,mo.cost,s.supplierId,s.name,sm.unitPrice FROM material_orders mo,material_details m,supplier_details s,supplier_material sm where mo.status='pending' AND s.supplierId=mo.supplierId AND m.materialId=mo.materialId AND sm.materialId=mo.materialId AND sm.supplierId=mo.supplierId AND mo.orderDate=@orderDate";
                    //     cmd.Parameters.AddWithValue("@materialID", materialType);
                    cmd.Parameters.AddWithValue("@orderDate", dt);
                    
                    cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                        meterialOrder_grid.Rows.Add(login.GetString("orderId"), login.GetString("materialName"), login.GetString("quantity"), login.GetString("orderDate"), login.GetString("supplierId"), login.GetString("name"), login.GetString("unitPrice"), login.GetString("cost"));

                    }

                }



                db.closeconnect();



            }
        }

        void allSupplier()
        {

            meterialOrder_grid.Rows.Clear();
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT m.materialName,mo.orderId,mo.quantity,mo.orderDate,s.supplierId,s.name,sm.unitPrice,mo.cost FROM material_orders mo,material_details m,supplier_details s,supplier_material sm where mo.status='pending' AND s.supplierId=mo.supplierId AND m.materialId=mo.materialId AND sm.materialId=mo.materialId AND sm.supplierId=mo.supplierId;";

                cmd.Connection = db.connection;
                    MySqlDataReader login = cmd.ExecuteReader();
                    while (login.Read())
                    {

                        meterialOrder_grid.Rows.Add(login.GetString("orderId"), login.GetString("materialName"), login.GetString("quantity"), login.GetString("orderDate"), login.GetString("supplierId"), login.GetString("name"), login.GetString("unitPrice"), login.GetString("cost"));

                    }

                }
               

                



                db.closeconnect();



            
        }

        void getSupplierDetails(string id,int qnt) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();
               
                    cmd.CommandText = "SELECT * FROM supplier_details  where supplierId=@supplierID";
                 //   cmd.Parameters.AddWithValue("@orderDate", dt);
                    cmd.Parameters.AddWithValue("@supplierID", id);
                    cmd.Connection = db.connection;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    //meterialOrder_grid.Rows.Add(login.GetString("MorderId"), login.GetString("Mname"), login.GetString("quantity"), login.GetString("Odate"), login.GetString("Sname"), login.GetString("Uprice"), login.GetString("Uprice"));
                    supplierID_label.Text = "Supplier ID             : " + reader.GetString("supplierId");
                    supplierName_label.Text= "Supplier Name      : " + reader.GetString("name");
                    supplierAccount_label.Text= "Supplier Account : " + reader.GetString("account1");
                    unitPrice_label.Text = "Unit Price (LKR)     : " + meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[6].Value.ToString();
                    total_lable.Text= "Grand Total           : " + meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[7].Value.ToString();

                }






                db.closeconnect();



            }
        }


        private void rawMetirialPayments_Load(object sender, EventArgs e)
        {
            loadMaterial();
            materialType.SelectedIndex = 0;
        }

        bool approveOrder(string orderID,int status) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                if (status == 0)
                {
                    cmd.CommandText = "UPDATE material_orders SET status='approved' where orderId=@id";
                }
                else if(status==1)
                {
                    cmd.CommandText = "UPDATE material_orders SET status='declined' where orderId=@id";
                }
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.Connection = db.connection;
                

                int rows=cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }
                


            }



            db.closeconnect();
            return false;



        }
    



   

 


     

        private void meterialOrder_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (meterialOrder_grid.SelectedRows.Count > 0)
            {
                getSupplierDetails(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[4].Value.ToString(), Int32.Parse(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[2].Value.ToString()));

                approve.Enabled = true;
                decline.Enabled = true;
            }
            else {
                approve.Enabled = false;
                decline.Enabled = false;
                supplierID_label.Text = "Supplier ID             : " ;
                supplierName_label.Text = "Supplier Name      : " ;
                supplierAccount_label.Text = "Supplier Account : " ;
                unitPrice_label.Text = "Unit Price (LKR)     : ";
                total_lable.Text = "Grand Total           : ";
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string date = orderDate.Value.ToString("yyyy-MM-dd");

            searchSupplier(date, materialType.SelectedIndex);
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            allSupplier();
        }

        private void approve_Click(object sender, EventArgs e)
        {
            if (approveOrder(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[0].Value.ToString(),0))
            {
                MessageBox.Show("Approve Successful");
                meterialOrder_grid.Rows.RemoveAt(meterialOrder_grid.SelectedRows[0].Index);
                meterialOrder_grid.Refresh();
            }
        }

        private void decline_Click(object sender, EventArgs e)
        {
            if (approveOrder(meterialOrder_grid.Rows[meterialOrder_grid.SelectedRows[0].Index].Cells[0].Value.ToString(), 1))
            {
                MessageBox.Show("Decline Successful");
                meterialOrder_grid.Rows.RemoveAt(meterialOrder_grid.SelectedRows[0].Index);
                meterialOrder_grid.Refresh();
            }
        }
    }
}
