using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio
{
    //internal class ClienteRepositorio
    //{
    //    public void Criar(Cliente cliente)
    //    {
    //        using (var con = DataBase.GetConnection())
    //        {
    //            con.Open();
    //            string query = "INSERT INTO cliente (nome, idade, id_endereco, email, telefone) VALUES (@nome, @idade, @id_endereco, @email, @telefone);";
    //            using (var cmd = new MySqlCommand(query, con))
    //            {
    //                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
    //                cmd.Parameters.AddWithValue("@idade", cliente.Idade);
    //                cmd.Parameters.AddWithValue("@id_endereco", cliente.IdEndereco);
    //                cmd.Parameters.AddWithValue("@email", cliente.Email);
    //                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
    //                cmd.ExecuteNonQuery();
    //            }
    //        }
    //    }

    //    public Cliente BuscarPorId(int id)
    //    {
    //        using (var con = DataBase.GetConnection())
    //        {
    //            con.Open();
    //            string query = "SELECT * FROM cliente WHERE id = @id;";
    //            using (var cmd = new MySqlCommand(query, con))
    //            {
    //                cmd.Parameters.AddWithValue("@id", id);
    //                using (var reader = cmd.ExecuteReader())
    //                {
    //                    if (reader.Read())
    //                    {
    //                        return new Cliente
    //                        {
    //                            Id = reader.GetInt32("id"),
    //                            Nome = reader.GetString("nome"),
    //                            Idade = reader.GetInt32("idade"),
    //                            IdEndereco = reader.GetInt32("id_endereco"),
    //                            Email = reader.GetString("email"),
    //                            Telefone = reader.GetInt32("telefone")
    //                        };
    //                    }
    //                }
    //            }
    //        }
    //        return null;
    //    }
    //}

    internal class ClienteRepositorio
    {
        public void Criar(Cliente cliente)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO cliente (nome, idade, id_endereco, email, telefone) VALUES (@nome, @idade, @id_endereco, @email, @telefone);";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@idade", cliente.Idade);
                    cmd.Parameters.AddWithValue("@id_endereco", cliente.IdEndereco);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Cliente BuscarPorId(int id)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM cliente WHERE id = @id;";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cliente
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Idade = reader.GetInt32("idade"),
                                IdEndereco = reader.GetInt32("id_endereco"),
                                Email = reader.GetString("email"),
                                Telefone = reader.GetString("telefone")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
