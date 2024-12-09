<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProveedorListar.aspx.cs" Inherits="AppWebAlmacenCentral.ProveedorListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
        <h3>¡Proveedores - Listar</h3>
    </div>


    <div style="text-align: center; padding-bottom: 5px;">   
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
         <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ProveedorRegistrar">Registrar</asp:HyperLink>
    </div>
        
    <div align="center">   
        <asp:GridView ID="gvProveedores" AutoGenerateColumns="false" runat="server" ForeColor="Black" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" GridLines="None" AllowPaging="True" OnPageIndexChanging="gvProveedores_PageIndexChanging" PageSize="5">
            
            <Columns>
                <asp:BoundField DataField="IdProveedor" HeaderText="ID Proveedor" SortExpression="IdProveedor"/>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"/>
                <asp:BoundField DataField="Representante" HeaderText="Representante" SortExpression="Representante"/>
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" SortExpression="Direccion"/>
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" SortExpression="Ciudad"/>
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" SortExpression="Departamento"/>
                <asp:BoundField DataField="CodigoPostal" HeaderText="Código Postal" SortExpression="CodigoPostal"/>
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" SortExpression="Telefono"/>
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax"/>
            
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("IdProveedor", "~/ProveedorEditar?paramID={0}") %>'>Editar</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("IdProveedor", "~/ProveedorBorrar?paramID={0}") %>'>Borrar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
    </div> 


</asp:Content>
