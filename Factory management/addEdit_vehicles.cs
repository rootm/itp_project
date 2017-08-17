using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class addEdit_vehicles : Form
    {
        public addEdit_vehicles()
        {
            InitializeComponent();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            panel1.Visible = false;
            panel1.SendToBack();
        }
    }
}
