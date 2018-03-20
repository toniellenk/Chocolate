using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Produto
/// </summary>
public class ProdutoBD
{
    public List<Produto> RetornarTodosOsProdutos(BancoDeDados bancoDeDados)
    {
        var listaProdutos = new List<Produto>();
        var queryConsulta = "select * from produtos";
        var massaDados = bancoDeDados.BuscaMassaDeDados(queryConsulta);

        foreach (DataRow item in massaDados.Rows)
        {
            listaProdutos.Add(ConverteDatarowEmObjeto(item));
        }
        return listaProdutos;
    }

    private Produto ConverteDatarowEmObjeto(DataRow item)
    {
        return new Produto
        {
            IdProduto = Convert.ToInt32(item["IdProduto"]),
            NomeProduto = item["Descricao"].ToString(),
            PrecoUnitario = Convert.ToDouble(item["Preco"]),
            UnidadesEstoque = Convert.ToInt32(item["EstoqueDisponivel"])
        };
    }
}