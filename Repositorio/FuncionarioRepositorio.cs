using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio

{
    internal class FuncionarioRepositorio
    {
        //    public void AdicionarFuncionarios()
        //    {
        //        List<Funcionario> funcionarios = new List<Funcionario>
        //{
        //    new Funcionario { Nome = "Matheus Selpa", Email = "mselpa@garagem13.com", Senha = "24681012" },
        //    new Funcionario { Nome = "Gabriel Gomes", Email = "ggomes@garagem13.com", Senha = "12345678" },
        //    new Funcionario { Nome = "Daniel Silva", Email = "dsilva@garagem13.com", Senha = "36912157" }
        //};
        //        using (var con = DataBase.GetConnection())
        //        {
        //            con.Open();
        //            foreach (var funcionario in funcionarios)
        //            {
        //                string query = "INSERT INTO funcionario (nome, email, senha) VALUES (@nome, @email, @senha);";
        //                using (var cmd = new MySqlCommand(query, con))
        //                {
        //                    cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
        //                    cmd.Parameters.AddWithValue("@email", funcionario.Email);
        //                    cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }


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
