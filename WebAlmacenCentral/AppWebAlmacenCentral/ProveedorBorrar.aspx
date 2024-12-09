<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProveedorBorrar.aspx.cs" Inherits="AppWebAlmacenCentral.ProveedorBorrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Proveedor - Borrar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label1" runat="server" Text="ID Proveedor:"></asp:Label>
                </td>
                <td style="text-align:left; width:220px">
                    <asp:TextBox ID="txtIdProveedor" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="Label3" runat="server" Text="Representante:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepresentante" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right; width:110px"></td>
                <td style="text-align:left; width:220px">
                    <asp:Button ID="btnBorrar" runat="server" Text="Sí, Borrar" OnClick="btnBorrar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>
