using System.Collections.Generic;

/// <summary>
/// Summary description for Produto
/// </summary>
public class CarrinhoCompras
{
    public int IdCarrinho { get; set; }
    public int IdCliente { get; set; }
    public List<Produto> ListaProdutos { get; set; }
}