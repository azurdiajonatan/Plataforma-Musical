<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalArtista.Master" AutoEventWireup="true" CodeBehind="CrearAlbum.aspx.cs" Inherits="IPC2Proyect1.CrearAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 353px;
    }
    .auto-style2 {
        width: 540px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <script type="text/javascript">
            function showimagepreview(input) {
                if(input.files && input.files[0]){
                    var reader = new FileReader();
                    reader.onload = function (e) {

                        document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
                    }
                    reader.readAsDataURL(input.files[0]);
                }
            }
        </script>

    <table style="width:100%;">
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="idartista" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Crear Album"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Titulo:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtitulo" runat="server" Width="390px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" Text="Fecha"></asp:Label>
            :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txfecha" runat="server" TextMode="Date" Width="241px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Enabled="False" Font-Bold="True" Font-Size="Larger" Text="Reseña:"></asp:Label>
&nbsp;<asp:TextBox ID="txresena" runat="server" Height="100px" TextMode="MultiLine" Width="325px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Larger" Text="Portada: "></asp:Label>
&nbsp;
            <asp:Image ID="img" runat="server" Height="172px" ImageUrl="~/Imagenes/cargarimagen.png" Width="174px" />
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" onchange="showimagepreview(this)" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="txnombrecancion" runat="server" Height="25px" Width="201px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Duracion"></asp:Label>
&nbsp;<asp:TextBox ID="txduracioncancion" runat="server" Width="90px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Subir archivo:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload2" runat="server" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="banadir" runat="server" Height="39px" OnClick="banadir_Click" Text="Añadir" Width="85px" />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="listadedatos" runat="server" Height="72px" TextMode="MultiLine" Width="382px"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="grid1" runat="server" HorizontalAlign="Center">
            </asp:GridView>
            <br />
            <br />
            
            <br />
            <br />
            <asp:Label ID="mensajeador" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bfinalizar" runat="server" Height="48px" Text="Finalizar" Width="125px" OnClick="bfinalizar_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bcancelar" runat="server" Height="48px" OnClick="bcancelar_Click" Text="Cancelar" Width="125px" />
            <br />
            <br />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
