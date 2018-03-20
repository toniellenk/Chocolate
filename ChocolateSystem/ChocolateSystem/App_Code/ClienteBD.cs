using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cliente
/// </summary>
public class ClienteBD
{
    public Cliente RetornarClienteCadastrado(BancoDeDados bancoDeDados, int codigoCliente)
    {
        var listaclientes = new List<Cliente>();
        var queryConsulta = "select * from clientes where IdCliente = " + codigoCliente.ToString();
        var massaDados = bancoDeDados.BuscaMassaDeDados(queryConsulta);

        return ConverteDatarowEmObjeto(massaDados.Rows[0]);
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