<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditorialEditar.aspx.cs" Inherits="UI.EditorialEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Editorial - Editar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label1" runat="server" Text="ID Editorial:"></asp:Label>
                </td>
                <td style="text-align:left; width:220px">
                    <asp:TextBox ID="txtID" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px"></td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
