<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultarAlbum.aspx.cs" Inherits="IPC2Proyect1.ConsultarAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Albumes </h1>
    <p>
        <asp:Label ID="dato" runat="server"></asp:Label>
    </p>
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
