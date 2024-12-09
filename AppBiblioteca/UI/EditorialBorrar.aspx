<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditorialBorrar.aspx.cs" Inherits="UI.EditorialBorrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Editoriales - Borrar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"   ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"   ReadOnly="true"></asp:TextBox>
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
