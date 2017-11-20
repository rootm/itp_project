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
    public partial class Edit_machine : Form
    {
        Machine m = new Machine();

        public String image;

        public Edit_machine()
        {
            InitializeComponent();
        }

        void loadGrid(int mid)
        {

            DataTable dt = m.getdetailsx(mid);
            foreach (DataRow row in dt.Rows)
            {

                warrentyGrid.Rows.Add(row.ItemArray);
            }

        }

        void loadGrid()
        {

            DataTable dt = m.getdetailsx();

            foreach (DataRow row in dt.Rows)
            {

                warrentyGrid.Rows.Add(row.ItemArray);
            }

        }



        void clearDetails()
        {
            macineNo.Text = null;
            type.Text = null;
            purchaseDate.Text = null;
            warrentyDate.Text = null;
            price_.Text = null;
            company_.Text = null;
            address_.Text = null;
            telephone_.Text = null;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }





        private void dataGridView7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            macineNo.Text = warrentyGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            type.Text = warrentyGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            purchaseDate.Text = warrentyGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            purchaseDate.Text = warrentyGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            price_.Text = warrentyGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            company_.Text = warrentyGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            address_.Text = warrentyGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            telephone_.Text = warrentyGrid.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void search_Click(object sender, EventArgs e)
        {
            try
            {

                int mid = Convert.ToInt32(macineNo.Text);

                warrentyGrid.Rows.Clear();
                loadGrid(mid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            warrentyGrid.Rows.Clear();
            loadGrid();
        }

        private void update_Click(object sender, EventArgs e)
        {

            if ((!telephone_.Text.All(char.IsDigit)) || (telephone_.Text.Length != 10))
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else
            {

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int mid = Convert.ToInt32(macineNo.Text);
                        string MachineType = type.Text;
                        string PurchaseDate = purchaseDate.Text;
                        string warrentyDate = this.warrentyDate.Text;
                        string price = price_.Text;
                        string company = company_.Text;
                        string Address = address_.Text;
                        string TelephoneNo = telephone_.Text;

                        m.UpdateInfo(mid, MachineType, PurchaseDate, warrentyDate, price, company, Address, TelephoneNo,image);

                        MessageBox.Show("Data Saved Successfully");
                        warrentyGrid.Rows.Clear();
                        loadGrid();

                        clearDetails();


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


        }

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int mid = Convert.ToInt32(macineNo.Text);

                    m.DeleteInfo(mid);


                    MessageBox.Show("Successfully deleted");
                    loadGrid();
                    clearDetails();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Cancel Deletion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void warrenty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void warrenty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            macineNo.Text = warrentyGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            type.Text = warrentyGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            purchaseDate.Text = warrentyGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            warrentyDate.Text = warrentyGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            price_.Text = warrentyGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            company_.Text = warrentyGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            address_.Text = warrentyGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            telephone_.Text = warrentyGrid.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                    image = fd.FileName;
                    //byte[] photo_aray = new byte[fs.Length];
                    //fs.Read(image, 0, image.Length);
                    //warrentyImage.Image = Bitmap.FromFile(fd.FileName);

                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }
    }
}
