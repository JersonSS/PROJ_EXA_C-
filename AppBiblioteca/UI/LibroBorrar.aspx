<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroBorrar.aspx.cs" Inherits="UI.LibroBorrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Libros - Borrar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label1" runat="server" Text="ISBN:"></asp:Label>
                </td>
                <td style="text-align:left; width:220px">
                    <asp:TextBox ID="txtISBN" runat="server"   ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label2" runat="server" Text="Título:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitulo" runat="server"   ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label3" runat="server" Text="Edición:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEdicion" runat="server"   ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right; width:110px"></td>
                <td style="text-align:left; width:220px ">
                    <asp:Button ID="btnBorrar" runat="server" Text="Sí, Borrar" OnClick="btnBorrar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>
