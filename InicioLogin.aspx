<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalLogin.Master" AutoEventWireup="true" CodeBehind="InicioLogin.aspx.cs" Inherits="IPC2Proyect1.InicioLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <br />
     <br />
   
     &nbsp;&nbsp;&nbsp;&nbsp;
   
     <asp:Label ID="Label1" runat="server" Text="Ingresar Usuario"></asp:Label>
     <asp:Image ID="Image1" runat="server" CssClass="Usuario" Height="100px" ImageAlign="Baseline" ImageUrl="~/Imagenes/messenger.png" Width="109px" />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbusuario" runat="server" OnTextChanged="tbusuario_TextChanged" Width="310px" Height="25px"></asp:TextBox>
     <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Ingresar Contraseña"></asp:Label>
  
     <br />
&nbsp;&nbsp;&nbsp;&nbsp;
  
    <asp:TextBox ID="txcontraseña" runat="server" OnTextChanged="txcontraseña_TextChanged" TextMode="Password" Width="310px" Height="25px"></asp:TextBox>
  
     <br />
  
     <br />
     <br />
  
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  
    <asp:Button ID="tbIngresar" runat="server" Height="40px" Text="Ingresar" Width="255px" OnClick="tbIngresar_Click" />
     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="tbregitrarse" runat="server" Height="40px" OnClick="tbregitrarse_Click" Text="Registrarse" Width="255px" />
     
     &nbsp;<br />
     <br />
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/InicioRecuperacion.aspx">Olvidé mi contraseña</asp:HyperLink>
     
&nbsp;<br />
     <br />
&nbsp;<asp:Label ID="Mensaje" runat="server" Font-Bold="True"></asp:Label>
&nbsp;<br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <asp:FileUpload ID="FileUpload1" runat="server" />
     <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
     
</asp:Content>
