<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Account_Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Faça seu cadastro.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Login" CssClass="col-md-2 control-label">Login</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Login" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Login"
                    CssClass="text-danger" ErrorMessage="O Login é de prenchimento obrigatório." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="A senha é obrigatória." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirmação de Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="A Confirmação de Senha é de preenchimento obrigatório." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="As senhas não coincidem" />
            </div>
        </div>
        <div class="form-horizontal">
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtCpf" CssClass="col-md-2 control-label">CPF</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtCpf" CssClass="form-control" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" OnClick="ConsultarCpf_Click" Text="Consultar CPF" CssClass="btn btn-default" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNomeCompleto" CssClass="col-md-2 control-label">Nome Completo</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtNomeCompleto" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEndereco" CssClass="col-md-2 control-label">Endereço</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtEndereco" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtTelefone" CssClass="col-md-2 control-label">Telefone</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtTelefone" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CriarCliente_Click" Text="Registrar" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>

