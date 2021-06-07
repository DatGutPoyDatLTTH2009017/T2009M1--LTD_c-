using System.Data;
using System.Security.AccessControl;
using MySql.Data.MySqlClient;

namespace duongsinh2.Helper
{
    public static class ConnectionHelper
    {
        private static MySqlConnection connection = null;


        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection();
                connection.ConnectionString = $"server=127.0.0.1;database=quanlyduongpho;UID=root;password=;port=3306";
                connection.Open();
                return connection;
            }
            else
            {
                return connection;
            }
        }
        
        
    }
}