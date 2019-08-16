<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearNoticia.aspx.cs" Inherits="IPC2Proyect1.CrearNoticia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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


    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#CCCCCC" Text="Crear Noticia"></asp:Label>
     <br />
     <br />
    <br />
&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Buscar Noticia:"></asp:Label>
&nbsp;
     <asp:TextBox ID="tbbuscar" runat="server" Height="25px" Width="100px"></asp:TextBox>
&nbsp;&nbsp;
     <asp:Button ID="botonbuscar" runat="server" Height="30px" OnClick="botonbuscar_Click" Text="Buscar" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label4" runat="server" Text="Opciones:"></asp:Label>
&nbsp;<asp:Button ID="botonmodificar" runat="server" Enabled="False" Height="30px" OnClick="botonmodificar_Click" Text="Modificar" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="botoneliminar" runat="server" Enabled="False" Height="30px" OnClick="botoneliminar_Click" Text="Eliminar" Width="80px" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#CCCCCC" Text="Titulo"></asp:Label>
&nbsp;
     <asp:TextBox ID="txtitulo" runat="server" Font-Bold="True" Font-Names="Arial Rounded MT Bold" Font-Size="Larger" Height="34px" Width="617px"></asp:TextBox>
    <br />
    <asp:Image ID="img" runat="server" Height="211px" ImageUrl="~/Imagenes/cargarimagen.png" Width="206px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txdescripcion" runat="server" Height="125px" TextMode="MultiLine" Width="260px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" onchange="showimagepreview(this)" Width="274px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="tbagregar" runat="server" Height="35px" Text="Agregar" Width="115px" OnClick="tbagregar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="tbcancelar" runat="server" Height="35px" Text="Cancelar" Width="115px" OnClick="tbcancelar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;<br />
     <br />
     <asp:Label ID="Verificador" runat="server"></asp:Label>
     <br />
     <br />
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Idnoticia" DataSourceID="SqlDataSource1" HorizontalAlign="Center">
         <Columns>
             <asp:BoundField DataField="Idnoticia" HeaderText="Idnoticia" InsertVisible="False" ReadOnly="True" SortExpression="Idnoticia" />
             <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
             <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
         </Columns>
     </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistroIPCConnectionString %>" SelectCommand="SELECT * FROM [inoticia]"></asp:SqlDataSource>
     <br />
     <br />
     <asp:Label ID="Mensaje" runat="server" Font-Bold="True" Font-Size="Larger" Font-Underline="True"></asp:Label>
     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
</asp:Content>
