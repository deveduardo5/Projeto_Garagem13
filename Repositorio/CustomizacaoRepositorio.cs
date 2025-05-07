using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;
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
        //public List<Customizacao> ListarCustomizacao()
        //{
        //    var customizacao = new List<Customizacao>();

        //    using (var conn = DataBase.GetConnection())
        //    {
        //        conn.Open();

        //        string query = "SELECT\r\n    c.id AS customizacao_id,\r\n    c.tipo AS tipo_bike,\r\n    c.cliente_id,\r\n    cl.nome,\r\n    cl.email,\r\n    cl.telefone,\r\n        \r\n    a.marca AS marca_aro,\r\n    a.tamanho_em_polegadas,\r\n    a.modelo AS modelo_aro,\r\n    a.preco AS preco_aro,\r\n   \r\n    q.marca AS marca_quadro,\r\n    q.modelo AS modelo_quadro,\r\n    q.preco AS preco_quadro,\r\n    \r\n    co.marca AS marca_tinta,\r\n    co.tipo_de_tinta,\r\n    co.preco AS preco_tinta,\r\n    \r\n    m.marca AS marca_motor,\r\n    m.potencia AS potencia_motor,\r\n    m.modelo AS modelo_motor,\r\n    m.preco AS preco_motor\r\nFROM \r\n    customizacao c\r\nINNER JOIN cliente cl ON c.cliente_id = cl.id\r\nINNER JOIN aro a ON c.aro_id = a.id\r\nINNER JOIN quadro q ON c.quadro_id = q.id\r\nINNER JOIN cor co ON c.cor_id = co.id\r\nINNER JOIN motorizacao m ON c.motorizacao_id = m.id;";

        //        using var cmd = new MySqlCommand(query, conn);
        //        using var reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            customizacao.Add(new Customizacao
        //            {
        //                Id_customizacao = reader.GetInt32("id"),
        //                Aro = reader.GetInt32("Aro "),
        //                Quadro = reader.GetString("Quadro"),
        //                Tinta = reader.GetString("Tinta"),
        //                Motorizacao = reader.GetString("Motorizacao"),

        //                Cliente = new Cliente 
        //                { 
        //                }


        //            });
        //        }
        //    }

        //    return customizacao;

        //}





        public void Criar(Customizacao customizacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO customizacao (aro, quadro, cor, tipo, motorizacao, cliente_id) VALUES (@aro, @quadro, @cor, @tipo, @motorizacao, @cliente_id);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aro", customizacao.Aro);
                    cmd.Parameters.AddWithValue("@quadro", customizacao.Quadro);
                    cmd.Parameters.AddWithValue("@cor", customizacao.Cor);
                    cmd.Parameters.AddWithValue("@tipo", customizacao.Tipo);
                    cmd.Parameters.AddWithValue("@motorizacao", customizacao.Motorizacao);
                    cmd.Parameters.AddWithValue("@cliente_id", customizacao.ClienteId);
                }
            }
        }
    }
}
