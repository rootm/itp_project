using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factory_management 
{
    class invoice
    {
        private int invoiceNo;
        //     DBAccess dba = new DBAccess();

        public DataTable getProductDetails(int orderid)
        {
            DBAccess db = new DBAccess();
            try
            {
                db.connect();
                DataTable dt = new DataTable();

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                string query = "SELECT p.productId,type,p.pages,a.quantity,p.price,a.quantity*p.price FROM product_details p,agent_orderitems a WHERE p.productId=a.productId AND a.orderId='" + orderid + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                dataReader.Close();
                db.connection.Close();

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable getAgentDetails(int agentID)
        {

            DBAccess db = new DBAccess();
            db.connect();

            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT name,address FROM agent_details WHERE agentId = '"+agentID+"'";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;

        }


        public void InsertInfo(int invoiceNo,int orderId,int agentId,string date,int total)
        {

            DBAccess db = new DBAccess();
            db.connect();

            //   int eid;
            string query = "INSERT INTO agent_invoice (invoiceNo,orderId,agentId,date,total) VALUES ('"+invoiceNo+"','"+orderId+"','"+agentId+"','"+date+"','"+total+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public int invoiceNo_
        {
            get
            {
                return invoiceNo;
            }
            set
            {
                invoiceNo = value;
            }
        }
        
        
        private string AgentId;
        public string AgentId_
        {
            get
            {
                return AgentId;
            }
            set
            {
                AgentId = value;
            }
        }
        private string Ag_name;
        public String Ag_name_
        {
            get
            {
                return Ag_name_;
            }
            set
            {
                Ag_name = value;
            }
        }
        private string Ag_address;
        public string Ag_address_
        {
            get { 
                return Ag_address;
            }
            set
            {
                Ag_address = value;
            }
        }
        
        private int OrderId;
    public int OrderId_
    {
        get {
            return OrderId;
            }
        set
            {
                OrderId = value;
            }

    }
        private string date;
        public string date_
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        private string Payment_method;
         public string Paymethod
        {
            get
            {
                return Payment_method;
            }
            set
            {
                Payment_method = value;
            }
            }
        }


  

}


