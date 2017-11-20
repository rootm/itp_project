using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factory_management 
{
    public partial class viewProduct_stock : System.Windows.Forms.Form
    {
        DBAccess db = new DBAccess();
        Special_Orders o = new Special_Orders();

        public viewProduct_stock()
        {
            InitializeComponent();
        }

        void Loadgrid1()
        {
            {
       
                DataTable dt = o.getdetails1();

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView3.Rows.Add(row.ItemArray);
                }
            }
        }

        void Loadgrid7(int pid)
        {
            {
                
                DataTable dt = o.getdetails7(pid);

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView3.Rows.Add(row.ItemArray);
                }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String name1 = "Stock is available,Do you need to continue";
            MessageBox.Show(name1);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name2 = "Stock is not avaialabe,Pending message has been sent";
            MessageBox.Show(name2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            
            int pid = Convert.ToInt32(textBox1.Text);
            Loadgrid7(pid);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void Form3Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            
            int pid = Convert.ToInt32(textBox1.Text);

            dataGridView3.Rows.Clear();
            Loadgrid7(pid);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

    
