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
    public partial class edit_vehicle : Form
    {
        vehicle v = new vehicle();
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public string book;
        public edit_vehicle()
        {
            InitializeComponent();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            dataGridView1.Rows.Clear();
            pic.Image = null;
        }
        void Loadgrid()
        {
            
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dt = v.getdetails();
            
            foreach (DataRow row in dt.Rows)
            {
                
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }
        void Loadgrid1(string regNo)
        {
            dataGridView1.Rows.Clear();
            dt = v.getdetails(regNo);
            foreach (DataRow row in dt.Rows)
            {
                
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                  
                    int veid = Convert.ToInt32(vid.Text);

                    v.DeleteInfo(veid);
                    this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    pic.Image = null;
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    

                    dt = v.getdetails();
                    
                    foreach (DataRow row in dt.Rows)
                    {

                        dataGridView1.Rows.Add(row.ItemArray);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string regNoSearch = regnoSearch.Text;
                
                Loadgrid1(regNoSearch);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadgrid();
            
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {

        }

        private void edit_vehicle_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            vid.Text = row.Cells[0].Value.ToString();
            regno.Text = row.Cells[1].Value.ToString();
            type.Text = row.Cells[2].Value.ToString();
            model.Text = row.Cells[3].Value.ToString();            
            engno.Text = row.Cells[4].Value.ToString();
            pdate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            purprice.Text = row.Cells[6].Value.ToString();
            insno.Text = row.Cells[7].Value.ToString();
            inscompany.Text = row.Cells[8].Value.ToString();
            amount.Text = row.Cells[9].Value.ToString();
            enddate.Value =Convert.ToDateTime (row.Cells[10].Value.ToString());
            getbook(row.Cells[0].Value.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void attach_book_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                    book = fd.FileName;
                    pic.Image = Bitmap.FromFile(fd.FileName);

                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                v.UpdateInfo(Convert.ToInt32(vid.Text),regno.Text,type.Text,model.Text,engno.Text,pdate.Text,Convert.ToInt32(purprice.Text),insno.Text,inscompany.Text,Convert.ToInt32(amount.Text),enddate.Text,book);
                this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                pic.Image = null;
                Loadgrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        void getbook(string vid)
        {
            db.connect();
            string query = "SELECT book FROM vehicle_details WHERE vehicleId ="+ vid +"";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            //dt.Load(reader);
            if (reader.HasRows)
            {
                reader.Read();
                pic.Image = blobToImage((byte[])(reader.GetValue(0)));
                pic.Refresh();
                //paymentSlip_panel.Visible = true;
            }
            reader.Close();
            db.connection.Close();

            //return dt;

        }

        public Image blobToImage(byte[] byteArrayIn)
        {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }
    }
}
