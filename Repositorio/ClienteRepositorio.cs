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

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

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
                        Endereco = new Endereco
                        {
                            Id = reader.GetInt32("id_endereco"),
                            Logradouro = reader.GetString("logradouro"),
                            Numero = reader.GetString("numero"),
                            Complemento = complemento,
                            Bairro = reader.GetString("bairro"),
                            Municipio = reader.GetString("municipio"),
                            Estado = reader.GetString("estado"),
                            CEP = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;

        }

        public Cliente? BuscarClientePorEmail(string email)
        {
            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id WHERE c.email = @param;";
            return BuscarClientePorUnique(query, email);
        }

        public Cliente? BuscarClientePorTelefone(string telefone)
        {
            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id WHERE c.telefone = @param;";
            return BuscarClientePorUnique(query, telefone);
        }

        public void InserirCliente(Cliente novoCliente)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                                       "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.Endereco.Complemento);
                    cmd.ExecuteNonQuery();
                }

                int idEndereco = -1;
                string queryIdEndereco = "SELECT id FROM endereco " +
                                            "WHERE logradouro = @logradouro " +
                                            "AND numero = @numero " +
                                            "AND bairro = @bairro " +
                                            "AND municipio = @municipio " +
                                            "AND estado = @estado " +
                                            "AND cep = @cep " +
                                            "AND complemento = @complemento;";
                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.Endereco.Complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        idEndereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }

                string query = "INSERT INTO cliente (nome, idade, id_endereco, email, telefone) " +
                               "VALUES (@nome, @idade, @id_endereco, @email, @telefone);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                    cmd.Parameters.AddWithValue("@idade", novoCliente.Idade);
                    cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                    cmd.Parameters.AddWithValue("@email", novoCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.Telefone);
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

                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";

                    return new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Idade = reader.GetString("idade"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Endereco = new Endereco
                        {
                            Id = reader.GetInt32("id_endereco"),
                            Logradouro = reader.GetString("logradouro"),
                            Numero = reader.GetString("numero"),
                            Complemento = complemento,
                            Bairro = reader.GetString("bairro"),
                            Municipio = reader.GetString("municipio"),
                            Estado = reader.GetString("estado"),
                            CEP = reader.GetString("cep")
                        }
                    };
                }
            }
        }
    }
}