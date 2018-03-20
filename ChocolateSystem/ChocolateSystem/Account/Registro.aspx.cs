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
        txtCpf.Text.Trim();
        var consultador = new ConsultadorDePessoa.SOAPService();
        var resultado =  consultador.ConsultarCPFP3("03501349106","03501349106");
    }
}