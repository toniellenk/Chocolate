using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cliente
/// </summary>
public class CarrinhoBD
{
    private BancoDeDados _bancoDeDados;

    public CarrinhoBD(BancoDeDados bancoDeDados)
    {
        _bancoDeDados = bancoDeDados;
    }

    public void SalvaCarrinho(CarrinhoCompras carrinho, bool atualiza = false)
    {
        LimpaProdutosDoCarrinho(carrinho);

        string query = "";
        foreach (var produto in carrinho.ListaProdutos)
        {
            if (atualiza)
            {
                query = "update Produtos set ";
                query += "'" + carrinho.IdCliente + "',";
                query += "'" + produto.IdProduto + "')";
            }

            else
            {
                query = "insert into Produtos values (";
                query += "'" + carrinho.IdCliente + "',";
                query += "'" + produto.IdProduto + "')";
            }

            _bancoDeDados.ExecutaComando(query);
        }
    }

    private void LimpaProdutosDoCarrinho(CarrinhoCompras carrinho)
    {
        var query = "delete Produtos where IdCarrinho = " + carrinho.IdCarrinho.ToString();
        _bancoDeDados.ExecutaComando(query);
    }

    private Cliente ConverteDatarowEmObjeto(DataRow item)
    {
        return new Cliente
        {
            IdCliente = Convert.ToInt32(item["IdCliente"]),
            Login = item["Login"].ToString(),
            Password = item["Password"].ToString(),
            Cpf = item["Cpf"].ToString(),
            Nome = item["Nome"].ToString(),
            Telefone = item["Telefone"].ToString(),
            Endereco = item["Endereco"].ToString(),
        };
    }
}