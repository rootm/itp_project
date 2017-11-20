using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;



namespace Factory_management
{
    class agentClass
    {
        
        DBAccess db = new DBAccess();
       // private static MySqlConnection mycon = db.dbconnection();

        private string id;
        private string name;
        private string addres;
        private string mobile;
        private string landphone;
        private string username;
        private string password;

        public agentClass() { }
        public agentClass(string name, string addres, string mobile, string landphone, string username, string password)
        {
            this.name = name;
            this.addres =addres;
            this.mobile =mobile;
            this.landphone =landphone;
            this.username =username;
            this.password =password;
        }
        public agentClass(string id,string name, string addres, string mobile, string landphone, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.addres = addres;
            this.mobile = mobile;
            this.landphone = landphone;
            this.username = username;
            this.password = password;
        }
        public string getSetId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string getSetName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string getSetAddress
        {
            get { return this.addres; }
            set { this.addres = value; }
        }
        public string getSetMobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }

        public string getSetLandphone
        {
            get { return this.landphone; }
            set { this.landphone = value; }
        }
        public string getSetUsername
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string getSetPassword
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public void insertAgent(string name, string address, string mobile, string landphone, string username, string password)
        {
            try
             {
             
            db.connect();
            /* MySqlCommand cmd = new MySqlCommand("INSERT INTO `sys`.`agent` (`name`, `address`, `mobile`, `landphone`, `username`, `password`) VALUES (@name, @address, @mobile, @landphone, @username, @password);", mycon);
             cmd.Parameters.Add("@name", agent.name);
             cmd.Parameters.Add("@address", agent.addres);
             cmd.Parameters.Add("@mobile", agent.mobile);
             cmd.Parameters.Add("@landphone", agent.landphone);
             cmd.Parameters.Add("@username", agent.username);
             cmd.Parameters.Add("@password", agent.password);
             cmd.BeginExecuteNonQuery();*/


            string query = "INSERT INTO agent_details (name, address, mobile, landNo, userName, password) VALUES ('"+name+"','"+address+"','"+mobile+"','"+landphone+"','"+username+"','"+password+"')";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();



            MessageBox.Show("Data added");
            db.closeconnect();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        }


        public  DataTable getAgents()
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

                string query = "SELECT * FROM agent_details";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                dataReader.Close();
                db.connection.Close();

                return dt;
                /*
                    db.connection.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("select * from `Aagent`", db.connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    db.closeconnect();

                    return dt;
                    */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public DataTable searchAgents(string key)
        {
            string query = "select * from agent_details where agentId='"+key+ "' or name='"+key+"';";
            try
            {
                DBAccess db = new DBAccess();

                db.connect();
                DataTable dt = new DataTable();

                if (db.connection.State == ConnectionState.Closed)
                {
                    db.connection.Open();
                }

             //   string query = "SELECT eid,ename FROM employee WHERE ename = '" + name + "'";

                MySqlCommand cmd = new MySqlCommand(query, db.connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                dataReader.Close();
                db.connection.Close();

                return dt;
                /*
                db.connection.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, db.connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                db.closeconnect();

                return dt;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public void updateAgent(agentClass agent)
        {
            try
            {

             //   DBAccess db = new DBAccess();
                db.connect();

                string query = " UPDATE agent_details set name = '"+name+"', address = '"+addres+"', mobile = '"+mobile+"', landNo = '"+landphone+"', userName = '"+username+"', password = '"+password+"' WHERE agentId = '"+id+"'";

                if (db.connection.State == System.Data.ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
            //    db.connection.Open();
                /* MySqlCommand cmd = new MySqlCommand("UPDATE `sys`.`agent` SET `name`=@name, `address`=@address, `mobile`=@mobile, `landphone`=@landphone, `username`=@username, `password`=@password WHERE `agentId`=@id;", mycon);
                 cmd.Parameters.Add("@id", agent.id);
                 cmd.Parameters.Add("@name", agent.name);
                 cmd.Parameters.Add("@address", agent.addres);
                 cmd.Parameters.Add("@mobile", agent.mobile);
                 cmd.Parameters.Add("@landphone", agent.landphone);
                 cmd.Parameters.Add("@username", agent.username);
                 cmd.Parameters.Add("@password", agent.password);
                 cmd.BeginExecuteNonQuery();*/

            /*    string query = " UPDATE agent set Aname = '"+name+"', Aaddress = '"+addres+"', Amobile = '"+mobile+"', AlandNo = '"+landphone+"', AUname = '"+username+"', Apassword = '"+password+"' WHERE aid = '"+id+"'";
                
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();

*/







                MessageBox.Show("Successfully Updated");
                db.closeconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        public void deleteAgent(string id)
        {
            //string query = "delete from sys.agent where agentId = '5';";
            try
            {
                //mycon.Open();
                /* MySqlCommand cmd = new MySqlCommand("delete from agent where aid = @id;", db.connection);
                 cmd.Parameters.Add("@id", id);
                 cmd.BeginExecuteNonQuery();
                 MySqlDataReader mr;
                 db.connection.Open();
                 mr = cmd.ExecuteReader();
                 */
              //  db.connection.Open();

             

                DBAccess db = new DBAccess();
                db.connect();

                
                //  string query = "DELETE  FROM employee WHERE eid = '" + eid + "'";
                string query = "DELETE FROM agent_details WHERE agentId = '"+id+"'";
                if (db.connection.State == System.Data.ConnectionState.Closed)
                {
                    db.connection.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();

                /*   MySqlCommand cmd = new MySqlCommand(query, db.connection);
                   cmd.ExecuteNonQuery();*/





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
