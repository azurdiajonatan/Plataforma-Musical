<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultaporArtista.aspx.cs" Inherits="IPC2Proyect1.ConsultaporArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artistas</h1>
    <div class ="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class ="col-4">
                           <a href="ConsultarAlbum.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Nombre")%>">"><asp:Image runat ="server" ImageUrl = '<%# Eval("Foto") %>' width ="300" Height ="270"></asp:Image> </a>
                  <asp:Label runat ="server" Text = '<%# Eval("Nombre").ToString() %>'> </asp:Label>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <p>
        <asp:Label ID="consultor" runat="server"></asp:Label>
    </p>
    
</asp:Content>
