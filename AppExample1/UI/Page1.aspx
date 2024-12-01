<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="UI.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Hello World with Page1</h3>
    </div>

    <div style="text-align: center; color: black; background-color: orange; font-size: x-large; border: 1px solid">
        <asp:Label ID="Label1" runat="server" Text="Label">ASP.NET - WEB FORM</asp:Label>
    </div>

    <div style="text-align: center; margin: 10px 0px;">
        <asp:Label ID="lblFechaHora" runat="server" Text=""></asp:Label>
    </div>

    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">
        <asp:Label ID="Label2" runat="server" Text="Label">Ingrese nombre: </asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" /> <br><br />
        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>


    </div>

    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">
        <asp:Label runat="server" Text="Idioma:" ID="ctl09"></asp:Label>
        <asp:DropDownList runat="server" ID="ddlIdioma" Height="26px" Width="140px">
            <asp:ListItem>--Seleccione--</asp:ListItem>
            <asp:ListItem>Inglés</asp:ListItem> 
            <asp:ListItem>Francés</asp:ListItem> 
            <asp:ListItem>Alemán</asp:ListItem> 

        </asp:DropDownList>
        <asp:Button runat="server" Text="Ejecutar" ID="btnEjecutar" OnClick="btnEjecutar_Click" /> <br /> <br />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

     </div>


    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">
        <asp:Button ID="btnPage2" runat="server" Text="Visitar Page2" OnClick="btnPage2_Click"></asp:Button>
        

    </div>

    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page3" >Visitar Page3</asp:HyperLink>
        
    </div>


    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">
        <a href="/Page4.aspx">Visitar Page4</a>
        
    </div>
 
    <div style="margin: 10px 0px; background-color: antiquewhite; padding: 10px; text-align: center;">&nbsp;</div>
   
   

</asp:Content>
