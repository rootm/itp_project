using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Factory_management
{
    public partial class repairRequest : Form
    {
        vehicle v = new vehicle();
        DataTable dt = new DataTable();
        repair r = new repair();
        public repairRequest()
        {
            InitializeComponent();
        }
       
        void Loadgrid()
        {
            dataGridView1.Rows.Clear();
            dt = v.getdetails();
            foreach (DataRow row in dt.Rows)
            {

                dataGridView1.Rows.Add(row.ItemArray);
            }
        }
        void Loadgrid1(string regno)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int warning = 0;
                bool warning2 = false;
                bool warning3 = false;


                if (!String.IsNullOrEmpty(vid.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(type.Text))
                {
                    warning++;
                }
                if (!String.IsNullOrEmpty(description.Text))
                {
                    warning++;
                }
                if (warning != 3)
                {
                    MessageBox.Show("Fill Empty Fields");
                }


                if ((warning == 3) && (warning2 == false) && (warning3 == false))
                {


                    r.InsertInfo(vid.Text, type.Text, description.Text);
                    MessageBox.Show("Request send successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = regno.Text;
                dataGridView1.Rows.Clear();
                dt = v.getdetails(regNo);
                foreach (DataRow row in dt.Rows)
                {

                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void view_all_Click(object sender, EventArgs e)
        {
            Loadgrid();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void repairRequest_Load(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            vid.Text = row.Cells[0].Value.ToString();
        }
    }
}
