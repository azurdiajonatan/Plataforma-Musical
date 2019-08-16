<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="InfoAlbum.aspx.cs" Inherits="IPC2Proyect1.InfoAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Canciones</h1>
    <p>
        <asp:Image ID="img" runat="server" Height="153px" Width="166px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="43px" ImageUrl="~/Imagenes/favorito.png" Width="47px" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="43px" ImageUrl="~/Imagenes/estrella.png" Width="48px" OnClick="ImageButton2_Click" />
    </p>
    <p>&nbsp;</p>

        <div class ="row">
       <asp:repeater ID ="Repeater1" runat="server">
            <ItemTemplate>
                <div class ="col-10">
                    
                    <br/>      
                  <asp:Label runat ="server" Text = '<%# Eval("Nombre").ToString() %>'>  </asp:Label>  
                    <asp:Label runat ="server" Text = '<%# Eval("Duracion").ToString() %>'>  </asp:Label>  
                <asp:Label runat ="server" Text = '<%# Eval("Cancion") %>' ></asp:Label>
                          <audio controls="controls" runat="server" id="repro" src = '<%# Eval("Cancion") %>' > </audio>
                    <asp:Button ID="Megusta" runat ="server" Text = "Me Gusta"  OnClick ="Megusta_Click"></asp:Button> 
                    <asp:Button ID="Favoritos" runat ="server" Text = "Favoritos" onclick ="Favoritos_Click"></asp:Button> 
                 
                    <br/>
         

                </div>
            </ItemTemplate>

       </asp:repeater>
   </div>

    <p>&nbsp;</p>

    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="49px" ImageUrl="~/Imagenes/messenger.png" Width="52px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txcomentario" runat="server" Height="145px" Width="535px" TextMode="MultiLine"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="botonagregar" runat="server" Text="Agregar Comentario" OnClick="botonagregar_Click" />
    &nbsp;<asp:Label ID="Validar" runat="server"></asp:Label>
    </p>

    
     <div class ="row2">
       <asp:repeater ID ="Repeater2" runat="server">
            <ItemTemplate>
                <div class ="col-10">
                    
                    <br/>      
                  <asp:TextBox runat ="server" Text = '<%# Eval("Comentario").ToString() %>' Height ="145px" Width="535px" TextMode ="MultiLine" Enabled ="False">  </asp:TextBox>  
                       
                </div>
            </ItemTemplate>

       </asp:repeater>
   </div>

    


</asp:Content>
