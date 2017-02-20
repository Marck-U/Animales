<%@ Page Title="" Language="C#" MasterPageFile="Inicio.master" AutoEventWireup="true" CodeFile="Mapa.aspx.cs" Inherits="Mapa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h1 class="center">Mapa Veterinaria</h1>

            <div class="col l8">
                <div id="map" style="height:500px;"></div>
            </div>
            <div class="col l4">
                <div id="info"></div>
            </div>
        </div>
<%--    <script src="js/Geolocalizacion.js"></script>--%>
     <script   async="async" defer="defer"
      src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB5zl7MfBVpQ9xVNUXBqAhhyA8kti2huTI&callback=initMap">
    </script>
    <script src="js/src/User_Location.js"></script>
    <script src="js/src/Geo.js"></script>
</asp:Content>

