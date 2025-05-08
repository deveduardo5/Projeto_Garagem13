using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garagem13.Repositorio
{
    internal class CustomizacaoRepositorio
    {
        public List<Customizacao> ListarCustomizacao()
        {
            var customizacao = new List<Customizacao>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.id AS customizacao_id, c.tipo AS tipo_bike, c.cliente_id, cl.nome, cl.email, cl.telefone, a.marca AS marca_aro, a.tamanho_em_polegadas, a.modelo AS modelo_aro, a.preco AS preco_aro, q.marca AS marca_quadro, q.modelo AS modelo_quadro, q.preco AS preco_quadro, co.marca AS marca_tinta, co.tipo_de_tinta, co.preco AS preco_tinta, m.marca AS marca_motor, m.potencia AS potencia_motor, m.modelo AS modelo_motor, m.preco AS preco_motor FROM customizacao c INNER JOIN cliente cl ON c.cliente_id = cl.id INNER JOIN aro a ON c.aro_id = a.id INNER JOIN quadro q ON c.quadro_id = q.id INNER JOIN cor co ON c.cor_id = co.id\r\nINNER JOIN motorizacao m ON c.motorizacao_id = m.id;";
                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customizacao.Add(new Customizacao
                    {
                        Id = reader.GetInt32("customizacao_id"),
                        Aro = reader.GetString("aro"),
                        Quadro = reader.GetString("quadro"),
                        Cor = reader.GetString("Cor"),
                        Motorizacao = reader.GetString("motorizacao"),
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32("cliente_id"),
                            Nome = reader.GetString("nome"),
                            Idade = reader.GetString("idade"),
                            Email = reader.GetString("email"),
                            Telefone = reader.GetString("telefone")
                        }
                    });
                }
            }

            return customizacao;
        }

        //public void InserirPedido(Customizacao novoPedido)
        //{
        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        string queryCustomizacao = "INSERT INTO customizacao (aro_id, quadro_id, cor_id, motorizacao_id) " +
        //                               "VALUES (@aro_id, @quadro_id, @cor_id, @motorizacao_id);";
        //        using (var cmd = new MySqlCommand(queryCustomizacao, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@aro", novoPedido.Aro);
        //            cmd.Parameters.AddWithValue("@quadro", novoPedido.Quadro);
        //            cmd.Parameters.AddWithValue("@cor", novoPedido.Cor);
        //            cmd.Parameters.AddWithValue("@motorizacao", novoPedido.Motorizacao);
        //            cmd.ExecuteNonQuery();
        //        }

        //        int idCliente = -1;
        //        string queryidCliente = "SELECT id FROM Cliente " +
        //                                    "WHERE nome = @nome " +
        //                                    "AND idade = @idade " +
        //                                    "AND email = @email " +
        //                                    "AND telefone = @telefone ;";

        //        using (var cmd = new MySqlCommand(queryidCliente, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@nome", novoPedido.Cliente.Nome);
        //            cmd.Parameters.AddWithValue("@numero", novoPedido.Cliente.Idade);
        //            cmd.Parameters.AddWithValue("@bairro", novoPedido.Cliente.Email);
        //            cmd.Parameters.AddWithValue("@municipio", novoPedido.Cliente.Telefone);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                idCliente = reader.Read() ? reader.GetInt32("id") : -1;
        //            }
        //        }

        //        string query = "INSERT INTO customizacao (idCliente, aro, quadro, cor, motorizacao) " +
        //                       "VALUES (@idCliente, @aro, @quadro, @cor, @motorizacao);";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@idCliente", idCliente);
        //            cmd.Parameters.AddWithValue("@aro", novoPedido.Aro);
        //            cmd.Parameters.AddWithValue("@quadro", novoPedido.Quadro);
        //            cmd.Parameters.AddWithValue("@cor", novoPedido.Cor);
        //            cmd.Parameters.AddWithValue("@motorizacao", novoPedido.Motorizacao);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public void Criar(Customizacao customizacao)
        //{
        //    using (var con = DataBase.GetConnection())
        //    {
        //        con.Open();
        //        string query = "INSERT INTO customizacao (aro, quadro, cor, tipo, motorizacao, cliente_id) VALUES (@aro, @quadro, @cor, @tipo, @motorizacao, @cliente_id);";

        //        using (var cmd = new MySqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@aro", customizacao.Aro);
        //            cmd.Parameters.AddWithValue("@quadro", customizacao.Quadro);
        //            cmd.Parameters.AddWithValue("@cor", customizacao.Cor);
        //            cmd.Parameters.AddWithValue("@tipo", customizacao.Tipo);
        //            cmd.Parameters.AddWithValue("@motorizacao", customizacao.Motorizacao);
        //            cmd.Parameters.AddWithValue("@cliente_id", customizacao.ClienteId);
        //        }
        //    }
        //}
    }
}
