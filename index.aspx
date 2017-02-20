<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Empieza carrusel fullscreen-->
    <div class="fullscreen">
        <div class="slider">
            <ul class="slides">
                <li>
                    <img src="image/slider8.jpg"/>
                    <div class="caption left-align">
                        <h3 class="deep-orange-text">Adoptame!</h3>
                        <h5 class="deep-orange-text">Necesito un hogar!</h5>
                    </div>
                </li>
                <li>
                    <img src="image/slider10.jpg">
                    <div class="caption left-align">
                        <h3 class="deep-orange-text">Soy el mejor  compañero</h3>
                        <h5 class="deep-orange-text">Siempre estaré ahí.</h5>
                    </div>
                </li>
                <li>
                    <img src="image/slider3.jpg"/>
                    <div class="caption right-align">
                        <h3 class="deep-orange-text">Siempre te seré fiel!</h3>
                        <h5 class="deep-orange-text">Nunca te abandonaré.</h5>
                    </div>
                </li>
                <li>
                    <img src="image/slider5.jpg">
                    <div class="caption center-align">
                        <h3 class="deep-orange-text">Seremos de la calle.</h3>
                        <h5 class="deep-orange-text">Pero necesitamos un dueño!.</h5>
                    </div>
                </li>
            </ul>
        </div>
    </div>
    <!-- Parallax-->
    <div class="container">
        <div class="section">
            <div class="row">
                <div class="col s12 m6">
                    <div class="icon-block">
                        <h2 class="center deep-orange-text"><i class="material-icons">pets</i></h2>
                        <h5 class="center">Proyecto adopción animal</h5>
                        <p class="light">
                            El objetivo es crear un portal donde se pueda compartir información sobre animales y sus tipos de cuidado, para que distinta gente pueda informarse sobre este tema.
                            Otro objetivo es que distintas personas puedan ver publicación de adopción animal para hacer online y sea más cómodo.
                        </p>
                    </div>
                </div>
                <!-- Contenido-->
                <div class="col s12 m6">
                    <div class="icon-block">
                        <h2 class="center  deep-orange-text"><i class="material-icons">group</i></h2>
                        <h5 class="center">Sobre mi</h5>
                        <p class="light">Esta iniciativa la inicia con el propósito de ayudar a las mascotas, mi propósito como alumno de Inacap es mejorar fomentar todo esto Soy Marco Azúa Ulloa Estudiante de Inacap de la carrera Analista Programador.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Parallax-->
    <div id="index-banner" class="parallax-container">
        <div class="section no-pad-bot">
            <div class="container">
                <br/>
                <br/>
                <h1 class="header center deep-orange-text">Cazadores No me odien</h1>
                <div class="row center">
                    <h5 class="header col s12 deep-orange-text">Con el fin de fomentar la adopción de mascotas callejeras se creo está pagina, si quieres formar parte registrate aquí</h5>
                </div>
                <div class="row center">
                    <a href="Registro.aspx" id="download-button" class="btn-large waves-effect deep-orange teal lighten-1">Registrate</a>
                </div>
                <br/>
                <br/>
            </div>
        </div>
        <div class="parallax">
            <img src="image/fondo2.jpg"/>
        </div>
    </div>
    <div class="container">
        <div class="section">

            <div class="row">
                <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Proyecto Adopción Animal</h4>
                    <p class="left-align light">Se pretende publicar información sobre tips de cuidado animal, salud, los tipos de vacunas y a qué edad se deberían poner las respectivas vacunas, además se considerará un mapa donde se pueda enterar de que veterinaria esté más cerca del lugar donde se encuentra la persona. Las personas tendrán que registrarse para poder verificar su información y conocer más de ellas, luego de que se registren podrán adoptar una mascota, el portal será gratuito ya que este proyecto es solo un aporte para la sociedad</p>
                </div>
            </div>
        </div>
    </div>
    <div class="parallax-container valign-wrapper">
        <div class="section no-pad-bot">
            <div class="container">
                <div class="row center">
                    <h5 class="header col s12  deep-orange-text ">¿Para qué una pareja si puedes adoptar a una mascota? Te será más fiel que nadie</h5>
                </div>
            </div>
        </div>
        <div class="parallax">
            <img src="image/fondo2.jpg" alt="Unsplashed fondo 2">
        </div>
    </div>
</asp:Content>

