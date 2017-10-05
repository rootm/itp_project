using MySql.Data.MySqlClient;


namespace Factory_management
{
    class DBAccess
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public string connectionString;

        public DBAccess()
        {
            server = "localhost";
            database = "dumindubooks";
            uid = "root";
            password = "";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
           
            
        }
        public bool connect()
        {
            try
            {
             connection = new MySqlConnection(connectionString);
              connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;               
            }
         
           
        }

    

        public void closeconnect()
		{
			//connection = new MySqlConnection(connectionString);
            connection.Close();
		}


    }
}
