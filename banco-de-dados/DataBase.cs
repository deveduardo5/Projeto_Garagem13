using MySql.Data.MySqlClient;

namespace garagem13.banco_de_dados
{
    //internal class DataBase
    //{
    //    public static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=garagem13sql;";

    //    public static MySqlConnection GetConnection()
    //    {
    //        return new MySqlConnection(ConnectionString);
    //    }
    //}

    internal class DataBase
    {
        private static readonly string ConnectionString = "server=localhost;user=root;password=;database=garagem13;";
        private MySqlConnection connection;

        public MySqlConnection AbrirConexao()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(ConnectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public void FecharConexao()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
