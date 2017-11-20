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
    public partial class add_bill : Form
    {
        imageDialog imageD = new imageDialog();
        DBAccess db = new DBAccess();
        public add_bill()
        {
            InitializeComponent();
        }
        public string billimage;


        bool deleteBill(string billId) {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "DELETE FROM utilitybills WHERE billId=@id";

                cmd.Parameters.AddWithValue("@id", billId);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }

            return false;
        }

        bool updateBill(string billID,string month,string unit,string amount )
        {
            if (db.connect())
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE utilitybills SET month=@month, unit=@unit, billAmount=@amount WHERE billId=@id";
                  
                cmd.Parameters.AddWithValue("@id", billID);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Connection = db.connection;


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { return true; } else { return false; }



            }

            return false;
        }

        public void insertBill(string type, string month, string unit, string amount, string billImage)
        {
            db.connect();

            string query = "INSERT INTO utilitybills (type, month, unit, billAmount, bill) VALUES (@type,@month,@unit,@amount,@bill)";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@bill", File.ReadAllBytes(billImage));
            cmd.ExecuteNonQuery();
            db.closeconnect();
        }
        public void search_month(string month)
        {
            db.connect();
            string query = "SELECT * FROM utilitybills WHERE month=@month";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@month", month);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read()) {
                UtilityBillGrid.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4));
            }
          
            db.closeconnect();
            
        }

        public void searchBill(string month, string type)
        {
            db.connect();
            string query = "SELECT * FROM utilitybills WHERE month =@month AND type=@type";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@type", type);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                UtilityBillGrid.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4));
            }

            db.closeconnect();
        }

        //void getbook(string bid)
        //{
        //    db.connect();
        //    string query = "SELECT book FROM utilitybills WHERE billId =@bid";
        //    MySqlCommand cmd = new MySqlCommand(query, db.connection);
        //    cmd.Parameters.AddWithValue("@bid", bid);
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    //dt.Load(reader);
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        // pic.Image = blobToImage((byte[])(reader.GetValue(0)));
        //        // pic.Refresh();
        //        //paymentSlip_panel.Visible = true;
        //    }
        //    reader.Close();
        //    db.connection.Close();

        //    //return dt;

        //}

        public Image blobToImage(byte[] byteArrayIn)
        {

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        }


        public void fileOpen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "image files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Encrypt the selected file. I'll do this later. :)
                try
                {
                    FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                    billimage = dialog.FileName;
                    // billsize = dialog.FileName.Length;
                    var billsize = new FileInfo(dialog.FileName).Length;
                    //imageD.pictureBox1.image = Bitmap.FromFile(dialog.FileName);
                    attachmentName.Text = attachmentName.Text+billimage.Substring(billimage.LastIndexOf("\\")+1);
                    attachmentSize.Text = attachmentSize.Text+billsize.ToString()+" KB";



                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }


        }



        private void add_bill_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            imageD.getimage(billimage);
            imageD.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (type.SelectedIndex > -1 & units.Text != String.Empty & amount.Text != String.Empty)
            {
                try
                {
                    insertBill(type.Text, month.Text, units.Text, amount.Text, billimage);
                    MessageBox.Show("Utility Bill Added");
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }

            }
            else {
                MessageBox.Show("Empty Fields Not Allowed");
            }

           
           
        }

        private void browse_Click(object sender, EventArgs e)
        {
            fileOpen();
        }

        private void viewBill_Click(object sender, EventArgs e)
        {
            imageD.getimage(billimage);
            imageD.Show();
        }

        private void attachmentName_Click(object sender, EventArgs e)
        {

        }

        private void monthSearch_ValueChanged(object sender, EventArgs e)
        {
            UtilityBillGrid.Rows.Clear();
            UtilityBillGrid.Refresh();
            search_month(monthSearch.Text);
           
                
            
            typeSearch.Enabled = true;            
        }

        private void typeSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            UtilityBillGrid.Rows.Clear();
            UtilityBillGrid.Refresh();
            searchBill(monthSearch.Text, typeSearch.Text);
            //foreach (DataRow row in dt.Rows)
            //{

            //    UtilityBillGrid.Rows.Add(row.ItemArray);
            //}
        }

      

        private void UtilityBillGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (UtilityBillGrid.SelectedRows.Count > 0)
            {
                billPanel.Enabled = true;
                unitsEdit.Text = UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[3].Value.ToString();
                AmountEdit.Text = UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[4].Value.ToString();
                typeEdit.SelectedItem=UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
                //monthEdit.Text= UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[2].Value.ToString();
            }
            else {
                billPanel.Enabled = false;
                billPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (typeEdit.SelectedIndex > -1 & unitsEdit.Text != String.Empty & AmountEdit.Text != String.Empty)
            {
                try
                {
                    if (updateBill(UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[0].Value.ToString(), monthEdit.Text, unitsEdit.Text, AmountEdit.Text))
                    {
                        MessageBox.Show("Update Successful");
                        UtilityBillGrid.Rows.RemoveAt(UtilityBillGrid.SelectedRows[0].Index);
                        UtilityBillGrid.Refresh();
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("Empty Fields Not Allowed");
            }

            }

        private void delete_Click(object sender, EventArgs e)
        {
            if (deleteBill(UtilityBillGrid.Rows[UtilityBillGrid.SelectedRows[0].Index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Delete Successful");
                UtilityBillGrid.Rows.RemoveAt(UtilityBillGrid.SelectedRows[0].Index);
                UtilityBillGrid.Refresh();
            }
        }

        private void units_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void unitsEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void AmountEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
