using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio

{
    internal class FuncionarioRepositorio
    {
        public Funcionario? BuscarPorEmailSenha(string email, string senha)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM funcionario WHERE email = @email AND senha = @senha;";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Funcionario
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("email"),
                                Senha = reader.GetString("senha")
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
