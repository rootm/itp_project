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
    public partial class machines : Form
    {
        Machine m = new Machine();

        public string image;

        public machines()
        {
            InitializeComponent();
        }

        private void machines_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void clearDetails()
        {

            txtMachineType.Text = null;
            txtPrice.Text = null;
            txtCompany.Text = null;
            txtAddress.Text = null;
            txttelephone.Text = null;
            warrentyDate.Text = null;
            purchaseDate.Text = null;
            warrentyImage.Image = null;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            txtMachineType.Text = null;
            txtPrice.Text = null;
            txtCompany.Text = null;
            txtAddress.Text = null;
            txttelephone.Text = null;
            


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void warrenty_browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                    image = fd.FileName;
                    //byte[] photo_aray = new byte[fs.Length];
                    //fs.Read(image, 0, image.Length);
                    warrentyImage.Image = Bitmap.FromFile(fd.FileName);

                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
       

        }

        private void clear_Click(object sender, EventArgs e)
        {

            txtMachineType.Text = null;
            txtPrice.Text = null;
            txtCompany.Text = null;
            txtAddress.Text = null;
            txttelephone.Text = null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {

                int warning = 0;

                if (!String.IsNullOrEmpty(txtMachineType.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(purchaseDate.Text))
                {
                    warning++;
                }

                if (!String.IsNullOrEmpty(warrentyDate.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(txtPrice.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(txtCompany.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(txtAddress.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(txttelephone.Text))
                {
                    warning++;
                }

                //empty fields
                if (warning != 7)
                {
                    MessageBox.Show("Fill Empty Fields");
                }

                if (warning == 7)
                {


                    DialogResult dialogResult = MessageBox.Show("Do you really want to add ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string type = txtMachineType.Text;
                        string purchasedate = purchaseDate.Text;
                        string warrentydate = warrentyDate.Text;
                        string price = txtPrice.Text;
                        string company = txtCompany.Text;
                        string address = txtAddress.Text;
                        string phone = txttelephone.Text;
                        

                        m.insert(type, purchasedate, warrentydate, price, company, address, phone, image, "1");


                        MessageBox.Show("Successful Insertion");
                        //loadSalaryGrid();
                        clearDetails();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Cancel Insertion");
                    }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
