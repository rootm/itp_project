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

    public partial class supplierManagement : Form
    {
        public supplierManagement()
        {
            InitializeComponent();
        }


        int mid;
        int materialid;
        int materialid1;
        int supplierid;

        public void displaybyname()
        {
            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query1 = "select * from supplier_details where name like '" + textBox25.Text + "%'";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
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



        public void displaybyid()
        {

            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query1 = "select * from supplier_details where supplierId='" + textBox36.Text + "'";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
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


        public void displaybymaterial()
        {
            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query1 = "   select d.* from supplier_material s,supplier_details d  where s.materialId = (select materialid from material_details where materialName = '" + comboBox5.Text + "') and s.supplierId=d.supplierId";
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
                dataGridViewX1.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();

            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        public void clearfield()
        {
            textBox2.Text = string.Empty;
            textBox23.Text = string.Empty;
            textBox32.Text = string.Empty;
            textBox24.Text = string.Empty;
            textBox35.Text = string.Empty;
            textBox19.Text = string.Empty;
            textBox20.Text = string.Empty;
            textBox21.Text = string.Empty;
            textBox22.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox16.Text = string.Empty;
            comboBox3.SelectedIndex = -1;
        }



        public void  updatetable()
        {
            validation v1 = new validation();
            if (v1.checkEmptyField(textBox23.Text, textBox32.Text, textBox24.Text, textBox35.Text,comboBox3.Text, textBox19.Text, textBox20.Text, textBox21.Text, textBox22.Text, textBox17.Text, textBox15.Text) && v1.isText(textBox19.Text, textBox17.Text, textBox14.Text) && v1.IsValidEmail(textBox22.Text))
            {
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect();
                string query = "UPDATE supplier_details SET name =@name,address=@add,city=@city,postalCode=@postc,country=@country,person=@person,mobileNo=@mobile,faxNo=@fax,email=@email,bank1=@bank1,account1=@acc1,bank2=@bank2,account2=@acc2 WHERE supplierId ='" + textBox2.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@name", textBox23.Text);
                cmd.Parameters.AddWithValue("@add", textBox32.Text);
                cmd.Parameters.AddWithValue("@city", textBox24.Text);
                cmd.Parameters.AddWithValue("@postc", textBox35.Text);
                cmd.Parameters.AddWithValue("@country", comboBox3.Text);
                cmd.Parameters.AddWithValue("@person", textBox19.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox20.Text);
                cmd.Parameters.AddWithValue("@fax", textBox21.Text);
                cmd.Parameters.AddWithValue("@email", textBox22.Text);
                cmd.Parameters.AddWithValue("@bank1", textBox17.Text);
                cmd.Parameters.AddWithValue("@acc1", textBox15.Text);
                cmd.Parameters.AddWithValue("@bank2", textBox14.Text);
                cmd.Parameters.AddWithValue("@acc2", textBox16.Text);

                try
                {
                    clearfield();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    db.closeconnect();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void displayall()
        {

            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query1 = "select supplierId,name as Supplier_name,address as Address,city as City,postalCode as Postalcode,country as Country,person as Contact_Person,mobileNo as Mobile,faxNo as Faxno,email as Email,bank1 as Bank1,account1 as Acc1,bank2 as Bank2,account2 as Acc2 from supplier_details";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                dataGridViewX1.DataSource = null;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX1.DataSource = bsource;
                this.dataGridViewX1.Refresh();
                sda.Update(dtat);
                db.closeconnect();

            }
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        public void deletetable()
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect();

                string query = "DELETE FROM  supplier_details   WHERE supplierId ='" + textBox2.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
                clearfield();
                MessageBox.Show("Recorded Deleted!!!");
            }catch
            {
                MessageBox.Show("Invalid!!");
            }
        }

        public int findsupid()
        {
            try
            {
                DBAccess db = new DBAccess();
                db.connect();
                string query1 = "SELECT supplierId FROM supplier_details ORDER BY supplierId DESC LIMIT 1";

                MySqlCommand cmd3 = new MySqlCommand(query1, db.connection);
                cmd3.ExecuteNonQuery();
                MySqlDataReader DR = cmd3.ExecuteReader();

                if (DR.Read())
                {
                    supplierid = DR.GetInt16("supplierId");
                }
                DR.Close();
                return supplierid;
            }
            catch
            {
                MessageBox.Show("Error 6");
                return -1;
            }
        }

        //find material id in the add supplier form////////
        public int findmid()
        {
            try
            {
                string st1 = comboBox2.Text;
                string st2 = comboBox4.Text;
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect(); 
                string query2 = "select materialId   from material_details where materialType='" + st1 + "' && materialName='" + st2 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query2, db.connection);
                cmd1.ExecuteNonQuery();
                MySqlDataReader DR = cmd1.ExecuteReader();

                if (DR.Read())
                {
                    materialid = DR.GetInt16("materialId");
                }
                DR.Close();
                if (materialid != 0)
                {
                    button2.Enabled = true;

                    string query1 = "select * from material_details where materialId='" + materialid + "'";

                    MySqlCommand cmd3 = new MySqlCommand(query1, db.connection);
                    cmd3.ExecuteNonQuery();
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dtat = new DataTable();
                        sda.Fill(dtat);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dtat;
                        dataGridViewX2.DataSource = bsource;
                        sda.Update(dtat);
                        db.closeconnect();

                    }
                    catch
                    {
                        MessageBox.Show("Display Error");
                    }

                }
                else
                {
                    MessageBox.Show("Record Not Found!!");
                }
                return materialid;
            }catch
            {
                return -1;
            }
        }
        ///////////////////////////////////

       ///record to supplier material in edit supplier/////////
        public void recordsupplier_material(string s1,string s2,string s3)
        {
            
            

                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect(); 
                string query2 = "select materialId   from material_details where materialType='" + s1 + "' && materialName='" + s2 + "'";
                MySqlCommand cmd1 = new MySqlCommand(query2, db.connection);
                cmd1.ExecuteNonQuery();
                MySqlDataReader DR = cmd1.ExecuteReader();

                if (DR.Read())
                {
                    materialid = DR.GetInt16("materialId");
                }
                DR.Close();



                try
                {
                    if ((s1 != "" && s2 != "" && s3 != ""))
                    {
                        string query3 = "INSERT INTO supplier_material ( supplierId,materialId,unitPrice) VALUES ('" + mid + "','" + materialid + "','" + s3 + "')";

                        MySqlCommand cmd2 = new MySqlCommand(query3, db.connection);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Sucessfully Added!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Material Is Already Added!!");
                }
            }
           
        
        ////////////////////////////////////////////////////
        public void datagridx3refresh()
        {
           
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void managesupplierpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

      
        private void buttonX2_Click(object sender, EventArgs e)
        {
            textBox25.Text = string.Empty;
            textBox36.Text = string.Empty;
            comboBox5.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            displayall();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            updatetable();

            if (radioButton1.Checked == true)
            {
                displaybyname();


            }
            else if (radioButton2.Checked == true)
            {
                displaybymaterial();
            }
            else if (radioButton3.Checked == true)
            {
                displaybyid();
            }
            else
            {
               
                displayall();
            }

        }

     

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierManagement_Load(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
          //  try
          //  {
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect();
                string query = "select distinct materialType from material_details";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.comboBox2.Items.Add(dr[0]);
                    this.comboBox1.Items.Add(dr[0]);

                }
                dr.Close();

                string query1 = "select  distinct materialName from material_details";
                MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);


                MySqlDataReader rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    this.comboBox5.Items.Add(rdr[0]);
                    this.comboBox4.Items.Add(rdr[0]);
                    this.comboBox6.Items.Add(rdr[0]);


                }
                rdr.Close();
                db.closeconnect();
        //    }catch
         //   {
             //   MessageBox.Show("Error 5");
       //     }

        }

       

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
        

           
        }

        private void textBox7_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            






        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                mid = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells["supplierId"].Value.ToString());
            }

            // int maid = mid;

            try
            {
                DBAccess db = new DBAccess();
                db.connect();
                // db.openConnect();
                string query = "select *   from supplier_details where supplierId ='" + mid + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    textBox2.Text = (DR["supplierId"].ToString());
                    textBox23.Text = (DR["name"].ToString());
                    textBox32.Text = (DR["address"].ToString());
                    textBox24.Text = (DR["city"].ToString());
                    textBox35.Text = (DR["postalCode"].ToString());
                    comboBox3.Text = (DR["country"].ToString());
                    textBox19.Text = (DR["Person"].ToString());
                    textBox20.Text = (DR["mobileNo"].ToString());
                    textBox21.Text = (DR["faxNo"].ToString());
                    textBox22.Text = (DR["email"].ToString());
                    textBox17.Text = (DR["bank1"].ToString());
                    textBox15.Text = (DR["account1"].ToString());
                    textBox14.Text = (DR["bank2"].ToString());
                    textBox16.Text = (DR["account2"].ToString());


                }
                DR.Close();

                string query1 = "select * from supplier_material where supplierId ='" + mid + "'";

                MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
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
                catch
                {
                    MessageBox.Show("Invalid");
                }
            }catch
            {
                MessageBox.Show("Error 4");
            }
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void warningBox1_OptionsClick(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox36.Text = string.Empty;
            comboBox5.SelectedIndex = -1;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox25.Text = string.Empty;
            comboBox5.SelectedIndex = -1;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox25.Text = string.Empty;
            textBox36.Text = string.Empty;
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

     

        private void dataGridViewX3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplierManagement_Activated(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            validation v2 = new validation();
            if (v2.checkEmptymaterial(text1.Text) && v2.checkEmptyField(text1.Text, text2.Text, text4.Text, text5.Text, combo1.Text, text6.Text, text8.Text, text9.Text, text10.Text, textBox6.Text, textBox4.Text))
            {

                if (button2.Enabled == true)
                {


                    recordsupplier_material(comboBox2.Text, comboBox4.Text,textBox1.Text);

                }
                else
                {
                    try
                    {
                        findmid();
                    }
                    catch {
                        MessageBox.Show("Error 2");
                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier s1 = new Supplier();
            validation v1 = new validation();

            DBAccess db = new DBAccess();
            db.connect();


            if (v1.checkEmptyField(text1.Text, text2.Text, text4.Text,text5.Text, combo1.Text, text6.Text, text8.Text, text9.Text, text10.Text, textBox6.Text, textBox4.Text) && v1.isText(text6.Text, textBox6.Text, textBox3.Text)&& v1.IsValidEmail(text10.Text))
            {

                try
                {
                    s1.InsertInfo(text1.Text, text2.Text, text4.Text, Convert.ToInt32(text5.Text), combo1.Text, text6.Text, Convert.ToInt32(text8.Text), Convert.ToInt32(text9.Text), text10.Text, textBox6.Text, textBox4.Text, textBox3.Text, textBox5.Text);
                    MessageBox.Show("Details Saved");


                    int supid = findsupid();

                    string query3 = "INSERT INTO supplier_material ( supplierId,materialId,unitPrice) VALUES ('" + supid + "','" + materialid + "','" + textBox1.Text + "')";

                    MySqlCommand cmd2 = new MySqlCommand(query3, db.connection);
                    cmd2.ExecuteNonQuery();
                }catch
                {
                    MessageBox.Show("Error!! 1");
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {

                if (textBox25.Text != string.Empty)
                {

                    displaybyname();
                }
                else
                {
                    this.dataGridViewX1.DataSource = null;
                }

            }
            else if (radioButton2.Checked == true)
            {


                if (comboBox5.SelectedIndex != -1)
                {

                    displaybymaterial();
                }
                else
                {
                    this.dataGridViewX1.DataSource = null;
                }

            }
            else if (radioButton3.Checked == true)
            {

                if (textBox36.Text != string.Empty)
                {

                    displaybyid();
                }
                else
                {
                    this.dataGridViewX1.DataSource = null;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox25.Text = string.Empty;
            textBox36.Text = string.Empty;
            comboBox5.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            displayall();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updatetable();

            if (radioButton1.Checked == true)
            {
                displaybyname();


            }
            else if (radioButton2.Checked == true)
            {
                displaybymaterial();
            }
            else if (radioButton3.Checked == true)
            {
                displaybyid();
            }
            else
            {

                displayall();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deletetable();
            if (radioButton1.Checked == true)
            {
                displaybyname();


            }
            else if (radioButton2.Checked == true)
            {
                displaybymaterial();
            }
            else if (radioButton3.Checked == true)
            {
                displaybyid();
            }
            else
            {

                displayall();
            }
         
            DBAccess db = new DBAccess();
            db.connect();
            string query1 = "select * from supplier_material where supplierId ='" + mid + "'";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
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
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            recordsupplier_material(comboBox1.Text, comboBox6.Text, textBox9.Text);

            DBAccess db = new DBAccess();
            db.connect();
            string query1 = "select * from supplier_material where supplierId ='" + textBox2.Text + "'";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
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
            catch
            {
                MessageBox.Show("Invalid");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            textBox6.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            text1.Text = "";
            text2.Text = "";
            textBox1.Text = "";
            comboBox4.SelectedIndex = -1;
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
            text8.Text = "";
            text9.Text = "";
            text10.Text = "";
            combo1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewX3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > -1)
            {
                 materialid1 = Convert.ToInt32(dataGridViewX3.Rows[e.RowIndex].Cells["materialId"].Value.ToString());
            }
            DBAccess db = new DBAccess();
            db.connect();

            string query1 = "select * from material_details where materialId ='" + materialid1 + "'";

            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            cmd1.ExecuteNonQuery();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dtat = new DataTable();
                sda.Fill(dtat);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dtat;
                dataGridViewX4.DataSource = bsource;
                sda.Update(dtat);
                db.closeconnect();

            }
            catch
            {
                MessageBox.Show("Invalid");
            }



        }

        private void dataGridViewX4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text10_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void text10_Validated(object sender, EventArgs e)
        {
            validation v1 = new validation();
            v1.IsValidEmail(text10.Text);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox22_Validated(object sender, EventArgs e)
        {
            validation v1 = new validation();
            v1.IsValidEmail(textBox22.Text);
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

