<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AlbumesPopulares.aspx.cs" Inherits="IPC2Proyect1.AlbumesPopulares" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Albumes mas Populares</h1>


    <div class ="row">
       <asp:repeater ID ="Repeater1" runat="server">
            <ItemTemplate>
                <div class ="col-4">
                           <a href="InfoAlbum.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Titulo")%>">"><asp:Image runat ="server" ImageUrl = '<%# Eval("Foto") %>' width ="300" Height ="270"></asp:Image> </a>
                  <asp:Label runat ="server" Text = '<%# Eval("Titulo").ToString() %>'> </asp:Label>
                </div>
            </ItemTemplate>

       </asp:repeater>
   </div>

</asp:Content>
