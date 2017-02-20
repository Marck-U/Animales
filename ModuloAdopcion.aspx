<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="ModuloAdopcion.aspx.cs" Inherits="ModuloAdopcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" Runat="Server">
    <asp:textbox cssClass="col s10" ID="txtVadopcion" runat="server"></asp:textbox>
      <a class="btn-floating btn-large waves-effect waves-light red"><i class="material-icons">search</i></a>
    <div class="container center-align">
    <asp:gridview CssClass="bordered responsive-table"   runat="server" AutoGenerateColumns="False" DataKeyNames="id_Adopcion,Run,id_Animal" DataSourceID="SqlDataSource1" Height="204px" Width="150px" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="id_Adopcion" Visible="false" HeaderText="id_Adopcion"  ReadOnly="True" SortExpression="id_Adopcion" InsertVisible="False" />
            <asp:BoundField DataField="Run" HeaderText="Run" ReadOnly="True"  SortExpression="Run" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Nombre Mascota" HeaderText="Nombre Mascota" SortExpression="Nombre Mascota" />
            <asp:BoundField DataField="id_Animal" Visible="false" HeaderText="id_Animal" ReadOnly="True" SortExpression="id_Animal" InsertVisible="False" />
            <asp:BoundField DataField="Fecha Adopcion" HeaderText="Fecha Adopcion" SortExpression="Fecha Adopcion" />
        </Columns>
    </asp:gridview>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"  ConnectionString="<%$ ConnectionStrings:bd_AdopcionAnimalConnectionString %>" SelectCommand="DetalleAdopcion" FilterExpression="Convert(Run, 'System.String') LIKE '{0}%'" OnSelecting="SqlDataSource1_Selecting" SelectCommandType="StoredProcedure">
         <FilterParameters>
            <asp:ControlParameter  Name="Nombre" ControlID ="txtVadopcion" PropertyName="Text"  />
             
        </FilterParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
</asp:Content>

