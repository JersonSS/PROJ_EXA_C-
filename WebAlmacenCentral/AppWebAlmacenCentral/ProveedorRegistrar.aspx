<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProveedorRegistrar.aspx.cs" Inherits="AppWebAlmacenCentral.ProveedorRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
     <h3>¡Proveedores - Registrar</h3>
     </div>
     
     <div align="center">   
         <table style="width: 100%;">

             <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Nombre" style="text-align: center"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" Width="200px"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rvfID" runat="server" ControlToValidate="txtID" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" style="text-align: center"></asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                 <td>
                     <asp:Label ID="Label1" runat="server" Text="Nombre" style="text-align: center"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>

                     <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red" style="text-align: center"></asp:RequiredFieldValidator>

                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="Label2" runat="server" Text="Representante"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtRepresentante" runat="server" Width="200px"></asp:TextBox>

                     <asp:RequiredFieldValidator ID="rfvRepresentante" runat="server" ControlToValidate="txtRepresentante" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>

                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtDireccion" runat="server" Width="200px"></asp:TextBox>

                     <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Ciudad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCiudad" runat="server" Width="200px"></asp:TextBox>
                
                    <asp:RequiredFieldValidator ID="rfvCiudad" runat="server" ControlToValidate="txtCiudad" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Departamento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDepartamento" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfDepartamento" runat="server" ControlToValidate="txtDepartamento" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Código Postal"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCodigoPostal" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfCodigo" runat="server" ControlToValidate="txtCodigoPostal" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Teléfono"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfTelefono" runat="server" ControlToValidate="txtTelefono" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Fax"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFax" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfFax" runat="server" ControlToValidate="txtFax" Display="Dynamic" ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                   
                </td>
                <td>&nbsp;</td>
            </tr>
         </table>
         
     </div> 

</asp:Content>
