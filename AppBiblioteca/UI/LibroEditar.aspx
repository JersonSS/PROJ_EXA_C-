<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroEditar.aspx.cs" Inherits="UI.LibroEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Libro - Editar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label5" runat="server" Text="ISBN:"></asp:Label>
                </td>
                <td style="text-align:left; width:220px">
                    <asp:TextBox ID="txtISBN" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>
                </td>
                 
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label1" runat="server" Text="Título:" style="text-align: left"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitulo" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                 
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label2" runat="server" Text="Edición:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEdicion" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEdicion" runat="server" ControlToValidate="txtEdicion" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                      <asp:CompareValidator ID="cvEdicion" runat="server" ControlToValidate="txtEdicion" ErrorMessage="¡Debe ser un número válido!" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                </td>
                 
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label3" runat="server" Text="Género:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlGenero" runat="server" Width="200px"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvGenero" runat="server" ControlToValidate="ddlGenero" InitialValue="0" ErrorMessage="¡Error, seleccione un género!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                 
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label4" runat="server" Text="Editorial:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEditorial" runat="server" Width="200px"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvEditorial" runat="server" ControlToValidate="ddlEditorial" InitialValue="0" ErrorMessage="¡Error, seleccione una editorial!" ForeColor="Red"></asp:RequiredFieldValidator>
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
