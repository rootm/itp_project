using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Factory_management
{
    class validation
    {

        public bool checkEmptyField(String name, String address, String city,string postalcode, String country, String firstname,string phoneno,string faxno,string email,string bank1,string acc1)
        {
            if (name == "" || address ==""  || city == "" ||postalcode == "" || country == "" || firstname == "" || phoneno == "" || faxno == "" || email == "" || bank1 == "" || acc1 == "")
            {
        
                const string caption = "Null Validation";
                MessageBox.Show("One Or More field is Empty",caption,
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
            
        }



        public bool checkEmptymaterial(string cost)
        {
            if (cost == "" )
            {

                const string caption = "Null Validation";
                MessageBox.Show("One Or More field is Empty", caption,
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }

        }







        public bool isText(String value1,string value2,string value3)
        {
           
            if (value1.Any(Char.IsDigit) || value2.Any(Char.IsDigit) || value3.Any(Char.IsDigit))
            {
                MessageBox.Show("Please enter  without digits");
                return false;

            }else
            {

                return true;
            }
            

        }

        public bool IsValidEmail(string email)
        {
            
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
            {
                return true;
            }else
            {
                MessageBox.Show("Enter Valid Email");

                return false;
            }
         }





    }
}
