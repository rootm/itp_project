
using MySql.Data.MySqlClient;
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
    public partial class invoiceviewer : Form
    {
        private string name;
        private string cost;
        private string matid2;
        private string oid2;
        private string orderdate;
        private string quantity;
        private string supplierid;
        private string mattype;
        private string matname;
        private string address;
        
        private string mobileNo;
        private string emailid;

      

        public invoiceviewer(string oid2, string matid2, string quantity, string orderdate, string supplierid, string cost, string mattype, string matname, string name, string address,  string mobileNo, string emailid) 
        {
            this.name = name;
            this.address = address;
           
            this.mobileNo = mobileNo;
            this.emailid = emailid;
            this.oid2 = oid2;
            this.matid2 = matid2;
            this.quantity = quantity;
            this.orderdate = orderdate;
            this.supplierid = supplierid;
            this.cost = cost;
            this.mattype = mattype;
            this.matname = matname;

            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void invoiceviewer_Load(object sender, EventArgs e)
        {

            try
            {
                makeordrerinvoice m = new makeordrerinvoice();
                m.SetParameterValue("oid", oid2);
                m.SetParameterValue("date", orderdate);
                m.SetParameterValue("matid", matid2);
                m.SetParameterValue("supid", supplierid);
                m.SetParameterValue("quantity", quantity);
                m.SetParameterValue("cost", cost);
                m.SetParameterValue("mattype", mattype);
                m.SetParameterValue("matname", matname);
                m.SetParameterValue("supname", name);
                m.SetParameterValue("supaddress", address);
                m.SetParameterValue("mobileno", mobileNo);
                m.SetParameterValue("email", emailid);
                m.SetParameterValue("supid", supplierid);

                crystalReportViewer1.Refresh();
                crystalReportViewer1.ReportSource = m;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
