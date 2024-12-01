<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutorEditar.aspx.cs" Inherits="UI.AutorEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
  <h3>¡Autores - Editar</h3>
  </div>
  
  <div align="center">   
      <table style="width: 100%;">
          <tr>
            <td style="text-align:right; width:283px">
                <asp:Label ID="Label5" runat="server" Text="AutorID:"></asp:Label>
            </td>
            <td style="text-align:left; width:220px">
                <asp:TextBox ID="txtID" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>

            </td>
            <td>&nbsp;</td>
        </tr>
          <tr>
              <td>
                  <asp:Label ID="Label1" runat="server" Text="Apellido:"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtApellido" runat="server" Width="200px"></asp:TextBox>

              </td>
              <td>&nbsp;</td>
          </tr>
          <tr>
              <td>
                  <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>

              </td>
              <td>&nbsp;</td>
        </tr>
          <tr>
              <td>
                  <asp:Label ID="Label3" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="200px"></asp:TextBox>

              </td>
              <td>&nbsp;</td>
          </tr>
          <tr>
             <td>
                 <asp:Label ID="Label4" runat="server" Text="Nacionalidad:"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtNacionalidad" runat="server" Width="200px"></asp:TextBox>

             </td>
             <td>&nbsp;</td>
         </tr>
         <tr>
             <td></td>
             <td>
                 <asp:Button ID="btnGuardar" runat="server" Text="Guardar"/>
                 <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
             </td>
             <td>&nbsp;</td>
         </tr>
      </table>
      
  </div> 
</asp:Content>
