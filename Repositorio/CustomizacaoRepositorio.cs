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

        public List<ListaCustomizacao> ListarCustomizacao(int clienteId)
        {
            var lista = new List<ListaCustomizacao>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = @" SELECT c.id AS customizacao_id, c.cliente_id, cl.nome, cl.email, cl.telefone, a.marca AS marca_aro, a.tamanho_em_polegadas, a.modelo AS modelo_aro,
                a.preco AS preco_aro, q.marca AS marca_quadro, q.modelo AS modelo_quadro, q.preco AS preco_quadro, co.marca AS marca_tinta, co.tipo_de_tinta, co.preco AS preco_tinta,
                m.marca AS marca_motor, m.modelo AS modelo_motor, m.potencia AS potencia_motor, m.preco AS preco_motor FROM customizacao c JOIN cliente cl ON c.cliente_id = cl.id
                JOIN aro a ON c.aro_id = a.id JOIN quadro q ON c.quadro_id = q.id JOIN cor co ON c.cor_id = co.id JOIN motorizacao m ON c.motorizacao_id = m.id 
                WHERE c.cliente_id = @cliente_id;";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cliente_id", clienteId);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ListaCustomizacao
                    {
                        CustomizacaoId = reader.GetInt32("customizacao_id"),
                        ClienteId = reader.GetInt32("cliente_id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),

                        MarcaAro = reader.GetString("marca_aro"),
                        TamanhoAro = reader.GetInt32("tamanho_em_polegadas"),
                        ModeloAro = reader.GetString("modelo_aro"),
                        PrecoAro = reader.GetDecimal("preco_aro"),

                        MarcaQuadro = reader.GetString("marca_quadro"),
                        ModeloQuadro = reader.GetString("modelo_quadro"),
                        PrecoQuadro = reader.GetDecimal("preco_quadro"),

                        MarcaTinta = reader.GetString("marca_tinta"),
                        TipoTinta = reader.GetString("tipo_de_tinta"),
                        PrecoTinta = reader.GetDecimal("preco_tinta"),

                        MarcaMotor = reader.GetString("marca_motor"),
                        ModeloMotor = reader.GetString("modelo_motor"),
                        PotenciaMotor = reader.GetInt32("potencia_motor"),
                        PrecoMotor = reader.GetDecimal("preco_motor")
                    });
                }
            }

            return lista;
        }

        //public List<Customizacao> ListarCustomizacao()
        //{
        //    var customizacao = new List<Customizacao>();

        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        string query = "SELECT \r\n    c.id AS customizacao_id,\r\n    c.tipo AS tipo_bike,\r\n    c.cliente_id,\r\n    cl.nome,\r\n    cl.email,\r\n    cl.telefone,\r\n    a.marca AS marca_aro,\r\n    a.tamanho_em_polegadas,\r\n    a.modelo AS modelo_aro,\r\n    a.preco AS preco_aro,\r\n    q.marca AS marca_quadro,\r\n    q.modelo AS modelo_quadro,\r\n    q.preco AS preco_quadro,\r\n    co.marca AS marca_tinta,\r\n    co.tipo_de_tinta,\r\n    co.preco AS preco_tinta,\r\n    m.marca AS marca_motor,\r\n    m.potencia AS potencia_motor,\r\n    m.modelo AS modelo_motor,\r\n    m.preco AS preco_motor\r\nFROM\r\n    customizacao c\r\n        INNER JOIN\r\n    cliente cl ON c.cliente_id = cl.id\r\n        INNER JOIN\r\n    aro a ON c.aro_id = a.id\r\n        INNER JOIN\r\n    quadro q ON c.quadro_id = q.id\r\n        INNER JOIN\r\n    cor co ON c.cor_id = co.id\r\n        INNER JOIN\r\n    motorizacao m ON c.motorizacao_id = m.id\r\n    WHERE c.cliente_id = @cliente_id;";
        //        using var cmd = new MySqlCommand(query, conn);
        //        using var reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            customizacao.Add(new Customizacao
        //            {
        //                Id = reader.GetInt32("customizacao_id"),
        //                Aro = reader.GetInt32("aro"),
        //                Quadro = reader.GetInt32("quadro"),
        //                Cor = reader.GetInt32("Cor"),
        //                Motorizacao = reader.GetInt32("motorizacao"),
        //                ListaCustomizacao = new ListaCustomizacao
        //                {
        //                    ClienteNome = reader.GetString("cl.nome"),
        //                    ClienteEmail = reader.GetString("cl.email"),
        //                    ClienteTelefone = reader.GetString("cl.telefone"),
        //                    AroMarca = reader.GetString("a.marca"),
        //                    AroTamanhoEmPolegadas = reader.GetInt32("a.tamanho_em_polegadas"),
        //                    AroModelo = reader.GetString("a.modelo"),
        //                    AroPreco = reader.GetDecimal("a.preco"),
        //                    QuadroMarca = reader.GetString("q.marca"),
        //                    QuadroModelo = reader.GetString("q.modelo"),
        //                    QuadroPreco = reader.GetDecimal("q.preco"),
        //                    CorMarca = reader.GetString("co.marca"),
        //                    CorTipo = reader.GetString("co.tipo"),
        //                    CorPreco = reader.GetDecimal("co.preco"),
        //                    MarcaMotor = reader.GetString("m.marca"),
        //                    MotorPotencia = reader.GetInt32("m.potencia"),
        //                    MotorModelo = reader.GetString("m.modelo"),
        //                    MotorPreco = reader.GetDecimal("m.preco")
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
