using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ChocolateSystem;
using ConsultadorDePessoa;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {

    }

    protected void ConsultarCpf_Click(object sender, EventArgs e)
    {
        var cpfSomenteNumeros = txtCpf.Text.Trim().Replace(".", "").Replace("-", "");
        try
        {
            var resultado = new SOAPService().ConsultarCPFP3(cpfSomenteNumeros, cpfSomenteNumeros);

            if (resultado.Length > 0)
            {
                PreecherCamposComResultadoDaConsulta(resultado);
            }
            else
            {
                Response.Write("<script>alert('Não foi encotrado dados para o CPF informado');</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Não possível consultar o CPF devido ao seguinte erro: '" + ex.Message + ");</script>");
        }
    }

    private void PreecherCamposComResultadoDaConsulta(PessoaPerfil3[] resultado)
    {
        txtNomeCompleto.Text = resultado[0].Nome;

        txtEndereco.Text = resultado[0].Municipio + "; "
            + resultado[0].Logradouro + "; "
            + resultado[0].NumeroLogradouro + "; "
            + resultado[0].CEP;

        txtTelefone.Text = resultado[0].DDD + resultado[0].Telefone;
    }
}