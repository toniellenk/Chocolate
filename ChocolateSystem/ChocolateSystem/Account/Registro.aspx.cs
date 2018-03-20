using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ChocolateSystem;
using ConsultadorDePessoa;

public partial class Account_Register : Page
{
    protected void CriarCliente_Click(object sender, EventArgs e)
    {
        try
        {
            var bancoDeDados = new BancoDeDados();
            var clienteBD = new ClienteBD(bancoDeDados);
            var novoCliente = PrencherClienteParaSalvamento();
            clienteBD.CadastraCliente(novoCliente);

            Response.Write("<script>alert('Cadastro realizado com sucesso');</script>");

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Não foi possível cadastrar o cliente: '" + ex.Message + ");</script>");
        }
    }

    private Cliente PrencherClienteParaSalvamento()
    {
        return new Cliente() {
            Login = Login.Text,
            Password = Password.Text,
            Cpf = txtCpf.Text,
            Nome = txtNomeCompleto.Text,
            Telefone = txtTelefone.Text,
            Endereco = txtEndereco.Text,
        };
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