using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Factory_management
{
    public partial class supplierMaterial_orders : Form
    {
        public supplierMaterial_orders()
        {
            InitializeComponent();
        }
        string mid;
        string qty;
        string oid;
        string oid1;
        string supid1;
        string oid2;
        ///////
        string matid2;
        string quantity;
        string orderdate;
        string supplierid;
        string cost;

        string mattype;
        string matname;
        string name;
        string address;
        string mobileNo;
        string emailid;

       


        public void clearlabel()
        {
            labelX1.Text = "";
            labelX2.Text = "";
            labelX3.Text = "";
        }

        public void displayall2()
        {
            DBAccess db = new DBAccess();
            db.connect();
            string query = "select * from material_orders where status ='requested'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX1.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();

            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }



        public void upeditapprovel()
        {
            DBAccess db = new DBAccess();
            db.connect();

            string query3 = "UPDATE material_orders SET supplierId =@supid,cost=@cost,status='pending' WHERE orderId ='" + oid + "'";

            MySqlCommand cmd = new MySqlCommand(query3, db.connection);
            cmd.Parameters.AddWithValue("@supid", comboBox4.Text);
            cmd.Parameters.AddWithValue("@cost", labelX3.Text);
            try
            {
                clearlabel();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                displayall2();
                db.closeconnect();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void supplierMaterial_orders_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            try
            {
                string query = "select distinct materialName from material_details";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    this.comboBox3.Items.Add(dr[0]);
                    this.comboBox2.Items.Add(dr[0]);


                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void buttonX11_Click(object sender, EventArgs e)
        {

        }




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
       

       

      

        private void comboBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            db.connect();
            try
            {
                string query = "select *  from supplier_details where supplierId='" + comboBox4.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
                cmd1.ExecuteNonQuery();
                MySqlDataReader DR = cmd1.ExecuteReader();

                while (DR.Read())
                {
                    labelX1.Text = DR["name"].ToString();
                    labelX2.Text = DR["address"].ToString();

                }
                DR.Close();

                string query1 = "select unitPrice  from supplier_material where supplierId='" + comboBox4.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query1, db.connection);
                cmd1.ExecuteNonQuery();
                MySqlDataReader DR1 = cmd2.ExecuteReader();

                while (DR1.Read())
                {
                    int s1 = Convert.ToInt32(DR1["unitPrice"].ToString());
                    int s2 = Convert.ToInt32(qty);
                    labelX4.Text = DR1["unitPrice"].ToString();
                    labelX3.Text = Convert.ToString(s1 * s2);


                }
                DR1.Close();
                db.closeconnect();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

       
      



     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            DBAccess db = new DBAccess();
            db.connect();
            string query = "select * from material_orders where status='approved'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX2.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker3.Text;
            DBAccess db = new DBAccess();
            db.connect();
            try
            {
                string query = "select * from material_orders where orderDate='" + date + "' AND materialId=(select materialId from material_details where materialName='"+ comboBox3.Text+ " ') AND status='approved'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
            
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX2.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            email e1 = new email(emailid);
            e1.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DBAccess db = new DBAccess();
            db.connect();
            
            string query = "select * from material_orders where orderDate='" + date + "' and status='pending'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX3.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            db.connect();
            
            string query = "select * from material_orders where status='pending'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX3.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            DBAccess db = new DBAccess();
            db.connect();
            try
            {
                string query = "select * from material_orders where orderDate='" + theDate + "' AND materialId=(select materialId from material_details where materialName='" + comboBox2.Text + " ') AND status = 'requested'";

            MySqlCommand cmd1 = new MySqlCommand(query, db.connection);
            cmd1.ExecuteNonQuery();
           
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX1.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayall2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
            panel3.Hide();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Hide();
            panel2.Show();
            panel2.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Hide();
            panel3.Show();
            panel3.BringToFront();

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mid = dataGridViewX1.Rows[e.RowIndex].Cells["materialId"].Value.ToString();
                qty = dataGridViewX1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                oid = dataGridViewX1.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
                comboBox4.Items.Clear();
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect();
                string query = "select  distinct supplierId from supplier_material where materialId='" + mid + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    comboBox4.Items.Add(DR[0]);

                }
                db.closeconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewX13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewX1_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            upeditapprovel();
            
        }

        private void dataGridViewX3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridViewX3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBAccess db = new DBAccess();
            db.connect();
            oid1 = dataGridViewX3.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
            supid1 = dataGridViewX3.Rows[e.RowIndex].Cells["supplierId"].Value.ToString();

            string query1 = "   select * from supplier_details where supplierId='" + supid1 + "'";
            MySqlCommand cmd2 = new MySqlCommand(query1, db.connection);
            cmd2.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd2;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX4.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void materialinvoice1_InitReport(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewX2.SelectedRows.Count>0)
            { 
            new invoiceviewer(oid2,matid2,quantity,orderdate,supplierid,cost,mattype,matname,name,address,mobileNo,emailid).ShowDialog();
            }
            
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            oid2 = dataGridViewX2.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
            matid2 = dataGridViewX2.Rows[e.RowIndex].Cells["materialId"].Value.ToString();
            quantity = dataGridViewX2.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            orderdate = dataGridViewX2.Rows[e.RowIndex].Cells["orderDate"].Value.ToString();
            supplierid = dataGridViewX2.Rows[e.RowIndex].Cells["supplierId"].Value.ToString();
            cost = dataGridViewX2.Rows[e.RowIndex].Cells["cost"].Value.ToString();



            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query = "select  *  from material_details where materialId='" + matid2 + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                mattype = DR["materialType"].ToString();
                matname = DR["materialName"].ToString();
            }
            DR.Close();
            string query1 = "select *  from supplier_details where supplierId='" + supplierid + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd1.ExecuteNonQuery();
            MySqlDataReader DR1 = cmd1.ExecuteReader();

            while (DR1.Read())
            {
                name = DR1["name"].ToString();
                address = DR1["address"].ToString();
                mobileNo = DR1["mobileNo"].ToString();
                emailid = DR1["email"].ToString();
            }
            DR1.Close();

            ///calculate unitprice/////
            int unitprice = (Convert.ToInt32(cost) / Convert.ToInt32(quantity));
            
            /////print the labels///
            labelX5.Text = supplierid;
            labelX6.Text = name;
            labelX7.Text = address;
            labelX8.Text = unitprice.ToString();
            labelX9.Text = cost;




        }

          

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}