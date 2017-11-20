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

            maintainance_panel.Width = topPanel.Width;
            maintainance_panel.Show();
            maintainance_panel.BringToFront();
            addMachineButton.PerformClick();
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
            financial_panel.Width= topPanel.Width;
            financial_panel.Show();
            financial_panel.BringToFront();
            
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

        void setWhite_MaintainancePanels() {
            maintainance_panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));

        }
        void setWhite_OrdersPanels()
        {

            orderManagement_panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));

        }

        void setWhite_AgentPanels()
        {

            agent_panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));
           
        }
        void setWhite_FinancialPanels() {

            financial_panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));
          


        }

        void setWhite_VehiclePanels()
        {
            vehicle_panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));
        
        }

        void setWhite_EmployeePanels(){
            employee_Panel.Controls.OfType<Panel>().ToList().ForEach(panel => panel.BackColor = Color.FromArgb(255, 255, 255, 255));
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

        private void vehicle_menu_Click(object sender, EventArgs e)
        {

            vehicle_panel.Width = topPanel.Width;
            vehicle_panel.Show();
            vehicle_panel.BringToFront();
            addVehicleButton.PerformClick();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            addVehicle_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            addEdit_vehicles lg = new addEdit_vehicles();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editVehiclelButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            editVehicle_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            edit_vehicle lg = new edit_vehicle();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void deliveryScheduleButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            deliverySchedule_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            DeliveryShedule lg = new DeliveryShedule();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editDeliveryButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            editDelivery_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            edit_scheduled_product_orders_delivery lg = new edit_scheduled_product_orders_delivery();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void transportButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            transportSchedule_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Transport_schedule lg = new Transport_schedule();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editTransportButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            editTransport_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            EditTransport_shedule lg = new EditTransport_shedule();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            repairRequest_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            repairRequest lg = new repairRequest();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void expenseButton_Click(object sender, EventArgs e)
        {
            setWhite_VehiclePanels();
            travelExpense_panel.BackColor = Color.FromArgb(255, 1, 194, 110);
            travel_expenses lg = new travel_expenses();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void employee_menu_Click(object sender, EventArgs e)
        {
            employee_Panel.Width = topPanel.Width;
            employee_Panel.Show();
            employee_Panel.BringToFront();
           
            addEmpButton.PerformClick();
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            addEmpPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            emp lg = new emp();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editEmpButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            editEmpPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            empSearch lg = new empSearch();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void addOtButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            addOtPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            OT lg = new OT();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editOtButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            editOtPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            otSearch lg = new otSearch();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void addSalaryButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            addSalaryPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            salary lg = new salary();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editSalaryButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            editSalaryPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            salarySearch lg = new salarySearch();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void addLeaveButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            addLeavePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            leaves lg = new leaves();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editLeaveButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            editLeavePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            searchLeaves lg = new searchLeaves();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void addDepButton_Click(object sender, EventArgs e)
        {
            setWhite_EmployeePanels();
            addDepPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            departments lg = new departments();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void agent_menu_Click(object sender, EventArgs e)
        {
            agent_panel.Width = topPanel.Width;
            agent_panel.Show();
            agent_panel.BringToFront();

            addEditAgentsButton.PerformClick();
        }

        private void addEditAgentsButton_Click(object sender, EventArgs e)
        {

            setWhite_AgentPanels();
            addEditAgentsPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            addagent_form lg = new addagent_form();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void orderStatusButton_Click(object sender, EventArgs e)
        {
            setWhite_AgentPanels();
            agentOrderStatusPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            order_conf lg = new order_conf();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void salesReportButton_Click(object sender, EventArgs e)
        {
            setWhite_AgentPanels();
            salesReportPannel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Sales_reports lg = new Sales_reports();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();

        }

        private void orders_menu_Click(object sender, EventArgs e)
        {
            orderManagement_panel.Width = topPanel.Width;
            orderManagement_panel.Show();
            orderManagement_panel.BringToFront();
            orderDetailsButton.PerformClick();
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {

            setWhite_OrdersPanels();
            orderDetailsPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            agentOder_details lg = new agentOder_details();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void viewProductButton_Click(object sender, EventArgs e)
        {
            setWhite_OrdersPanels();
            viewProductPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            viewProduct_stock lg = new viewProduct_stock();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

  

        private void specialOrderButton_Click(object sender, EventArgs e)
        {
            setWhite_OrdersPanels();
            specialOrderPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Request_Order lg = new Request_Order();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void addMachineButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            addMachinePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            machines lg = new machines();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void editMachineButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            editMachinePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Edit_machine lg = new Edit_machine();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void serviceCenterButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            serviceCenterPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            ServiceCenter lg = new ServiceCenter();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void maintainMachineButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            maintenanceMachinePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            Maintenance_machines lg = new Maintenance_machines();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void miantenanceVehicleButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            maintenanceVehiclePanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            vehicleRepairs_shedule lg = new vehicleRepairs_shedule();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }

        private void checkRepairButton_Click(object sender, EventArgs e)
        {
            setWhite_MaintainancePanels();
            checkRepairPanel.BackColor = Color.FromArgb(255, 1, 194, 110);
            CheckRepair lg = new CheckRepair();
            lg.TopLevel = false;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(lg);
            lg.Show();
        }
    }
    }

