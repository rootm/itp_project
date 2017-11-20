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
    public partial class travel_expenses : Form
    {
        expenses ex = new expenses();
        public travel_expenses()
        {
            InitializeComponent();
        }
        public string invoiceImg;

       
        private void search_Click(object sender, EventArgs e)
        {
            if (transportType.Text == "delivery")
            {
                sheduleGrid.DataSource = ex.Searchdelivery(date.Text);
            }
            else
            {
                sheduleGrid.DataSource = ex.Searchgeneral(date.Text);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            date.Enabled = true;

        }

        private void view_all_Click(object sender, EventArgs e)
        {
            if (transportType.Text == "delivery")
            {
                sheduleGrid.DataSource = ex.Searchdelivery();
            }
            else 
            {
                sheduleGrid.DataSource = ex.Searchgeneral();
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            search.Enabled = true;
            

        }

        private void sheduleGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (sheduleGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = sheduleGrid.SelectedRows[0];
                id.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                id.Text = "";
            }
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                    invoiceImg = fd.FileName;
                    //pic.Image = Bitmap.FromFile(fd.FileName);



                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (transportType.Text == "delivery")
            {
                ex.InsertInfoDelivery(id.Text,expense.Text,Amount.Text,invoiceImg);
                MessageBox.Show("data added");
            }
            else
            {
                ex.InsertInfo(id.Text, expense.Text, Amount.Text, invoiceImg);
                MessageBox.Show("data added");
            }
        }
    }
}
