<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalLogin.Master" AutoEventWireup="true" CodeBehind="InicioRecuperacion.aspx.cs" Inherits="IPC2Proyect1.InicioRecuperacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Image ID="Image1" runat="server" CssClass="Usuario" ImageUrl="~/Imagenes/Signo.png" Height="116px" Width="120px" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbfecha" runat="server" Width="260px" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Ingresar correo"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbcorreo" runat="server" Width="260px" OnTextChanged="tbcorreo_TextChanged"></asp:TextBox>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="tbrecuperar" runat="server" Height="41px" Text="Recuperar Contraseña" Width="255px" OnClick="tbrecuperar_Click" />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="tbcancelar" runat="server" OnClick="tbcancelar_Click" Text="Regresar" Height="41px" Width="255px" />
    <br />
    <br />
    <asp:Label ID="mostrar" runat="server" Font-Bold="True" Font-Underline="True"></asp:Label>
    <br />
    <br />
    <asp:Label ID="mostrarcontra" runat="server" Font-Bold="True" Font-Underline="True"></asp:Label>
</asp:Content>
