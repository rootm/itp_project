using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_management
{
    class department
    {
        DBAccess db = new DBAccess();

        public void insertDepartment(string department)
        {

            db.connect();

            string query = "INSERT INTO department_details (departmentName) VALUES ('"+department+"')";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void updateDepartment(string department , int departmentId)
        {

            db.connect();

            string query = "UPDATE  department_details SET departmentName = '" + department + "' WHERE departmentId = '"+departmentId+"'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public void deleteDepartment(int departmentId)
        {

            db.connect();

            string query = "DELETE FROM  department_details  WHERE departmentId = '" + departmentId + "'";

            if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();

        }

        public DataTable getDepartment()
        {


            db.connect();
            DataTable dt = new DataTable();

            if (db.connection.State == ConnectionState.Closed)
            {
                db.connection.Open();
            }

            string query = "SELECT * FROM department_details";

            MySqlCommand cmd = new MySqlCommand(query, db.connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dt.Load(dataReader);

            dataReader.Close();
            db.connection.Close();

            return dt;
        }

    }
}
