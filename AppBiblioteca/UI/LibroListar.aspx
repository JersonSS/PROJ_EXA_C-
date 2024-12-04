<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroListar.aspx.cs" Inherits="UI.LibroListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
        <h3>¡Libros - Listar!</h3>
    </div>

    <div style="text-align: center; padding-bottom: 5px;">   
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/LibroRegistrar">Registrar</asp:HyperLink>
    </div>
        
    <div align="center">   
        <asp:GridView ID="gvLibros" AutoGenerateColumns="false" runat="server" ForeColor="Black" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" GridLines="None" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" PageSize="8">
            
            <Columns>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                <asp:BoundField DataField="Titulo" HeaderText="Título" SortExpression="Titulo" />
                <asp:BoundField DataField="Edicion" HeaderText="Edición" SortExpression="Edicion" />
                <asp:BoundField DataField="IdGenero" HeaderText="Género" SortExpression="GeneroDescripcion" />
                <asp:BoundField DataField="IdEditorial" HeaderText="Editorial" SortExpression="EditorialDescripcion" />
                
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("ISBN", "~/LibroEditar?paramISBN={0}") %>'>Editar</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("ISBN", "~/LibroBorrar?paramISBN={0}") %>'>Borrar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:GridView>
    </div> 


</asp:Content>
