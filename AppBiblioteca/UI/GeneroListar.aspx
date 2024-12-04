<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneroListar.aspx.cs" Inherits="UI.GeneroListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
        <h3>¡Géneros - Listar!</h3>
    </div>

    <div style="text-align: center; padding-bottom: 5px;">   
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/GeneroRegistrar">Registrar</asp:HyperLink>
    </div>
        
    <div align="center">   
        <asp:GridView ID="gvGeneros" AutoGenerateColumns="false" runat="server" ForeColor="Black" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" GridLines="None" AllowPaging="True" OnPageIndexChanging="gvGeneros_PageIndexChanging" PageSize="5">
            
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />
                
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("ID", "~/GeneroEditar?paramID={0}") %>'>Editar</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("ID", "~/GeneroBorrar?paramID={0}") %>'>Borrar</asp:LinkButton>
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
