using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : Page
{
    public CarrinhoCompras CarrinhoDeCompras
    {
        get {
            if (Session["_carrinhoCompras"] == null)
            {
                Session["_carrinhoCompras"] = new CarrinhoCompras();
            }

            return (CarrinhoCompras)Session["_carrinhoCompras"]; }

        set {
            Session["_carrinhoCompras"] = value;
        }
    }

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
            InserirProdutoNoCarrinho(Convert.ToInt32(idProduto));
        }
    }

    private void InserirProdutoNoCarrinho(int idProduto)
    {
        if (CarrinhoDeCompras.ListaProdutos == null)
        {
            CarrinhoDeCompras.ListaProdutos = new List<Produto>() { new Produto() { IdProduto = idProduto } };
        }
        else
        {
            CarrinhoDeCompras.ListaProdutos.Add(new Produto() { IdProduto = idProduto });
        }
    }
}
