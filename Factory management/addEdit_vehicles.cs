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
using System.IO;
using System.Drawing.Imaging;

namespace Factory_management
{
    public partial class addEdit_vehicles : Form
    {
        vehicle v = new vehicle();
        public addEdit_vehicles()
        {
            InitializeComponent();
        }
        public string book ;
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



        private void addEdit_vehicles_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void add_vehicle_Click(object sender, EventArgs e)
        {
          
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
            type.Text = null;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            int warning = 0;
            bool warning2 = false;
            bool warning3 = false;
            if (!String.IsNullOrEmpty(regno.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(type.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(model.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(engno.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(pdate.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(price.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(insno.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(inscompany.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(amount.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(enddate.Text))
            {
               warning++;
            }
            if (warning != 10)
            {
                    MessageBox.Show("Fill Empty Fields");
            }
                if ((warning == 10) && (warning2 == false) && (warning3 == false))
                {
                    
                    v.InsertInfo(regno.Text, type.Text, model.Text, engno.Text, pdate.Text,  Convert.ToInt32(price.Text), insno.Text, inscompany.Text, Convert.ToInt32(amount.Text), enddate.Text,book);
                    MessageBox.Show("data saved");
                    this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
                    type.Text = null;


            }
            
        }

       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void edit_vehicle_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
