using garagem13.banco_de_dados;
using garagem13.dominio;
using garagem13.Dominio;
using MySql.Data.MySqlClient;

namespace garagem13.Repositorio
{
    internal class CustomizacaoRepositorio
    {
        // LISTAR ARO
        public List<Produto> ListarAros()
        {
            List<Produto> produtos = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                var query = "SELECT * FROM aro ORDER BY id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto()
                    {
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        Modelo = reader.GetString("modelo"),
                        TamanhoEmPolegadas = reader.GetInt32("tamanho_em_polegadas"),
                        Preco = reader.GetDecimal("preco")
                    });
                }
            }

            return produtos;
        }

        // LISTAR QUADRO
        public List<Produto> ListarQuadros()
        {
            List<Produto> produtos = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                var query = "SELECT * FROM quadro ORDER BY id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto()
                    {
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        Modelo = reader.GetString("modelo"),
                        TamanhoEmPolegadas = reader.GetInt32("tamanho_em_polegadas"),
                        Preco = reader.GetDecimal("preco")
                    });
                }
            }

            return produtos;
        }

        // LISTAR COR
        public List<Produto> ListarCores()
        {
            List<Produto> produtos = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                var query = "SELECT * FROM cor ORDER BY id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto()
                    {
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        TipoDeTinta = reader.GetString("tipo_de_tinta"),
                        Preco = reader.GetDecimal("preco")
                    });
                }
            }

            return produtos;
        }

        // LISTAR MOTOR
        public List<Produto> ListarMotores()
        {
            List<Produto> produtos = [];

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                var query = "SELECT * FROM motorizacao ORDER BY id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produtos.Add(new Produto()
                    {
                        Id = reader.GetInt32("id"),
                        Marca = reader.GetString("marca"),
                        Modelo = reader.GetString("modelo"),
                        Potencia = reader.GetInt32("potencia"),
                        Preco = reader.GetDecimal("preco")
                    });
                }
            }

            return produtos;
        }

        //public List<Customizacao> ListarCustomizacao()
        //{
        //    var customizacao = new List<Customizacao>();

        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        string query = "SELECT c.id AS customizacao_id, c.tipo AS tipo_bike, c.cliente_id, cl.nome, cl.email, cl.telefone, a.marca AS marca_aro, a.tamanho_em_polegadas, a.modelo AS modelo_aro, a.preco AS preco_aro, q.marca AS marca_quadro, q.modelo AS modelo_quadro, q.preco AS preco_quadro, co.marca AS marca_tinta, co.tipo_de_tinta, co.preco AS preco_tinta, m.marca AS marca_motor, m.potencia AS potencia_motor, m.modelo AS modelo_motor, m.preco AS preco_motor FROM customizacao c INNER JOIN cliente cl ON c.cliente_id = cl.id INNER JOIN aro a ON c.aro_id = a.id INNER JOIN quadro q ON c.quadro_id = q.id INNER JOIN cor co ON c.cor_id = co.id\r\nINNER JOIN motorizacao m ON c.motorizacao_id = m.id;";
        //        using var cmd = new MySqlCommand(query, conn);
        //        using var reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            customizacao.Add(new Customizacao
        //            {
        //                Id = reader.GetInt32("customizacao_id"),
        //                Aro = reader.GetString("aro"),
        //                Quadro = reader.GetString("quadro"),
        //                Cor = reader.GetString("Cor"),
        //                Motorizacao = reader.GetString("motorizacao"),
        //                Cliente = new Cliente
        //                {
        //                    Id = reader.GetInt32("cliente_id"),
        //                    Nome = reader.GetString("nome"),
        //                    Idade = reader.GetString("idade"),
        //                    Email = reader.GetString("email"),
        //                    Telefone = reader.GetString("telefone")
        //                }
        //            });
        //        }
        //    }

        //    return customizacao;
        //}

        public void Criar(Customizacao customizacao)
        {
            string query = "INSERT INTO customizacao (aro_id, quadro_id, cor_id, motorizacao_id, cliente_id) VALUES (@aro, @quadro, @cor, @motorizacao, @cliente);";

            using var con = DataBase.GetConnection();
            con.Open();

            using var cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@aro", customizacao.Aro);
            cmd.Parameters.AddWithValue("@quadro", customizacao.Quadro);
            cmd.Parameters.AddWithValue("@cor", customizacao.Cor);
            cmd.Parameters.AddWithValue("@motorizacao", customizacao.Motorizacao);
            cmd.Parameters.AddWithValue("@cliente", customizacao.Cliente);
            cmd.ExecuteNonQuery();
        }
    }
}
