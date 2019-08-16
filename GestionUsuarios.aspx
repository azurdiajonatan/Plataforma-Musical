<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="GestionUsuarios.aspx.cs" Inherits="IPC2Proyect1.GestionUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Gestion de Usuarios&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Buscar"></asp:Label>
&nbsp;<asp:TextBox ID="txbuscar" runat="server" BorderStyle="Double" OnTextChanged="TextBox1_TextChanged" Width="290px"></asp:TextBox>
&nbsp;
        <asp:Button ID="tbbuscar" runat="server" Height="25px" OnClick="tbbuscar_Click" Text="Verificar" Width="115px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="tbregresar" runat="server" Height="25px" OnClick="tbregresar_Click" Text="Inicio" Width="100px" />
    </h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Crear Usuario"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="tbmodificar" runat="server" Enabled="False" Height="25px" OnClick="tbmodificar_Click" Text="Modificar" Width="115px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="tbeliminar" runat="server" Enabled="False" Height="25px" OnClick="tbeliminar_Click" Text="Eliminar" Width="115px" />
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre y Apellido:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txnombre" runat="server" Width="230px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Usuario:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txusuario" runat="server" Width="270px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txcontraseña" runat="server" Width="220px"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;<asp:Label ID="Label5" runat="server" Text="Correo:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txcorreo" runat="server" Width="220px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Fecha de nacimiento:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txfecha" runat="server" TextMode="Date" Width="135px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Tipo:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="tltipo" runat="server">
            <asp:ListItem>Usuario</asp:ListItem>
            <asp:ListItem>Administrador</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Estado:"></asp:Label>
&nbsp;<asp:RadioButton ID="rbactivo" runat="server" GroupName="Estados" Text="Activo" />
&nbsp;
        <asp:RadioButton ID="rbdesactivado" runat="server" GroupName="Estados" Text="Desactivado" />
&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;<asp:Button ID="tbcrear" runat="server" Height="25px" OnClick="tbcrear_Click" Text="Crear" Width="75px" />
&nbsp;&nbsp;
        <asp:Button ID="tbcancelar" runat="server" Height="25px" OnClick="tbcancelar_Click" Text="No crear" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Advertencia" runat="server"></asp:Label>
&nbsp;
        <asp:Label ID="Informacion" runat="server"></asp:Label>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_Usuario" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_Usuario" HeaderText="id_Usuario" InsertVisible="False" ReadOnly="True" SortExpression="id_Usuario" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="CreaFecha" HeaderText="Fecha de Creación" SortExpression="CreaFecha" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
                <asp:CheckBoxField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                <asp:BoundField DataField="id_Artista" HeaderText="id_Artista" SortExpression="id_Artista" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistroIPCConnectionString %>" SelectCommand="SELECT * FROM [iusuario]"></asp:SqlDataSource>
    </p>
</asp:Content>
