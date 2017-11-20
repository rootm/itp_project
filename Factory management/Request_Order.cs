using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Factory_management 
{
    public partial class Request_Order : System.Windows.Forms.Form
    {
        public int id;

        Special_Orders o = new Special_Orders();
        DBAccess db = new DBAccess();


        string name = "";
        string type = "";
        int total = 0;

        public Request_Order()
        {
            InitializeComponent();
            Loadgrid();
        }
            void Loadgrid()
            
            {
                DataTable dt = o.getdetails();
               
                foreach (DataRow row in dt.Rows)
                {

                    orderGrid.Rows.Add(row.ItemArray);
                }
            }

        void LoadProductTypes()

        {
            DataTable dt = o.getProductType();

            foreach (DataRow row in dt.Rows)
            {

                comboBox1.Items.Add(row.ItemArray[0]);
            }
        }


        void Loadgrid15(int pid)
        {
            
               
                DataTable dt = o.getdetails15(pid);
                foreach (DataRow row in dt.Rows)
                {

                    orderGrid.Rows.Add(row.ItemArray);
                }
            
        }






        private void textBoxX6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Request_Order_Load(object sender, EventArgs e)
        {
            //LoadProductTypes();
            try
            {
                db.connect();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = "SELECT DISTINCT type FROM product_details";

                    //   cmd.Parameters.AddWithValue("@date", date);
                    cmd.Connection = db.connection;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        comboBox1.Items.Add(reader.GetValue(0));


                    }

                    db.closeconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            try
            {
                db.connect();
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT DISTINCT name FROM product_details";

                //   cmd.Parameters.AddWithValue("@date", date);
                cmd.Connection = db.connection;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    productName.Items.Add(reader.GetValue(0));


                }

                db.closeconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        int getProductDetails()
        {
            int id = -1;
            try
            {

                db.connect();
                

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = "SELECT * FROM product_details WHERE type=@type AND name=@name";

                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Connection = db.connection;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    productName.Items.Clear();
                    while (reader.Read())
                    {
                        orderGrid.Rows.Add(reader.GetInt32(0), reader.GetValue(1), reader.GetValue(2), quantity1.Text, reader.GetInt32(4) * Convert.ToInt32(quantity1.Text));
                        total += reader.GetInt32(4) * Convert.ToInt32(quantity1.Text);
                    }

                   db.closeconnect();

                    return 1;

          
            }
            catch (Exception ex)
            {
                return -1;

            }
            return id;

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        void loadgrid()
        {
            Special_Orders o = new Special_Orders();
            DataTable dt = o.getdetails();
            orderGrid.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

 

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {/*
            {
                DBAccess db = new DBAccess();

                Special_Orders o = new Special_Orders();
                int pid = Convert.ToInt32(product_type.Text);
                dataGridView1.Rows.Clear();
                Loadgrid15(pid);

            }*/
        }

        private void add_Click(object sender, EventArgs e)
        {

            int warning = 0;
            bool warning2 = false;



            if (!String.IsNullOrEmpty(pid1.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(pages1.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(quantity1.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(name_.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(address_.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(mobile_.Text))
            {
                warning++;
            }
            if ((!mobile_.Text.All(char.IsDigit)) || (mobile_.Text.Length != 10))
            {
                warning2 = true;
                MessageBox.Show("Invalid mobile number");
            }
            /////////////
            if (warning != 6)
            {
                MessageBox.Show("Fill Empty Fields");
            }
            if ((warning == 6) && (warning2 == false))
            {


                DialogResult dialogResult = MessageBox.Show("Do you really want to add details ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int pid = Convert.ToInt32(pid1.Text);
                    int pages = Convert.ToInt32(pages1.Text);
                    int quantity = Convert.ToInt32(this.quantity1.Text);
                    string name = name_.Text;
                    string address = address_.Text;
                    string mobile = mobile_.Text;

                    o.InsertInfo(pid,pages,quantity,name,address,mobile);
                    MessageBox.Show("Details has been added successfully", "confirmation");

                    orderGrid.Rows.Clear();
                    Loadgrid();

                    pid1.Text = null;
                    pages1.Text = null;
                    this.quantity1.Text = null;
                    name_.Text = null;
                    address_.Text = null;
                    mobile_.Text = null;

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel  ");
                }
            }
            }

        private void update_Click(object sender, EventArgs e)
        {

            DBAccess db = new DBAccess();
            Special_Orders o = new Special_Orders();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //set values
                    //int soid = id;

                    int soid = Convert.ToInt32(label4.Text);
                    int pid = Convert.ToInt32(pid1.Text);
                    int pages = Convert.ToInt32(pages1.Text);
                    int quantity = Convert.ToInt32(this.quantity1.Text);


                    string Socname = name_.Text;
                    string Soaddress = address_.Text;
                    string Somobile = mobile_.Text;


                    o.UpdateInfo(soid, pid, pages, quantity, Socname, Soaddress, Somobile);

                    orderGrid.Rows.Clear();
                    Loadgrid();

                    MessageBox.Show("Data Saved Successfully");

                    //clearDetails();

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel  ");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label4.Text = "Order ID";
            pid1.Text = null;
            pages1.Text = null;
            quantity1.Text = null;
            name_.Text = null;
            address_.Text = null;
            mobile_.Text = null;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label4.Text = orderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            pid1.Text = orderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            pages1.Text = orderGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            quantity1.Text = orderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            name_.Text = orderGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            address_.Text = orderGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            mobile_.Text = orderGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void show_Click(object sender, EventArgs e)
        {
            string productType = comboBox1.Text;
            string pname = productName.Text;

            int productID = o.getProductId(productType, pname);
            pid1.Text = Convert.ToString(productID);

            int pages = o.getPages(productType, pname);
            pages1.Text = Convert.ToString(pages);
        }



        /*
                private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }

                private void labelX6_Click(object sender, EventArgs e)
                {

                }

                private void buttonX4_Click(object sender, EventArgs e)
                {

                }*/

        //  private void buttonX3_Click (object sender, EventArgs e)





    }
}