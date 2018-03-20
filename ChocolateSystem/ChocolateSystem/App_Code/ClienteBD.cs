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
    private BancoDeDados _bancoDeDados;

    public ClienteBD(BancoDeDados bancoDeDados)
    {
        _bancoDeDados = bancoDeDados;
    }


    public Cliente RetornarClienteCadastrado(int codigoCliente)
    {
        var listaclientes = new List<Cliente>();
        var queryConsulta = "select * from clientes where IdCliente = " + codigoCliente.ToString();
        var massaDados = _bancoDeDados.BuscaMassaDeDados(queryConsulta);

        return ConverteDatarowEmObjeto(massaDados.Rows[0]);
    }

    public void CadastraCliente(Cliente cliente)
    {
        var query = "insert into Clientes values (";
        query += "'" + cliente.Login + "',";
        query += "'" + cliente.Password + "',";
        query += "'" + cliente.Cpf + "',";
        query += "'" + cliente.Nome + "',";
        query += "'" + cliente.Telefone + "',";
        query += "'" + cliente.Endereco + "')";

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