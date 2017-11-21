using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace Factory_management{
    class Order
    {
         DBAccess db = new DBAccess();
        

        private string id;
        private string productType;
        private string noOfPages;
        private string quantity;
        private string agentID;
        private int orderid;
        private string status;
        private string slipno;
        private string amount;
        private string date;

        public string getSetId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string getSetProductType
        {
            get { return this.productType; }
            set { this.productType = value; }
        }
        public string getSetNoOfPages
        {
            get { return this.noOfPages; }
            set { this.noOfPages = value; }
        }
        public string getSetQuantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public string getSetAgentID
        {
            get { return this.agentID; }
            set { this.agentID = value; }
        }
        public int getSetOrderId
        {
            get { return this.orderid; }
            set { this.orderid = value; }
        }
        public string getSetStatus
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string getSetSlipNo
        {
            get { return this.slipno; }
            set { this.slipno = value; }
        }
        public string getSetAmount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public string getSetDate
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Order() { }
        public Order(string id,string productType,string noOfPages,string quantity,string agentID)
        {
            this.id=id;
            this.productType=productType;
            this.noOfPages=noOfPages;
            this.quantity=quantity;
            this.agentID=agentID;
        }

        public Order(string productType, string noOfPages, string quantity, string agentID)
        {
            this.productType = productType;
            this.noOfPages = noOfPages;
            this.quantity = quantity;
            this.agentID = agentID;
        }
        public Order(string productType, string noOfPages, string quantity, string agentID,int orderid)
        {
            this.productType = productType;
            this.noOfPages = noOfPages;
            this.quantity = quantity;
            this.agentID = agentID;
            this.orderid = orderid;
        }
        public Order(int orderid,string slipno,string amount,string date)
        {
            this.orderid=orderid;
            this.slipno=slipno;
            this.amount=amount;
            this.date=date;
        }



        public int insertOrder()
        {
            try
            {
                
                db.connection.Open();
                
                MySqlCommand cmd = new MySqlCommand("select max(orderId) from sys.order;", db.connection);
                int id = (int)cmd.ExecuteScalar();
                id++;
                cmd.CommandText = "INSERT INTO `sys`.`order` (`status`) VALUES ('pending');";
                cmd.ExecuteScalar();


                db.closeconnect();
                //MessageBox.Show("hey"+id);
                MessageBox.Show("Data added");
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }


        public void setOrderDetails(Order or)
        {

            try
            {

                db.connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `sys`.`order_details` (`productType`, `noOfPages`, `quantity`, `agentId`,`orderid`) VALUES (@type, @nop, @quantity, @agentid,@id);", db.connection);
                
                cmd.Parameters.Add("@type", or.productType);
                cmd.Parameters.Add("@nop", or.noOfPages);
                cmd.Parameters.Add("@quantity", or.quantity);
                cmd.Parameters.Add("@agentid", or.agentID);
                cmd.Parameters.Add("@id", or.orderid);
                //cmd.ExecuteReader();
                cmd.ExecuteScalar();
                db.closeconnect();
                //MessageBox.Show("Data added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public DataTable getOrders()
        {
            try
            {
                DBAccess db = new DBAccess();

                db.connect();
                DataTable dt = new DataTable();

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                string query = "SELECT ao.orderId,ao.agentId,ad.name,ao.orderDate,ao.total,ao.status FROM agent_orders ao,agent_details ad WHERE ad.agentId=ao.agentId";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                dataReader.Close();
                db.connection.Close();

                
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public DataTable searchOrders(string key)
        {
            string query = "SELECT ao.orderId,ao.agentId,ad.name,ao.orderDate,ao.total,ao.status FROM agent_orders ao,agent_details ad WHERE ad.agentId=ao.agentId AND ao.agentId="+key+"; ";
            try
            {

                db.connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, db.connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.closeconnect();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public DataTable getPendingOrders(string idd)
        {
            string query = "select  distinct order.orderId,status from sys.order  join sys.order_details on order.orderId = order_details.orderid where order_details.agentId ='" + idd+"' and order.status = 'pending'; ";
            try
            {

                db.connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, db.connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.closeconnect();

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
    
        }



        public void payOrder(Order or)
        {

            try
            {
                string query = "UPDATE `sys`.`order` SET `slipno`='" + or.slipno + "',`status`='paid', `amount`='" + or.amount + "', `date`='" + or.date + "' WHERE `orderId`='" + or.orderid + "';";
                db.connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteScalar();
                db.closeconnect();
                MessageBox.Show("done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public DataTable searchOrder(string key)
        {
            string query = "SELECT idorder,productType,agentId,noOfPages,quantity FROM `sys`.`order_details` where orderid='"+key+"';";
            try
            {

                db.connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, db.connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.closeconnect();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public void updateOrder(int id,string type,string quantity,string nop) 
        {
            try
            {
                string query = "UPDATE `sys`.`order_details` SET `productType`='"+type+"', `noOfPages`='"+nop+"', `quantity`='"+quantity+"' WHERE `idorder`='"+id+"';";
                db.connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteScalar();
                db.closeconnect();
                MessageBox.Show("done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteOrder(string id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from sys.order_details where idorder = @id;", db.connection);
                cmd.Parameters.Add("@id", id);
                cmd.BeginExecuteNonQuery();
                MySqlDataReader mr;
                db.connection.Open();
                mr = cmd.ExecuteReader();

                MessageBox.Show("Successfully Deleted");
                db.closeconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
}
