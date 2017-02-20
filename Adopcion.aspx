<%@ Page Title="" Language="C#" MasterPageFile="Inicio.master" AutoEventWireup="true" CodeFile="Adopcion.aspx.cs" Inherits="Adopcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <h2 class=" deep-orange-text center-align">Menu de adopción </h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenedor"  id="mascotas" runat="server">
        <div class="row">
            <button id="boton" runat="server" onserverclick="adoptar_Click" onclick="asignarValores('id','rut');">jgjg</button>
        <button id="boton2" runat="server" onserverclick="boton_ServerClick">ghghg</button>
        </div>
    </div>
    <input type="hidden" id="idAnimal" runat="server" />
    <input type="hidden" id="rut" runat="server" />
    <script src="js/jquery-2.1.0.min.js"></script>
    <script src="js/main.js"></script>
    <script src="js/funcionesRegistro.js"></script>
    <script src="js/sweetalert-master/dist/sweetalert.min.js"></script>
</asp:Content>

