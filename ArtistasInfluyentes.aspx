<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ArtistasInfluyentes.aspx.cs" Inherits="IPC2Proyect1.ArtistasInfluyentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artistas Mas Influyentes</h1>
    <p>&nbsp;</p>
       <div class ="row">
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
                <div class ="col-4">           
                  <a href="ConsultarAlbum.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Nombre")%>">"><asp:Image runat ="server" ImageUrl = '<%# Eval("Foto") %>' width ="100" Height ="90"></asp:Image> </a>
                  <asp:Label runat ="server" Text = '<%# Eval("Nombre").ToString() %>'> </asp:Label>
                </div>
            </ItemTemplate>
           </asp:Repeater>
    </div>
</asp:Content>




