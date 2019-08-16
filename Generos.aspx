<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Generos.aspx.cs" Inherits="IPC2Proyect1.Generos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="row">
        <asp:Repeater ID ="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <div class ="col-md-4">
                <br />
                      <a href="ConsultaporArtista.aspx?Id=<%#DataBinder.Eval(Container.DataItem,"Nombre") %>">"><img  class="img-responsive" id="logo" width="200" height="200" src="data:image/jpg;base64,<%# Convert.ToBase64String((Byte[])DataBinder.Eval(Container.DataItem,"Imagen"))%>"/></a>
                    <script type="text/javascript">
                     
                 </script>
                    <br />
                    </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
