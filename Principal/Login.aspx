<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Principal.Login" %>

<asp:Content ID="LoginContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row">
            <!-- <div class="col-md-6 col-md-offset-3">
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
            </div>-->

            <div class="container" style="background-color: #fdffb6; height: 100vh; display: flex; align-items: center; justify-content: center;">
                <div class="card p-4" style="max-width: 400px; border: 2px solid #a0c4ff; background-color: #caffbf;">
                    <h2 class="text-center mb-4" style="color: #ffc6ff;">Iniciar Sesión</h2>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control mb-3" Placeholder="Usuario" Style="border-color: #a0c4ff;" />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control mb-4" Placeholder="Contraseña" TextMode="Password" Style="border-color: #a0c4ff;" />
                    <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary w-100" Style="background-color: #ffc6ff; border-color: #a0c4ff;" />
                </div>
            </div>

            <div class="container mt-4" style="background-color: #fdffb6; border: 2px solid #a0c4ff; padding: 20px; border-radius: 10px;">

                <!-- Espacio de trabajo -->
                <h3 class="mb-3" style="color: #a0c4ff;">Espacio de Trabajo</h3>
                <div class="table-responsive">
                    <asp:GridView ID="gridView" runat="server" CssClass="table table-striped" Style="border-color: #a0c4ff;">

                       


                    </asp:GridView>
                     <div class="container" style="background-color: #fdffb6; height: 100vh; display: flex; align-items: center; justify-content: center;">
     <div class="card p-4" style="max-width: 400px; border: 2px solid #a0c4ff; background-color: #caffbf;">
         <h2 class="text-center mb-4" style="color: #ffc6ff;">Iniciar Sesión</h2>
         <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control mb-3" Placeholder="Usuario" Style="border-color: #a0c4ff;" />
         <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control mb-4" Placeholder="Contraseña" TextMode="Password" Style="border-color: #a0c4ff;" />
         <asp:Button ID="Button1" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary w-100" Style="background-color: #ffc6ff; border-color: #a0c4ff;" />
     </div>
 </div>
                </div>
                <div class="mt-3">
                    <asp:Button ID="btnAdd" runat="server" Text="Agregar" CssClass="btn" Style="background-color: #ffc6ff; border-color: #a0c4ff;" />
                </div>

            </div>



        </section>
    </main>
</asp:Content>

