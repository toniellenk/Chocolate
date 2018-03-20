<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Bem vindo ao chocolate Web!</h2>
        <p class="lead">Escolha os seus chcolates e seja feliz.</p>
    </div>
    <asp:GridView ID="grdDadosProdutos" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDadosProdutos_RowCommand">
        <Columns>        
            <asp:BoundField DataField="NomeProduto" HeaderText="Produto" />
            <asp:BoundField DataField="PrecoUnitario" HeaderText="Preço Unitário" />
            <asp:BoundField DataField="UnidadesEstoque" HeaderText="Unidades em Estoque" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="addCarrinho" runat="server" CommandName="AddCarrinho" Text="Add. Carrinho"
                        CommandArgument='<%# DataBinder.Eval(Container.DataItem, "IdProduto")%>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView> 
</asp:Content>
