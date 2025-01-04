<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Principal.Login" %>

<asp:Content ID="LoginContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row">
            <div class="col-md-6 col-md-offset-3">
                <h2>Login</h2>
                <asp:Panel ID="pnlLogin" runat="server" CssClass="panel panel-default">
                    <div class="panel-body">
                        <asp:Label ID="lblUsername" runat="server" Text="Usuario:" AssociatedControlID="txtUsername" />
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblPassword" runat="server" Text="Contraseña:" AssociatedControlID="txtPassword" />
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
                        <br />
                        <asp:Button ID="btnSubmit" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
                    </div>
                </asp:Panel>
            </div>
        </section>
    </main>
</asp:Content>
