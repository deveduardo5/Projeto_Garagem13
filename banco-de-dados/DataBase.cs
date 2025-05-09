using MySql.Data.MySqlClient;

namespace garagem13.banco_de_dados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "server=localhost;user=root;password=;database=garagem13;";

       public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
