using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supplier_management_ganesh
{
    public partial class supp : Form
    {
        public supp()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            managesupplierpanel.Visible = false;
            addsupplierpanel.Visible = true;
            purchasepanel.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            managesupplierpanel.Visible = true;
            addsupplierpanel.Visible = false;
            purchasepanel.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            managesupplierpanel.Visible = false;
            addsupplierpanel.Visible = false;
            purchasepanel.Visible = true;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
