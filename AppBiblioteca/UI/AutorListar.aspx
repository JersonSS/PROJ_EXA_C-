<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutorListar.aspx.cs" Inherits="UI.AutorListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align: center; background-color: cornflowerblue; padding: 10px 0px">   
        <h3>¡Autores - Listar</h3>
    </div>


    <div style="text-align: center; padding-bottom: 5px;">   
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
         <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AutorRegistrar">Registrar</asp:HyperLink>
    </div>
        
    <div align="center">   
        <asp:GridView ID="gvAutores" AutoGenerateColumns="false" runat="server" ForeColor="Black" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" GridLines="None">
            
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID"/>
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido"/>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"/>
                <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento"/>
                <asp:BoundField DataField="Nacionalidad" HeaderText="Nacionalidad" SortExpression="Nacionalidad"/>
            
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("ID","~/AutorEditar?paramID={0}") %>'>Editar</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("ID","~/AutorBorrar?paramID={0}")%>'>Borrar</asp:LinkButton>
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
