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
    public partial class SysMain : Form
    {
        private int childFormNumber = 0;
        sideMenu menu;

        public SysMain()
        {
           
           
            InitializeComponent();
            menu = new sideMenu(this);
        }

        private void SysMain_Load(object sender, EventArgs e)
        {
            
        }

        private void finance_button_Click(object sender, EventArgs e)
        {
           
            menu.setButtonText();
        }
    }
}
