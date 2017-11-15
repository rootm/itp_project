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

            this.MouseWheel += new MouseEventHandler(Panel4_MouseWheel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productAgent_payment lg = new productAgent_payment();
            lg.TopLevel = false;
            this.panel1.Controls.Add(lg);
            lg.Show();
        }

      

        private void users_menu_Click(object sender, EventArgs e)
        {
            users lg = new users();
            lg.TopLevel = false;

            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            financial_panel.Hide();
            lg.Show();
        }

        private void users_menu_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(255, 1, 194, 110);
        }

        private void agent_menu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(255, 45, 62, 80);
        }

        private void Panel4_MouseWheel(object sender, MouseEventArgs e)
        {
            panel4.Focus();
        }


        private void finance_menu_Click(object sender, EventArgs e)
        {
            financial_panel.Show();
            homeButton.PerformClick();

            
        }

  
        private void meterialButton_Click(object sender, EventArgs e)
        {

            setWhite_FinancialPanels();
            meterialPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            rawMetirialPayments lg = new rawMetirialPayments();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();



        }

        void setWhite_FinancialPanels() {
            homePanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            meterialPanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            agentPanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            vehiclePanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            repairPanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            addBillPanel.BackColor = Color.FromArgb(255, 255, 255, 255);
            editBillPanel.BackColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void addBillButton_Click(object sender, EventArgs e)
        {
            setWhite_FinancialPanels();
            addBillPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            add_bill lg = new add_bill();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void agentButton_Click(object sender, EventArgs e)
        {
            setWhite_FinancialPanels();
            agentPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            productAgent_payment lg = new productAgent_payment();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            setWhite_FinancialPanels();
            vehiclePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Vehicle_expenses lg = new Vehicle_expenses();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void repairButton_Click(object sender, EventArgs e)
        {
            setWhite_FinancialPanels();
            repairPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Repair_expenses lg = new Repair_expenses();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();




        }

        private void editBillButton_Click(object sender, EventArgs e)
        {
            
            setWhite_FinancialPanels();
            editBillPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Utitlity lg = new Utitlity();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void stocks_menu_Click(object sender, EventArgs e)
        {
            

           

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            setWhite_FinancialPanels();
            //panel5.BringToFront();
            homePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            finance_home lg = new finance_home();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "login").FirstOrDefault();
            if (null != frm)
            {
                frm.Close();
                frm = null;
            }

            financial_panel.Show();
            homeButton.PerformClick();
        }
    }
    }

