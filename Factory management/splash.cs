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
    public partial class splash : Form
    {
        int x = 0;

        public splash()
        {
            InitializeComponent();
        }

        login mainfrm = new login();

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            try
            {
                if (progressBar1.Value != 100)
                {
                    if (x < 15)
                    {
                        splash_status.Text = "Connecting To Database Servers";
                    }
                    else if (x < 30)
                    {
                        splash_status.Text = "Database Connected";
                    }
                    else {
                        splash_status.Text = "Loading Modules.... "+ x+"%";
                    }
                    progressBar1.Value += 1;
                    ++x;
                }
                else if (x >= 100 && x < 151) {
                    double z= this.Opacity;
                    this.Opacity -= 0.02;
                   
                   
                    this.Refresh();
                    ++x;
                }
                else
                {
                    //MessageBox.Show(x.ToString());
                    mainfrm.Show();
                  this.Hide();
                }
            }
            catch (Exception)
            {
                this.Hide();
            
            }
           
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
