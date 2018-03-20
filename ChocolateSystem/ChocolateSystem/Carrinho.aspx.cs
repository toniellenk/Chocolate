using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Carrinho : Page
{
    public CarrinhoCompras CarrinhoDeCompras
    {
        get
        {
            if (Session["_carrinhoCompras"] == null)
            {
                Session["_carrinhoCompras"] = new CarrinhoCompras();
            }

            return (CarrinhoCompras)Session["_carrinhoCompras"];
        }

        set
        {
            Session["_carrinhoCompras"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            //SalvarCarrihoNoBanco();
            CarregarProdutos();
    }

    private void SalvarCarrihoNoBanco()
    {
        var bancoDeDados = new BancoDeDados();
        var carrinhoBD = new CarrinhoBD(bancoDeDados);
        carrinhoBD.SalvaCarrinho(CarrinhoDeCompras);
    }

    private void CarregarProdutos()
    {
        try
        {
            var produto = new ProdutoBD();
            var bancoDeDados = new BancoDeDados();
            List<Produto> listaProdutos = CarrinhoDeCompras?.ListaProdutos;
            grdDadosCarrinho.DataSource = listaProdutos;
            grdDadosCarrinho.DataBind();
        }
        catch (Exception ex)
        {
            throw new Exception("Não foi possível consultar os produtos: " + ex.Message);
        }
    }

    protected void grdDadosProdutos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("RemoveDoCarrinho"))
        {
            string idProduto = e.CommandArgument.ToString();
            RemoverProdutoNoCarrinho(Convert.ToInt32(idProduto));
        }
    }

    private void RemoverProdutoNoCarrinho(int v)
    {
        throw new NotImplementedException();
    }
}