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
    public partial class imageDialog : Form
    {
        public imageDialog()
        {
            InitializeComponent();
        }
        public string bill;
        private void imageDialog_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(bill);
            
        }
        public void getimage(string billimage)
        {
            bill = billimage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
