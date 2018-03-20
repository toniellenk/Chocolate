using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            CarregarProdutos();
    }

    private void CarregarProdutos()
    {
        try
        {
            var produto = new ProdutoBD();
            var bancoDeDados = new BancoDeDados();
            List<Produto> listaProdutos = produto.RetornarTodosOsProdutos(bancoDeDados);
            grdDadosProdutos.DataSource = listaProdutos;
            grdDadosProdutos.DataBind();
        }
        catch (Exception ex)
        {
            throw new Exception("Não foi possível consultar os produtos: " + ex.Message);
        }
    }

    protected void grdDadosProdutos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddCarrinho"))
        {
            string idProduto = e.CommandArgument.ToString();
        }
    }
}
