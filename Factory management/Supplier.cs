using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Factory_management
{
    class Supplier
    {
        private string supplier_name;
        private int supplier_id;
        private string add1;
        private string add2;
        private string city;
        private int postal_code;
        private string country;
        private string contact_first;
        private string contact_last;
        private int phone_no;
        private int fax_no;
        private string email;
        private string bank1;
        private string bank2;
        private int acc1;
        private int acc2;
        private string descripition;
        private string matriel_type;
        private double cost_per_unit;

        //constructor//
        public Supplier()
        {
         supplier_name=null;
         supplier_id=0;
         add1 =null;
         add2=null;
          city= null;
          postal_code=0;
          country="Srilanka";
          contact_first=null;
          contact_last=null;
          phone_no=0;
          fax_no=0;
          email=null;
          bank1=null;
          bank2=null;
          acc1=0;
          acc2=0;
          descripition=null;
          matriel_type=null;
          cost_per_unit=0;

    }


        /*
   public void SetName(string Suppliername)
        {
            this.supplier_name = Suppliername;
        }
        public string GetName()
        {
            return this.supplier_name;
        }

        public void Setadd1(string address1)
        {
            this.add1 = address1;
        }
        public string Getadd1()
        {
            return this.add1;
        }

        public void Setadd2(string address2)
        {
            this.add2 = address2;
        }
        public string Getadd2()
        {
            return this.add2;
        }
        public void Setcountry(string Country)
        {
            this.country = Country;
        }
        public string GetCountry()
        {
            return this.country;
        }

        public void Setpostalcode(int PostalCode)
        {
            this.postal_code = PostalCode;
        }
        public int GetPostalCode()
        {
            return this.postal_code;
        }

        public void Setcity(string City)
        {
            this.city = City;
        }
        public string Getcity()
        {
            return this.city;
        }


        public void Setcontact(string Contactfirst)
        {
            this.contact_first = Contactfirst;
        }
        public string Getcontactfirst()
        {
            return this.contact_first;
        }



        public void Setcontactlast(string Contactlast)
        {
            this.contact_last = Contactlast;
        }
        public string Getcontact()
        {
            return this.contact_last;
        }


         public void Setphone(int Phone)
        {
            this.phone_no = Phone;
        }
        public int Getphone()
        {
            return this.phone_no;
        }

        public void Setemail(string Email)
        {
            this.email = Email;
        }
        public string Getemail()
        {
            return this.email;
        }

        */

            
        public void InsertInfo( string name, string address, string city, int postalCode, string Scountry,string Sperson,int Smobile,int SfaxNo,string Semail,string Sbank1,string Sacc1,string Sbank2,string Sacc2 )
        {
            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            

            string query = "INSERT INTO supplier_details (name, address, city, postalCode, country,person,mobileNo,faxNo,email,bank1,account1,bank2,account2) VALUES ('" + name + "','" + address + "','" + city + "','" + postalCode + "','" + Scountry + "','" + Sperson + "','" + Smobile + "','" + SfaxNo + "','" + Semail + "','" + Sbank1 + "','" + Sacc1 + "','" + Sbank2 + "','" + Sacc2 + "')";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.closeconnect();
            
        }

        public void Insertmaterial( string Mtype, string Mname)
        {
            DBAccess db = new DBAccess();
            db.connect();
            // db.openConnect();
            string query = "INSERT INTO material (Mtype, Mname) VALUES ('" + Mtype + "','" + Mname + "')";
           
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

            db.closeconnect();


          
        
        
        }






    }
}
