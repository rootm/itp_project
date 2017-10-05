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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.TopLevel = false;
            this.panel1.Controls.Add(lg);
            lg.Show();
        }

      

        private void users_menu_Click(object sender, EventArgs e)
        {

        }

        private void users_menu_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(10, 1, 194, 110);
        }

        private void agent_menu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(255, 45, 62, 80);
        }
    }
    }

