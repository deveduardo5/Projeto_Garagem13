using MySql.Data.MySqlClient;
using System;

namespace garagem13.banco_de_dados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=garagem13sql;";

        public static MySqlConnection GetConnection/*CriarConexao*/()
        {
            return new MySqlConnection(ConnectionString);
        }

        internal MySqlConnection AbrirConexao()
        {
            throw new NotImplementedException();
        }

        internal void FecharConexao()
        {
            throw new NotImplementedException();
        }
    }
}

//namespace garagem13.banco_de_dados
//{
//    internal class DataBase
//    {
//        // Aqui guardamos as informações para conectar no banco de dados
//        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=garagem13sql;";

//        // Esse objeto representa a conexão com o banco
//        private MySqlConnection connection;

//        // Método para criar uma nova conexão
//        public static MySqlConnection CriarConexao()
//        {
//            // Cria e devolve uma nova conexão usando a ConnectionString
//            return new MySqlConnection(ConnectionString);
//        }

//        // Método para abrir a conexão com o banco
//        public MySqlConnection AbrirConexao()
//        {
//            // Se a conexão ainda não existe, cria uma nova
//            if (connection == null)
//            {
//                connection = new MySqlConnection(ConnectionString);
//            }

//            // Se a conexão está fechada, abre ela
//            if (connection.State != System.Data.ConnectionState.Open)
//            {
//                connection.Open();
//            }

//            return connection;
//        }

//        // Método para fechar a conexão com o banco
//        public void FecharConexao()
//        {
//            // Se a conexão existe e está aberta, fecha e limpa ela
//            if (connection != null && connection.State == System.Data.ConnectionState.Open)
//            {
//                connection.Close();    // Fecha a conexão
//                connection.Dispose();  // Libera a memória usada
//                connection = null;     // Limpa a variável
//            }
//        }
//    }
//}

