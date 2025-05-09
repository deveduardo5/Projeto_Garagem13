using garagem13.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace garagem13.Dominio
{
    internal class ListaCustomizacao
    {
        //        SELECT
        //    c.id AS customizacao_id,
        //    cl.nome,
        //    cl.email,
        //    cl.telefone,
        //    a.marca AS marca_aro,
        //    a.tamanho_em_polegadas,
        //    a.modelo AS modelo_aro,
        //    a.preco AS preco_aro,
        //    q.marca AS marca_quadro,
        //    q.modelo AS modelo_quadro,
        //    q.preco AS preco_quadro,
        //    co.marca AS marca_tinta,
        //    co.tipo_de_tinta,
        //    co.preco AS preco_tinta,
        //    m.marca AS marca_motor,
        //    m.potencia AS potencia_motor,
        //    m.modelo AS modelo_motor,
        //    m.preco AS preco_motor
        //FROM
        //    customizacao c
        //        INNER JOIN
        //    cliente cl ON c.cliente_id = cl.id
        //        INNER JOIN
        //    aro a ON c.aro_id = a.id
        //        INNER JOIN
        //    quadro q ON c.quadro_id = q.id
        //        INNER JOIN
        //    cor co ON c.cor_id = co.id
        //        INNER JOIN
        //    motorizacao m ON c.motorizacao_id = m.id
        //    WHERE c.cliente_id = @cliente_id;

    }
}
