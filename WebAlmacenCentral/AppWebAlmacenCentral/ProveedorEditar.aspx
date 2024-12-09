<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProveedorEditar.aspx.cs" Inherits="AppWebAlmacenCentral.ProveedorEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">
        <h3>¡Proveedor - Editar</h3>
    </div>

    <div align="center">
        <table style="width: 100%;">
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label1" runat="server" Text="ID Proveedor:"></asp:Label>
                </td>
                <td style="text-align:left; width:220px">
                    <asp:TextBox ID="txtIdProveedor" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:" style="text-align: left"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label3" runat="server" Text="Representante:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRepresentante" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRepresentante" runat="server" ControlToValidate="txtRepresentante" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label4" runat="server" Text="Dirección:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label5" runat="server" Text="Ciudad:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCiudad" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCiudad" runat="server" ControlToValidate="txtCiudad" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label6" runat="server" Text="Departamento:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDepartamento" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDepartamento" runat="server" ControlToValidate="txtDepartamento" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label7" runat="server" Text="Código Postal:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCodigoPostal" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label8" runat="server" Text="Teléfono:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                    <asp:Label ID="Label9" runat="server" Text="Fax:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFax" runat="server" Width="200px"></asp:TextBox>
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
