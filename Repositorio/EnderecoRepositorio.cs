using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio
{
    internal class EnderecoRepositorio
    {
        public void Criar(Endereco endereco)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO endereco (logradouro, numero, complemento, bairro, municipio, estado, cep) VALUES (@logradouro, @numero, @complemento, @bairro, @municipio, @estado, @cep);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", endereco.CEP);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
