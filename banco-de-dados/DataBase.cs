using MySql.Data.MySqlClient;


//namespace garagem13.banco_de_dados
//{
//    internal class DataBase
//    {
//        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=garagem13sql;";

//        public static MySqlConnection GetConnection/*CriarConexao*/()
//        {
//            return new MySqlConnection(ConnectionString);
//        }

//        internal MySqlConnection AbrirConexao()
//        {
//            throw new NotImplementedException();
//        }

//        internal void FecharConexao()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

namespace garagem13.banco_de_dados
{
    internal class DataBase
    {
         
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";

<<<<<<< HEAD
=======
        private MySqlConnection connection;

>>>>>>> 56592d81d11480f5ae7830ef1337b50821ebe56b
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
<<<<<<< HEAD
    }
}



=======

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
    }
}

>>>>>>> 56592d81d11480f5ae7830ef1337b50821ebe56b
