using System.Data;
using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT  c.* FROM cliente c;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";

                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Idade = reader.GetString("idade"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Logradouro = reader.GetString("logradouro"),
                        Numero = reader.GetString("numero"),
                        Complemento = complemento,
                        Bairro = reader.GetString("bairro"),
                        Municipio = reader.GetString("municipio"),
                        Estado = reader.GetString("estado"),
                        CEP = reader.GetString("cep")
                    });
                }
            }

            return clientes;

        }

        public Cliente? BuscarClientePorEmail(string email)
        {
            string query = "SELECT c.* FROM cliente c WHERE c.email = @param";
            return BuscarClientePorUnique(query, email);
        }

        public Cliente? BuscarClientePorTelefone(string telefone)
        {
            string query = "SELECT c.* FROM cliente c WHERE c.telefone = @param";
            return BuscarClientePorUnique(query, telefone);
        }

        public void InserirCliente(Cliente novoCliente)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO cliente (nome, idade, email, telefone, logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                               "VALUES (@nome, @idade, @email, @telefone, @logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                    cmd.Parameters.AddWithValue("@idade", novoCliente.Idade);
                    cmd.Parameters.AddWithValue("@email", novoCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.Telefone);


                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.Numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.Municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.Estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.CEP);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.Complemento);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Cliente? BuscarClientePorUnique(string query, string param)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", param);

                    using var reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Idade = reader.GetString("idade"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Logradouro = reader.GetString("logradouro"),
                        Numero = reader.GetString("numero"),
                        Complemento = reader.GetString("complemento"),
                        Bairro = reader.GetString("bairro"),
                        Municipio = reader.GetString("municipio"),
                        Estado = reader.GetString("estado"),
                        CEP = reader.GetString("cep")
                    };
                }
            }
        }
    }
}