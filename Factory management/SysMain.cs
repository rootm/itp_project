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
        bool expanded = true;
        object exitObject;
        private static int level = 0;

         public void logUser(int level) {
            side_menu.Show();
        }

        private void removeButtonText() {
            user_button.Text = "";
            finance_button.Text = "";
            emp_button.Text = "";
            stock_button.Text = "";
            vehicle_button.Text = "";
            agent_button.Text = "";
            supplier_button.Text = "";
        }

        private void setButtonText()
        {
            user_button.Text = "User";
            finance_button.Text = "Finance Management";
            emp_button.Text = "Employee Management";
            stock_button.Text = "Stock Management";
            vehicle_button.Text = "Vehicle Management";
            agent_button.Text = "Agent Management";
            supplier_button.Text = "Supplier management";
        }

        private void shrinkMenu() {

           
                removeButtonText();
            int width = user_button.Width/2;

           // side_menu.Width = width;
            user_button.Width = width;
            finance_button.Width = width;
            emp_button.Width = width;
            stock_button.Width = width;
            vehicle_button.Width = width;
            agent_button.Width = width;
            supplier_button.Width = width;
            expanded = false;
            

        }
          

        private void expandMenu() {

           // if (!expanded) { 
            int width = user_button.Width * 2;
           // side_menu.Width = width;
            user_button.Width = width;
            finance_button.Width = width;
            emp_button.Width = width;
            stock_button.Width = width;
            vehicle_button.Width = width;
            agent_button.Width = width;
            supplier_button.Width = width;
            setButtonText();
                expanded = true;
            //}
        }
        public SysMain()
        {
           
           
            InitializeComponent();
          //  back.Size = this.Size;
           
        }

        private void SysMain_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Chocolate;
            //back.SendToBack();
            shrinkMenu();
            login log = new login();
            log.MdiParent = this;
            log.Show();

        }

        private void finance_button_Click(object sender, EventArgs e)
        {
           
            
        }

        private void side_menu_MouseLeave(object sender, EventArgs e)
        {
            object x = sender;

            if (expanded)
            {
                shrinkMenu();
                exitObject = sender;
            }
        }
        private void side_menu_MouseEnter(object sender, EventArgs e)
        {
            object x = sender;
            if (!expanded)
            {
                expandMenu();
            }

            
        }

      

        private void user_button_Click(object sender, EventArgs e)
        {
            EditUser frm = new EditUser();
            frm.MdiParent = this;
            frm.Show();
        }

   
    }
}
