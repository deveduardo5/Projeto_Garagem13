using MySql.Data.MySqlClient;

namespace garagem13.banco_de_dados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=garagem13sql;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
