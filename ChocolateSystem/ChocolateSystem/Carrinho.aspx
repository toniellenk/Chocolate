<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Carrinho.aspx.cs" Inherits="Carrinho" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Seu carrinho de compras.</h3>

    <asp:GridView ID="grdDadosCarrinho" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDadosProdutos_RowCommand">
        <Columns>
            <asp:BoundField DataField="NomeProduto" HeaderText="Produto" />
            <asp:BoundField DataField="PrecoUnitario" HeaderText="Preço Unitário" />
            <asp:BoundField DataField="UnidadesEstoque" HeaderText="Unidades em Estoque" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="RemoveDoCarrinho" runat="server" CommandName="RemoveDoCarrinho" Text="Add. Carrinho"
                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IdProduto")%>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
