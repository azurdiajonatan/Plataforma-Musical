<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="AdmInicio.aspx.cs" Inherits="IPC2Proyect1.AdmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="tbusuario" runat="server" Height="81px" ImageUrl="~/Imagenes/usuarios.png" OnClick="tbusuario_Click" Width="74px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="tbregistrousuario" runat="server" Height="86px" ImageUrl="~/Imagenes/equipo.png" OnClick="tbregistrousuario_Click" Width="77px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="tbmusica" runat="server" Height="86px" ImageUrl="~/Imagenes/reproductor-de-musica.png" OnClick="tbmusica_Click" Width="81px" />
&nbsp;<br />
    <asp:Label ID="Label1" runat="server" Text="Gestion de Usuarios"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Consulta de usuarios"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Agregar nuevo genero"></asp:Label>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:ImageButton ID="tbeliminados" runat="server" Height="77px" ImageUrl="~/Imagenes/usuario.png" OnClick="tbeliminados_Click" Width="64px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:ImageButton ID="tbarchivos" runat="server" Height="82px" ImageUrl="~/Imagenes/archivo.png" OnClick="tbarchivos_Click" Width="79px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton1" runat="server" Height="70px" ImageUrl="~/Imagenes/crecimiento.png" Width="80px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ImageButton2" runat="server" Height="65px" ImageUrl="~/Imagenes/lineas-de-texto.png" Width="80px" OnClick="ImageButton2_Click" />
    <br />
&nbsp;<asp:Label ID="Label4" runat="server" Text="Usuarios Eliminados"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Albumes eliminados"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Reportes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Noticias"></asp:Label>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Cerrar sesion" OnClick="Button1_Click" />
&nbsp;
     
</asp:Content>
