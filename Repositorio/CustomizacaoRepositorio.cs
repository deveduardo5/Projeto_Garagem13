using garagem13.banco_de_dados;
using garagem13.dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garagem13.Repositorio
{
    internal class CustomizacaoRepositorio
    {
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
