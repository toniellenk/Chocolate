using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ChocolateSystem;


public class BancoDeDados
{
    private SqlConnection _sqlConection;

    public BancoDeDados()
    {
        string stringDeConexao = "server='DESKTOP-5QQDCV3\\MSSQLSERVEREXAME'; database='Chocolate'; user='sa'; password=123456; integrated security='false' ";
        _sqlConection = new SqlConnection(stringDeConexao);
    }

    public DataTable BuscaMassaDeDados(string query) {

        _sqlConection.Open();

        var sqlCommand = new SqlCommand(query, _sqlConection);
        var resultado = new DataTable();
        resultado.Load(sqlCommand.ExecuteReader());
        _sqlConection.Close();

        return resultado;
    }
}