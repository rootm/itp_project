using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Factory_management
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierinformation s1 = new supplierinformation();
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ReportSource = s1;
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliermaterialinfo s1 = new suppliermaterialinfo();
            

            crystalReportViewer1.ReportSource = s1;
            crystalReportViewer1.RefreshReport();
        }
    }
}
